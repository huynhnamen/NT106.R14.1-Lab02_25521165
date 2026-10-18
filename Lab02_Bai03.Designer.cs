namespace WinFormsApp1
{
    partial class Lab02_Bai03
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
            btnNapFile = new Button();
            rtbKetQua = new RichTextBox();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // btnNapFile
            // 
            btnNapFile.Font = new Font("Segoe UI", 22F);
            btnNapFile.Location = new Point(45, 576);
            btnNapFile.Name = "btnNapFile";
            btnNapFile.Size = new Size(376, 100);
            btnNapFile.TabIndex = 0;
            btnNapFile.Text = "Nạp File Input";
            btnNapFile.UseVisualStyleBackColor = true;
            btnNapFile.Click += btnNapFile_Click;
            // 
            // rtbKetQua
            // 
            rtbKetQua.Font = new Font("Segoe UI", 12F);
            rtbKetQua.Location = new Point(12, 12);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.ReadOnly = true;
            rtbKetQua.Size = new Size(1231, 539);
            rtbKetQua.TabIndex = 1;
            rtbKetQua.Text = "";
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 22F);
            btnThoat.Location = new Point(837, 576);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(376, 100);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 717);
            Controls.Add(btnThoat);
            Controls.Add(rtbKetQua);
            Controls.Add(btnNapFile);
            Name = "Lab02_Bai03";
            Text = "Bài 03 - Đọc, Ghi và Tính toán biểu thức";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNapFile;
        private RichTextBox rtbKetQua;
        private Button btnThoat;
    }
}