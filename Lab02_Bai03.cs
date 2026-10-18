using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void btnNapFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog moFile = new OpenFileDialog();
            moFile.Title = "Chọn file chứa biểu thức (vd: input3.txt)";
            moFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (moFile.ShowDialog() == DialogResult.OK)
            {
                string duongDanInput = moFile.FileName;

                string duongDanOutput = duongDanInput.Replace("input", "output");
                if (duongDanOutput == duongDanInput)
                {
                    duongDanOutput = duongDanInput + "_output.txt";
                }

                rtbKetQua.Text = "";

                FileStream fsIn = new FileStream(duongDanInput, FileMode.Open);
                StreamReader sr = new StreamReader(fsIn);

                FileStream fsOut = new FileStream(duongDanOutput, FileMode.Create);
                StreamWriter sw = new StreamWriter(fsOut);

                string? dongBieuThuc;

                while ((dongBieuThuc = sr.ReadLine()) != null)
                {
                    if (dongBieuThuc.Trim() == "")
                    {
                        continue;
                    }

                    string bieuThucChuan = ChuanHoaBieuThuc(dongBieuThuc);

                    double ketQuaToanHoc = TinhBieuThuc(bieuThucChuan);

                    string dongKetQua = bieuThucChuan + " = " + ketQuaToanHoc.ToString();

                    sw.WriteLine(dongKetQua);

                    rtbKetQua.Text = rtbKetQua.Text + dongKetQua + "\r\n";
                }

                sr.Close();
                fsIn.Close();
                sw.Close();
                fsOut.Close();
            }
        }

        private string ChuanHoaBieuThuc(string bieuThuc)
        {
            string tam = "";

            for (int i = 0; i < bieuThuc.Length; i++)
            {
                char c = bieuThuc[i];
                if (c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')')
                {
                    tam = tam + " " + c + " ";
                }
                else
                {
                    tam = tam + c;
                }
            }

            string[] cacPhanTu = tam.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries);

            string ketQua = string.Join(" ", cacPhanTu);

            ketQua = ketQua.Replace("( ", "(").Replace(" )", ")");

            return ketQua;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double TinhBieuThuc(string bieuThuc)
        {
            Stack<double> stackSo = new Stack<double>();
            Stack<char> stackToanTu = new Stack<char>();

            for (int i = 0; i < bieuThuc.Length; i++)
            {
                char c = bieuThuc[i];

                if (c == ' ') continue;

                if (c == '(')
                {
                    stackToanTu.Push(c);
                }
                else if ((c >= '0' && c <= '9') || c == '.')
                {
                    string chuoiSo = "";
                    while (i < bieuThuc.Length && ((bieuThuc[i] >= '0' && bieuThuc[i] <= '9') || bieuThuc[i] == '.'))
                    {
                        chuoiSo = chuoiSo + bieuThuc[i];
                        i++;
                    }
                    i--;

                    double so = double.Parse(chuoiSo);
                    stackSo.Push(so);
                }
                else if (c == ')')
                {
                    while (stackToanTu.Count > 0 && stackToanTu.Peek() != '(')
                    {
                        double so2 = stackSo.Pop();
                        double so1 = stackSo.Pop();
                        char toanTu = stackToanTu.Pop();

                        double kq = ThucHienPhepTinh(so1, so2, toanTu);
                        stackSo.Push(kq);
                    }
                    stackToanTu.Pop();
                }
                else if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    while (stackToanTu.Count > 0 && LayDoUuTien(stackToanTu.Peek()) >= LayDoUuTien(c))
                    {
                        double so2 = stackSo.Pop();
                        double so1 = stackSo.Pop();
                        char toanTu = stackToanTu.Pop();

                        double kq = ThucHienPhepTinh(so1, so2, toanTu);
                        stackSo.Push(kq);
                    }
                    stackToanTu.Push(c);
                }
            }

            while (stackToanTu.Count > 0)
            {
                double so2 = stackSo.Pop();
                double so1 = stackSo.Pop();
                char toanTu = stackToanTu.Pop();

                double kq = ThucHienPhepTinh(so1, so2, toanTu);
                stackSo.Push(kq);
            }

            if (stackSo.Count > 0)
            {
                return stackSo.Pop();
            }
            return 0;
        }

        private int LayDoUuTien(char toanTu)
        {
            if (toanTu == '*' || toanTu == '/') return 2;
            if (toanTu == '+' || toanTu == '-') return 1;
            return 0;
        }

        private double ThucHienPhepTinh(double a, double b, char toanTu)
        {
            if (toanTu == '+') return a + b;
            if (toanTu == '-') return a - b;
            if (toanTu == '*') return a * b;
            if (toanTu == '/') return a / b;
            return 0;
        }
    }
}