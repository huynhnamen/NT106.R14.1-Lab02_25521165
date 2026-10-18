namespace WinFormsApp1
{
    partial class Lab02_Bai06
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
            btnThoat = new Button();
            btnXoa = new Button();
            btnTim = new Button();
            btnThem = new Button();
            txtKetQua = new TextBox();
            txtDanhSach = new TextBox();
            txtMonAn = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnTaiAnh = new Button();
            txtNguoiDongGop = new TextBox();
            label3 = new Label();
            picMonAn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 22F);
            btnThoat.Location = new Point(195, 593);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(300, 101);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 11F);
            btnXoa.Location = new Point(17, 482);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(194, 59);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Segoe UI", 11F);
            btnTim.Location = new Point(17, 417);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(194, 59);
            btnTim.TabIndex = 15;
            btnTim.Text = "Tìm món ăn";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 11F);
            btnThem.Location = new Point(17, 144);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(194, 59);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtKetQua
            // 
            txtKetQua.Font = new Font("Segoe UI", 15F);
            txtKetQua.Location = new Point(746, 636);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(470, 47);
            txtKetQua.TabIndex = 13;
            txtKetQua.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDanhSach
            // 
            txtDanhSach.Font = new Font("Segoe UI", 11F);
            txtDanhSach.Location = new Point(224, 144);
            txtDanhSach.Multiline = true;
            txtDanhSach.Name = "txtDanhSach";
            txtDanhSach.ReadOnly = true;
            txtDanhSach.ScrollBars = ScrollBars.Vertical;
            txtDanhSach.Size = new Size(448, 397);
            txtDanhSach.TabIndex = 12;
            // 
            // txtMonAn
            // 
            txtMonAn.Font = new Font("Segoe UI", 15F);
            txtMonAn.Location = new Point(267, 12);
            txtMonAn.Name = "txtMonAn";
            txtMonAn.Size = new Size(405, 47);
            txtMonAn.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(812, 576);
            label2.Name = "label2";
            label2.Size = new Size(321, 41);
            label2.TabIndex = 10;
            label2.Text = "Món ăn hôm nay ăn là:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(206, 41);
            label1.TabIndex = 9;
            label1.Text = "Nhập món ăn:";
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Font = new Font("Segoe UI", 11F);
            btnTaiAnh.Location = new Point(17, 209);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(194, 59);
            btnTaiAnh.TabIndex = 18;
            btnTaiAnh.Text = "Tải hình ảnh...";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // txtNguoiDongGop
            // 
            txtNguoiDongGop.Font = new Font("Segoe UI", 15F);
            txtNguoiDongGop.Location = new Point(267, 76);
            txtNguoiDongGop.Name = "txtNguoiDongGop";
            txtNguoiDongGop.Size = new Size(405, 47);
            txtNguoiDongGop.TabIndex = 19;
            txtNguoiDongGop.TextChanged += txtNguoiDongGop_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(249, 41);
            label3.TabIndex = 20;
            label3.Text = "Người đóng góp:";
            // 
            // picMonAn
            // 
            picMonAn.BorderStyle = BorderStyle.FixedSingle;
            picMonAn.Location = new Point(686, 12);
            picMonAn.Name = "picMonAn";
            picMonAn.Size = new Size(601, 529);
            picMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
            picMonAn.TabIndex = 21;
            picMonAn.TabStop = false;
            // 
            // Lab02_Bai06
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 730);
            Controls.Add(picMonAn);
            Controls.Add(label3);
            Controls.Add(txtNguoiDongGop);
            Controls.Add(btnTaiAnh);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnTim);
            Controls.Add(btnThem);
            Controls.Add(txtKetQua);
            Controls.Add(txtDanhSach);
            Controls.Add(txtMonAn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Lab02_Bai06";
            Text = "Bài 06 - Hôm nay ăn gì (SQLite)";
            ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThoat;
        private Button btnXoa;
        private Button btnTim;
        private Button btnThem;
        private TextBox txtKetQua;
        private TextBox txtDanhSach;
        private TextBox txtMonAn;
        private Label label2;
        private Label label1;
        private Button btnTaiAnh;
        private TextBox txtNguoiDongGop;
        private Label label3;
        private PictureBox picMonAn;
    }
}