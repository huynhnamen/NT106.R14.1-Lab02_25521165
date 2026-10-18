using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab02_Bai07 : Form
    {
        public Lab02_Bai07()
        {
            InitializeComponent();
            tvCayThuMuc.BeforeExpand += tvCayThuMuc_BeforeExpand;
            tvCayThuMuc.NodeMouseDoubleClick += tvCayThuMuc_NodeMouseDoubleClick;
            KhoiTaoDanhSachODia();
        }

        private void KhoiTaoDanhSachODia()
        {
            tvCayThuMuc.Nodes.Clear();
            DriveInfo[] danhSachODia = DriveInfo.GetDrives();

            for (int i = 0; i < danhSachODia.Length; i++)
            {
                if (danhSachODia[i].IsReady == true)
                {
                    string duongDanGoc = danhSachODia[i].Name;
                    TreeNode nodeODia = new TreeNode(duongDanGoc);
                    nodeODia.Tag = duongDanGoc;

                    TreeNode nodeGia = new TreeNode("...");
                    nodeGia.Tag = "DUMMY";
                    nodeODia.Nodes.Add(nodeGia);

                    tvCayThuMuc.Nodes.Add(nodeODia);
                }
            }
        }

        private void NapThuMucCon(TreeNode nodeCha)
        {
            if (nodeCha.Nodes.Count == 1 && nodeCha.Nodes[0].Tag?.ToString() == "DUMMY")
            {
                nodeCha.Nodes.Clear();
                string duongDanCha = nodeCha.Tag?.ToString() ?? "";

                if (duongDanCha == "" || Directory.Exists(duongDanCha) == false)
                {
                    return;
                }

                try
                {
                    string[] mangThuMuc = Directory.GetDirectories(duongDanCha);
                    for (int i = 0; i < mangThuMuc.Length; i++)
                    {
                        DirectoryInfo thongTinThuMuc = new DirectoryInfo(mangThuMuc[i]);
                        TreeNode nodeThuMuc = new TreeNode(thongTinThuMuc.Name);
                        nodeThuMuc.Tag = mangThuMuc[i];

                        TreeNode nodeGia = new TreeNode("...");
                        nodeGia.Tag = "DUMMY";
                        nodeThuMuc.Nodes.Add(nodeGia);

                        nodeCha.Nodes.Add(nodeThuMuc);
                    }

                    string[] mangTapTin = Directory.GetFiles(duongDanCha);
                    for (int i = 0; i < mangTapTin.Length; i++)
                    {
                        FileInfo thongTinFile = new FileInfo(mangTapTin[i]);
                        TreeNode nodeFile = new TreeNode(thongTinFile.Name);
                        nodeFile.Tag = mangTapTin[i];

                        nodeCha.Nodes.Add(nodeFile);
                    }
                }
                catch
                {
                }
            }
        }

        private void HienThiNoiDungFile(string duongDanFile)
        {
            if (File.Exists(duongDanFile) == false)
            {
                return;
            }

            string duoiFile = Path.GetExtension(duongDanFile).ToLower();

            if (duoiFile == ".jpg" || duoiFile == ".jpeg" || duoiFile == ".png" || duoiFile == ".bmp" || duoiFile == ".gif")
            {
                rtbNoiDung.Visible = false;
                picHinhAnh.Visible = true;

                try
                {
                    picHinhAnh.Image = Image.FromFile(duongDanFile);
                }
                catch
                {
                    picHinhAnh.Visible = false;
                    rtbNoiDung.Visible = true;
                    rtbNoiDung.Text = "Không thể đọc được file hình ảnh này!";
                }
            }
            else if (duoiFile == ".txt" || duoiFile == ".cs" || duoiFile == ".cpp" || duoiFile == ".h" ||
                     duoiFile == ".json" || duoiFile == ".xml" || duoiFile == ".html" || duoiFile == ".sql" || duoiFile == ".log")
            {
                picHinhAnh.Visible = false;
                rtbNoiDung.Visible = true;

                try
                {
                    FileStream fs = new FileStream(duongDanFile, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    rtbNoiDung.Text = sr.ReadToEnd();
                    sr.Close();
                    fs.Close();
                }
                catch
                {
                    rtbNoiDung.Text = "Không thể mở file văn bản này!";
                }
            }
            else
            {
                picHinhAnh.Visible = false;
                rtbNoiDung.Visible = true;
                rtbNoiDung.Text = "Không hỗ trợ xem trước định dạng file (" + duoiFile + ")!";
            }
        }

        private void tvCayThuMuc_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            if (e.Node != null)
            {
                NapThuMucCon(e.Node);
            }
        }

        private void tvCayThuMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;

            string duongDan = e.Node.Tag?.ToString() ?? "";
            if (File.Exists(duongDan) == true)
            {
                HienThiNoiDungFile(duongDan);
            }
        }

        private void tvCayThuMuc_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null) return;

            string duongDan = e.Node.Tag?.ToString() ?? "";
            if (Directory.Exists(duongDan) == true)
            {
                NapThuMucCon(e.Node);
                e.Node.Expand();
            }
            else if (File.Exists(duongDan) == true)
            {
                HienThiNoiDungFile(duongDan);
            }
        }
    }
}