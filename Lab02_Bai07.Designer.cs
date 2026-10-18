namespace WinFormsApp1
{
    partial class Lab02_Bai07
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tvCayThuMuc = new TreeView();
            rtbNoiDung = new RichTextBox();
            picHinhAnh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // tvCayThuMuc
            // 
            tvCayThuMuc.Location = new Point(12, 12);
            tvCayThuMuc.Name = "tvCayThuMuc";
            tvCayThuMuc.Size = new Size(432, 657);
            tvCayThuMuc.TabIndex = 0;
            tvCayThuMuc.AfterSelect += tvCayThuMuc_AfterSelect;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Location = new Point(636, 12);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(611, 657);
            rtbNoiDung.TabIndex = 1;
            rtbNoiDung.Text = "";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(450, 12);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(797, 657);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 2;
            picHinhAnh.TabStop = false;
            picHinhAnh.Visible = false;
            // 
            // Lab02_Bai07
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 681);
            Controls.Add(picHinhAnh);
            Controls.Add(rtbNoiDung);
            Controls.Add(tvCayThuMuc);
            Name = "Lab02_Bai07";
            Text = "Bài 07 - Duyệt thư mục và tập tin";
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvCayThuMuc;
        private RichTextBox rtbNoiDung;
        private PictureBox picHinhAnh;
    }
}