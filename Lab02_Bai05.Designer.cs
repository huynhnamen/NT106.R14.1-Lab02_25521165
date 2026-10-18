namespace WinFormsApp1
{
    partial class Lab02_Bai05
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
            cboPhim = new ComboBox();
            btnLoadDuLieu = new Button();
            cboPhong = new ComboBox();
            clbGhe = new CheckedListBox();
            txtHoTen = new TextBox();
            btnDatVe = new Button();
            rtbHoaDon = new RichTextBox();
            btnXuatThongKe = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.Font = new Font("Segoe UI", 11F);
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(210, 162);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(423, 38);
            cboPhim.TabIndex = 0;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;
            // 
            // btnLoadDuLieu
            // 
            btnLoadDuLieu.Font = new Font("Segoe UI", 11F);
            btnLoadDuLieu.Location = new Point(12, 12);
            btnLoadDuLieu.Name = "btnLoadDuLieu";
            btnLoadDuLieu.Size = new Size(621, 61);
            btnLoadDuLieu.TabIndex = 1;
            btnLoadDuLieu.Text = "1. Nạp dữ liệu Phim";
            btnLoadDuLieu.UseVisualStyleBackColor = true;
            btnLoadDuLieu.Click += btnLoadDuLieu_Click;
            // 
            // cboPhong
            // 
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.Font = new Font("Segoe UI", 11F);
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(210, 234);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(423, 38);
            cboPhong.TabIndex = 2;
            // 
            // clbGhe
            // 
            clbGhe.CheckOnClick = true;
            clbGhe.ColumnWidth = 169;
            clbGhe.Font = new Font("Segoe UI", 17F);
            clbGhe.FormattingEnabled = true;
            clbGhe.Location = new Point(12, 308);
            clbGhe.MultiColumn = true;
            clbGhe.Name = "clbGhe";
            clbGhe.Size = new Size(621, 268);
            clbGhe.TabIndex = 3;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 11F);
            txtHoTen.Location = new Point(210, 99);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(423, 37);
            txtHoTen.TabIndex = 4;
            // 
            // btnDatVe
            // 
            btnDatVe.Font = new Font("Segoe UI", 11F);
            btnDatVe.Location = new Point(913, 510);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(151, 61);
            btnDatVe.TabIndex = 5;
            btnDatVe.Text = "2. Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // rtbHoaDon
            // 
            rtbHoaDon.Font = new Font("Segoe UI", 11F);
            rtbHoaDon.Location = new Point(732, 12);
            rtbHoaDon.Name = "rtbHoaDon";
            rtbHoaDon.ReadOnly = true;
            rtbHoaDon.Size = new Size(515, 470);
            rtbHoaDon.TabIndex = 6;
            rtbHoaDon.Text = "";
            // 
            // btnXuatThongKe
            // 
            btnXuatThongKe.Font = new Font("Segoe UI", 11F);
            btnXuatThongKe.Location = new Point(806, 577);
            btnXuatThongKe.Name = "btnXuatThongKe";
            btnXuatThongKe.Size = new Size(356, 61);
            btnXuatThongKe.TabIndex = 7;
            btnXuatThongKe.Text = "3. Xuất Thống Kê (output5.txt)";
            btnXuatThongKe.UseVisualStyleBackColor = true;
            btnXuatThongKe.Click += btnXuatThongKe_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(768, 644);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(436, 46);
            progressBar1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(158, 41);
            label1.TabIndex = 9;
            label1.Text = "Họ Và Tên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 156);
            label2.Name = "label2";
            label2.Size = new Size(172, 41);
            label2.TabIndex = 10;
            label2.Text = "Chọn phim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 228);
            label3.Name = "label3";
            label3.Size = new Size(192, 41);
            label3.TabIndex = 11;
            label3.Text = "Chọn phòng:";
            // 
            // Lab02_Bai05
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 731);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btnXuatThongKe);
            Controls.Add(rtbHoaDon);
            Controls.Add(btnDatVe);
            Controls.Add(txtHoTen);
            Controls.Add(clbGhe);
            Controls.Add(cboPhong);
            Controls.Add(btnLoadDuLieu);
            Controls.Add(cboPhim);
            Name = "Lab02_Bai05";
            Text = "Bài 05 - Quản lý phòng vé";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboPhim;
        private Button btnLoadDuLieu;
        private ComboBox cboPhong;
        private CheckedListBox clbGhe;
        private TextBox txtHoTen;
        private Button btnDatVe;
        private RichTextBox rtbHoaDon;
        private Button btnXuatThongKe;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}