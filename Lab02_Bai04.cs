using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab02_Bai04 : Form
    {

        List<SinhVien> danhSachSV = new List<SinhVien>();

        int viTriHienTai = -1;

        public Lab02_Bai04()
        {
            InitializeComponent();
            lblSoTrang.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenNhap.Text == "" || txtMSSVNhap.Text == "" || txtDienThoaiNhap.Text == "" ||
                txtDiem1Nhap.Text == "" || txtDiem2Nhap.Text == "" || txtDiem3Nhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            int mssv;
            if (int.TryParse(txtMSSVNhap.Text, out mssv) == false || txtMSSVNhap.Text.Length != 8)
            {
                MessageBox.Show("MSSV phải là số và có đúng 8 chữ số!");
                return;
            }

            string sdt = txtDienThoaiNhap.Text;
            if (sdt.Length != 10 || sdt[0] != '0')
            {
                MessageBox.Show("Số điện thoại phải có 10 số và bắt đầu bằng số 0!");
                return;
            }
            for (int i = 0; i < sdt.Length; i++)
            {
                if (sdt[i] < '0' || sdt[i] > '9')
                {
                    MessageBox.Show("Số điện thoại chỉ được chứa các chữ số!");
                    return;
                }
            }

            float d1, d2, d3;
            if (float.TryParse(txtDiem1Nhap.Text, out d1) == false ||
                float.TryParse(txtDiem2Nhap.Text, out d2) == false ||
                float.TryParse(txtDiem3Nhap.Text, out d3) == false)
            {
                MessageBox.Show("Điểm phải là số!");
                return;
            }

            if (d1 < 0 || d1 > 10 || d2 < 0 || d2 > 10 || d3 < 0 || d3 > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!");
                return;
            }

            SinhVien sv = new SinhVien();
            sv.HoTen = txtTenNhap.Text;
            sv.MSSV = mssv;
            sv.DienThoai = sdt;
            sv.DiemToan = d1;
            sv.DiemVan = d2;
            sv.DiemAnh = d3;
            sv.DiemTrungBinh = (d1 + d2 + d3) / 3.0f;

            danhSachSV.Add(sv);
            CapNhatManHinhGiua();

            txtTenNhap.Text = ""; txtMSSVNhap.Text = ""; txtDienThoaiNhap.Text = "";
            txtDiem1Nhap.Text = ""; txtDiem2Nhap.Text = ""; txtDiem3Nhap.Text = "";
            txtTenNhap.Focus();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (danhSachSV.Count == 0)
            {
                MessageBox.Show("Bảng đang trống, chưa có sinh viên nào để ghi!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Chọn nơi lưu danh sách sinh viên";
            sfd.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";
            sfd.FileName = "output4.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string jsonString = JsonSerializer.Serialize(danhSachSV);

                FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(jsonString);

                sw.Close();
                fs.Close();

                CapNhatManHinhGiua();
                MessageBox.Show("Đã lưu toàn bộ dữ liệu ra file: " + sfd.FileName);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file danh sách sinh viên cần nạp";
            ofd.Filter = "Text Files (*.txt)|*.txt|JSON Files (*.json)|*.json|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (danhSachSV.Count > 0)
                {
                    DialogResult luaChon = MessageBox.Show(
                        "Bảng hiện tại đang có dữ liệu. Bạn có muốn xóa sạch để nạp mới (Yes) hay nối thêm vào danh sách cũ (No)?",
                        "Cảnh báo nạp file",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question);

                    if (luaChon == DialogResult.Yes)
                    {
                        danhSachSV.Clear(); 
                    }
                    else if (luaChon == DialogResult.Cancel)
                    {
                        return; 
                    }
                }

                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string jsonString = sr.ReadToEnd();
                sr.Close();
                fs.Close();

                try
                {
                    List<SinhVien>? mangMoiDoc = JsonSerializer.Deserialize<List<SinhVien>>(jsonString);

                    if (mangMoiDoc != null)
                    {
                        for (int i = 0; i < mangMoiDoc.Count; i++)
                        {
                            danhSachSV.Add(mangMoiDoc[i]);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("File không đúng định dạng JSON chuẩn của chương trình!");
                    return;
                }

                for (int i = 0; i < danhSachSV.Count; i++)
                {
                    danhSachSV[i].DiemTrungBinh = (danhSachSV[i].DiemToan + danhSachSV[i].DiemVan + danhSachSV[i].DiemAnh) / 3.0f;
                }

                CapNhatManHinhGiua();
                viTriHienTai = 0;
                HienThiMotSinhVien();

                MessageBox.Show("Đã nạp dữ liệu từ file vào bảng thành công!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (viTriHienTai > 0)
            {
                viTriHienTai--;
                HienThiMotSinhVien();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (viTriHienTai < danhSachSV.Count - 1)
            {
                viTriHienTai++;
                HienThiMotSinhVien();
            }
        }

        private void CapNhatManHinhGiua()
        {
            rtbHienThi.Text = "";
            for (int i = 0; i < danhSachSV.Count; i++)
            {
                rtbHienThi.Text += danhSachSV[i].HoTen + "\r\n"
                                + danhSachSV[i].MSSV + "\r\n"
                                + danhSachSV[i].DienThoai + "\r\n"
                                + danhSachSV[i].DiemToan + "\r\n"
                                + danhSachSV[i].DiemVan + "\r\n"
                                + danhSachSV[i].DiemAnh + "\r\n\r\n";
            }
        }

        private void HienThiMotSinhVien()
        {
            if (viTriHienTai >= 0 && viTriHienTai < danhSachSV.Count)
            {
                txtTenXem.Text = danhSachSV[viTriHienTai].HoTen;
                txtMSSVXem.Text = danhSachSV[viTriHienTai].MSSV.ToString();
                txtDienThoaiXem.Text = danhSachSV[viTriHienTai].DienThoai;
                txtDiem1Xem.Text = danhSachSV[viTriHienTai].DiemToan.ToString();
                txtDiem2Xem.Text = danhSachSV[viTriHienTai].DiemVan.ToString();
                txtDiem3Xem.Text = danhSachSV[viTriHienTai].DiemAnh.ToString();

                txtDTBXem.Text = Math.Round(danhSachSV[viTriHienTai].DiemTrungBinh, 2).ToString();
                lblSoTrang.Text = (viTriHienTai + 1).ToString();
            }
        }
    }

    public class SinhVien
    {
        public string HoTen { get; set; } = "";
        public int MSSV { get; set; }
        public string DienThoai { get; set; } = "";
        public float DiemToan { get; set; }
        public float DiemVan { get; set; }
        public float DiemAnh { get; set; }
        public float DiemTrungBinh { get; set; }
    }
}
