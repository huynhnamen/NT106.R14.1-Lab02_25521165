using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab02_Bai05 : Form
    {
        List<Phim> danhSachPhim = new List<Phim>();
        List<string> danhSachGheDaBan = new List<string>();

        public Lab02_Bai05()
        {
            InitializeComponent();
            string[] tatCaGhe = { "A1", "A2", "A3", "A4", "A5",
                                  "B1", "B2", "B3", "B4", "B5",
                                  "C1", "C2", "C3", "C4", "C5" };
            for (int i = 0; i < tatCaGhe.Length; i++)
            {
                clbGhe.Items.Add(tatCaGhe[i]);
            }
        }

        private void btnLoadDuLieu_Click(object sender, EventArgs e)
        {
            if (File.Exists("input5.txt") == false)
            {
                MessageBox.Show("Không tìm thấy input5.txt");
                return;
            }

            FileStream fs = new FileStream("input5.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            danhSachPhim.Clear();
            cboPhim.Items.Clear();

            string? tenPhim;
            while ((tenPhim = sr.ReadLine()) != null)
            {
                if (tenPhim == "") continue;

                string? giaVeStr = sr.ReadLine();
                string? phongStr = sr.ReadLine();

                if (giaVeStr == null || phongStr == null) break;

                Phim p = new Phim();
                p.TenPhim = tenPhim;
                p.GiaVeChuan = int.Parse(giaVeStr);
                p.DanhSachPhong = phongStr;

                danhSachPhim.Add(p);
                cboPhim.Items.Add(p.TenPhim);
            }

            sr.Close();
            fs.Close();

            if (cboPhim.Items.Count > 0)
                cboPhim.SelectedIndex = 0;

            MessageBox.Show("Đã nạp xong danh sách phim!");
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || cboPhim.Text == "" || cboPhong.Text == "" || clbGhe.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin và chọn ít nhất 1 ghế!");
                return;
            }

            string tenPhim = cboPhim.Text;
            string phong = cboPhong.Text;

            for (int i = 0; i < clbGhe.CheckedItems.Count; i++)
            {
                string ghe = clbGhe.CheckedItems[i]?.ToString() ?? "";
                string maVe = tenPhim + "-" + phong + "-" + ghe;

                if (danhSachGheDaBan.Contains(maVe))
                {
                    MessageBox.Show("Ghế " + ghe + " đã có người mua!");
                    return;
                }
            }

            int indexPhim = -1;
            for (int i = 0; i < danhSachPhim.Count; i++)
            {
                if (danhSachPhim[i].TenPhim == tenPhim)
                {
                    indexPhim = i;
                    break;
                }
            }

            double tongTien = 0;
            int giaChuan = danhSachPhim[indexPhim].GiaVeChuan;

            for (int i = 0; i < clbGhe.CheckedItems.Count; i++)
            {
                string ghe = clbGhe.CheckedItems[i]?.ToString() ?? "";
                double giaGhe = 0;

                if (ghe == "A1" || ghe == "A5" || ghe == "C1" || ghe == "C5")
                    giaGhe = giaChuan * 0.25;
                else if (ghe == "B2" || ghe == "B3" || ghe == "B4")
                    giaGhe = giaChuan * 2;
                else
                    giaGhe = giaChuan * 1;

                tongTien += giaGhe;

                danhSachGheDaBan.Add(tenPhim + "-" + phong + "-" + ghe);

                danhSachPhim[indexPhim].SoVeDaBan++;
                danhSachPhim[indexPhim].DoanhThu += giaGhe;
            }

            for (int i = 0; i < clbGhe.Items.Count; i++)
            {
                clbGhe.SetItemChecked(i, false);
            }

            rtbHoaDon.Text = "Họ tên: " + txtHoTen.Text + "\r\nPhim: " + tenPhim +
                             "\r\nThanh toán: " + tongTien + " VNĐ";
        }

        private void btnXuatThongKe_Click(object sender, EventArgs e)
        {
            if (danhSachPhim.Count == 0) return;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = danhSachPhim.Count;
            progressBar1.Value = 0;

            Phim[] mangXepHang = new Phim[danhSachPhim.Count];
            for (int i = 0; i < danhSachPhim.Count; i++)
            {
                mangXepHang[i] = danhSachPhim[i];
            }

            for (int i = 0; i < mangXepHang.Length - 1; i++)
            {
                for (int j = i + 1; j < mangXepHang.Length; j++)
                {
                    if (mangXepHang[i].DoanhThu < mangXepHang[j].DoanhThu)
                    {
                        Phim temp = mangXepHang[i];
                        mangXepHang[i] = mangXepHang[j];
                        mangXepHang[j] = temp;
                    }
                }
            }

            FileStream fs = new FileStream("output5.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("===== BÁO CÁO THỐNG KÊ DOANH THU PHÒNG VÉ =====");

            for (int i = 0; i < mangXepHang.Length; i++)
            {
                Phim p = mangXepHang[i];

                string[] cacPhong = p.DanhSachPhong.Split(',');
                int tongSoVeToiDa = cacPhong.Length * 15;

                int veTon = tongSoVeToiDa - p.SoVeDaBan;

                double tiLeBan = 0;
                if (tongSoVeToiDa > 0)
                {
                    tiLeBan = ((double)p.SoVeDaBan / tongSoVeToiDa) * 100.0;
                }

                sw.WriteLine("Xếp hạng: " + (i + 1));
                sw.WriteLine("Tên phim: " + p.TenPhim);
                sw.WriteLine("Doanh thu: " + p.DoanhThu + " VNĐ");
                sw.WriteLine("Vé bán ra: " + p.SoVeDaBan);
                sw.WriteLine("Vé tồn: " + veTon);
                sw.WriteLine("Tỉ lệ bán: " + Math.Round(tiLeBan, 2) + "%");
                sw.WriteLine("---------------------------------------");

                progressBar1.Value++;

                Application.DoEvents();
            }

            sw.Close();
            fs.Close();

            MessageBox.Show("Đã xuất thống kê thành công ra file output5.txt!");
            progressBar1.Value = 0;
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboPhong.Items.Clear();

            for (int i = 0; i < danhSachPhim.Count; i++)
            {
                if (danhSachPhim[i].TenPhim == cboPhim.Text)
                {
                    string[] cacPhong = danhSachPhim[i].DanhSachPhong.Split(',');
                    for (int j = 0; j < cacPhong.Length; j++)
                    {
                        cboPhong.Items.Add(cacPhong[j].Trim());
                    }
                    break;
                }
            }
            if (cboPhong.Items.Count > 0) cboPhong.SelectedIndex = 0;
        }
    }

    public class Phim
    {
        public string TenPhim { get; set; } = "";
        public int GiaVeChuan { get; set; }
        public string DanhSachPhong { get; set; } = "";
        public int SoVeDaBan { get; set; } = 0;
        public double DoanhThu { get; set; } = 0;
    }
}