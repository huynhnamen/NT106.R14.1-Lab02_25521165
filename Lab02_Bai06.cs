using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Lab02_Bai06 : Form
    {
        string chuoiKetNoi = "Data Source=HomNayAnGi.db;Version=3;";
        List<MonAn> danhSachMonAn = new List<MonAn>();
        string duongDanAnh = "";

        public Lab02_Bai06()
        {
            InitializeComponent();
            picMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            KhoiTaoCoSoDuLieu();
            HienThiDanhSach();
        }

        private void KhoiTaoCoSoDuLieu()
        {
            if (File.Exists("HomNayAnGi.db") == false)
            {
                SQLiteConnection.CreateFile("HomNayAnGi.db");
            }

            SQLiteConnection conn = new SQLiteConnection(chuoiKetNoi);
            conn.Open();

            string sqlBangNguoiDung = "CREATE TABLE IF NOT EXISTS NguoiDung (IDNCC INTEGER PRIMARY KEY AUTOINCREMENT, HoVaTen TEXT, QuyenHan TEXT)";
            SQLiteCommand cmd1 = new SQLiteCommand(sqlBangNguoiDung, conn);
            cmd1.ExecuteNonQuery();

            string sqlBangMonAn = "CREATE TABLE IF NOT EXISTS MonAn (IDMA INTEGER PRIMARY KEY AUTOINCREMENT, TenMonAn TEXT, HinhAnh TEXT, IDNCC INTEGER)";
            SQLiteCommand cmd2 = new SQLiteCommand(sqlBangMonAn, conn);
            cmd2.ExecuteNonQuery();

            string sqlDem = "SELECT COUNT(*) FROM MonAn";
            SQLiteCommand cmdDem = new SQLiteCommand(sqlDem, conn);
            object? ketQuaDem = cmdDem.ExecuteScalar();
            long soLuong = 0;
            if (ketQuaDem != null)
            {
                soLuong = Convert.ToInt64(ketQuaDem);
            }

            if (soLuong == 0)
            {
                string sqlThemNCC = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES ('Mặc định', 'Admin'); SELECT last_insert_rowid();";
                SQLiteCommand cmdNCC = new SQLiteCommand(sqlThemNCC, conn);
                object? ketQuaNCC = cmdNCC.ExecuteScalar();
                long idNCC = 1;
                if (ketQuaNCC != null)
                {
                    idNCC = Convert.ToInt64(ketQuaNCC);
                }

                string[] monMacDinh = { "Bún riêu", "Bún thịt nướng", "Cơm tấm sườn trứng", "Phở", "Gỏi cuốn" };
                for (int i = 0; i < monMacDinh.Length; i++)
                {
                    string sqlThemMon = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('" + monMacDinh[i] + "', '', " + idNCC + ")";
                    SQLiteCommand cmdMon = new SQLiteCommand(sqlThemMon, conn);
                    cmdMon.ExecuteNonQuery();
                }
            }

            conn.Close();
        }

        private void HienThiDanhSach()
        {
            txtDanhSach.Clear();
            danhSachMonAn.Clear();

            SQLiteConnection conn = new SQLiteConnection(chuoiKetNoi);
            conn.Open();

            string sql = "SELECT MonAn.IDMA, MonAn.TenMonAn, MonAn.HinhAnh, NguoiDung.HoVaTen " +
                         "FROM MonAn INNER JOIN NguoiDung ON MonAn.IDNCC = NguoiDung.IDNCC " +
                         "ORDER BY MonAn.IDMA ASC";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            string noiDungHienThi = "";

            while (reader.Read())
            {
                MonAn m = new MonAn();
                m.IDMA = int.Parse(reader["IDMA"].ToString() ?? "0");
                m.TenMonAn = reader["TenMonAn"].ToString() ?? "";
                m.HinhAnh = reader["HinhAnh"].ToString() ?? "";
                m.TenNguoiDongGop = reader["HoVaTen"].ToString() ?? "";

                danhSachMonAn.Add(m);
                noiDungHienThi = noiDungHienThi + m.TenMonAn + " (" + m.TenNguoiDongGop + ")\r\n";
            }

            reader.Close();
            conn.Close();

            txtDanhSach.Text = noiDungHienThi;
        }

        private void txtNguoiDongGop_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh món ăn";
            ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                duongDanAnh = ofd.FileName;
                MessageBox.Show("Đã tải hình ảnh thành công!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string monMoi = txtMonAn.Text.Trim();
            string nguoiDongGop = txtNguoiDongGop.Text.Trim();

            if (monMoi == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn cần thêm!");
                txtMonAn.Focus();
                return;
            }

            if (duongDanAnh == "" || File.Exists(duongDanAnh) == false)
            {
                MessageBox.Show("Vui lòng tải hình ảnh cho món ăn trước khi thêm!");
                return;
            }

            if (nguoiDongGop == "" || nguoiDongGop == "Mặc định")
            {
                nguoiDongGop = "Ẩn danh";
            }

            SQLiteConnection conn = new SQLiteConnection(chuoiKetNoi);
            conn.Open();

            string sqlTimNCC = "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @ten";
            SQLiteCommand cmdTim = new SQLiteCommand(sqlTimNCC, conn);
            cmdTim.Parameters.AddWithValue("@ten", nguoiDongGop);
            object? ketQuaTim = cmdTim.ExecuteScalar();

            long idNCC = 0;
            if (ketQuaTim != null)
            {
                idNCC = Convert.ToInt64(ketQuaTim);
            }
            else
            {
                string sqlThemNCC = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@ten, 'User'); SELECT last_insert_rowid();";
                SQLiteCommand cmdThemNCC = new SQLiteCommand(sqlThemNCC, conn);
                cmdThemNCC.Parameters.AddWithValue("@ten", nguoiDongGop);
                object? ketQuaThem = cmdThemNCC.ExecuteScalar();
                if (ketQuaThem != null)
                {
                    idNCC = Convert.ToInt64(ketQuaThem);
                }
            }

            string sqlThemMon = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@tenMon, @hinh, @idncc)";
            SQLiteCommand cmdThemMon = new SQLiteCommand(sqlThemMon, conn);
            cmdThemMon.Parameters.AddWithValue("@tenMon", monMoi);
            cmdThemMon.Parameters.AddWithValue("@hinh", duongDanAnh);
            cmdThemMon.Parameters.AddWithValue("@idncc", idNCC);
            cmdThemMon.ExecuteNonQuery();

            conn.Close();

            HienThiDanhSach();

            txtMonAn.Clear();
            txtNguoiDongGop.Clear();
            duongDanAnh = "";
            txtMonAn.Focus();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (danhSachMonAn.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống! Vui lòng thêm món ăn trước.");
                return;
            }

            Random rd = new Random();
            int viTriNgauNhien = rd.Next(0, danhSachMonAn.Count);

            MonAn monDuocChon = danhSachMonAn[viTriNgauNhien];

            txtKetQua.Text = monDuocChon.TenMonAn + " (" + monDuocChon.TenNguoiDongGop + ")";

            if (monDuocChon.HinhAnh != "" && File.Exists(monDuocChon.HinhAnh))
            {
                picMonAn.Image = Image.FromFile(monDuocChon.HinhAnh);
            }
            else
            {
                picMonAn.Image = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int viTriCanXoa = -1;

            for (int i = danhSachMonAn.Count - 1; i >= 0; i--)
            {
                if (danhSachMonAn[i].TenNguoiDongGop != "Mặc định")
                {
                    viTriCanXoa = i;
                    break;
                }
            }

            if (viTriCanXoa == -1)
            {
                MessageBox.Show("Không có món ăn mới nào để xóa (các món mặc định được giữ nguyên)!");
                return;
            }

            int idCanXoa = danhSachMonAn[viTriCanXoa].IDMA;
            string tenMonBiXoa = danhSachMonAn[viTriCanXoa].TenMonAn;

            SQLiteConnection conn = new SQLiteConnection(chuoiKetNoi);
            conn.Open();

            string sqlXoa = "DELETE FROM MonAn WHERE IDMA = @id";
            SQLiteCommand cmdXoa = new SQLiteCommand(sqlXoa, conn);
            cmdXoa.Parameters.AddWithValue("@id", idCanXoa);
            cmdXoa.ExecuteNonQuery();

            conn.Close();

            HienThiDanhSach();

            txtMonAn.Clear();
            txtNguoiDongGop.Clear();
            txtKetQua.Clear();
            duongDanAnh = "";
            picMonAn.Image = null;
            txtMonAn.Focus();

            MessageBox.Show("Đã xóa món ăn sau cùng: " + tenMonBiXoa);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class MonAn
    {
        public int IDMA { get; set; }
        public string TenMonAn { get; set; } = "";
        public string HinhAnh { get; set; } = "";
        public string TenNguoiDongGop { get; set; } = "";
    }
}