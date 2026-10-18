using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input1.txt"))
            {
                MessageBox.Show("Không tìm thấy file input1.txt!");
                return;
            }

            FileStream fs = new FileStream("input1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            rtbContent.Text = content;

            sr.Close();
            fs.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (rtbContent.Text == "")
            {
                MessageBox.Show("Chưa có dữ liệu để ghi! Hãy đọc file trước.");
                return;
            }

            FileStream fs = new FileStream("output1.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            string upperContent = rtbContent.Text.ToUpper();
            sw.Write(upperContent);

            sw.Close();
            fs.Close();

            MessageBox.Show("Đã ghi dữ liệu in hoa ra file output1.txt!");
        }
    }
}
