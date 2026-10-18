namespace WinFormsApp1
{
    partial class Lab02_Bai01
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
            btnRead = new Button();
            btnWrite = new Button();
            rtbContent = new RichTextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 36F);
            btnRead.Location = new Point(113, 118);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(378, 148);
            btnRead.TabIndex = 0;
            btnRead.Text = "ĐỌC FILE";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 36F);
            btnWrite.Location = new Point(113, 387);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(378, 148);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "GHI FILE";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // rtbContent
            // 
            rtbContent.Font = new Font("Segoe UI", 11F);
            rtbContent.Location = new Point(658, 30);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(565, 629);
            rtbContent.TabIndex = 2;
            rtbContent.Text = "";
            // 
            // Lab02_Bai01
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 683);
            Controls.Add(rtbContent);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Lab02_Bai01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 01 - Ghi và Đọc file";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private RichTextBox rtbContent;
    }
}