namespace WinFormsApp1
{
    partial class Lab02_Bai02
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
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            txtURL = new TextBox();
            txtLineCount = new TextBox();
            txtWordCount = new TextBox();
            txtCharCount = new TextBox();
            rtbContent = new RichTextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 17F);
            btnRead.Location = new Point(58, 33);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(611, 70);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read from File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 17F);
            btnExit.Location = new Point(58, 625);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(611, 70);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 154);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 2;
            label1.Text = "File name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 235);
            label2.Name = "label2";
            label2.Size = new Size(78, 41);
            label2.TabIndex = 3;
            label2.Text = "Size:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 306);
            label3.Name = "label3";
            label3.Size = new Size(78, 41);
            label3.TabIndex = 4;
            label3.Text = "URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 383);
            label4.Name = "label4";
            label4.Size = new Size(163, 41);
            label4.TabIndex = 5;
            label4.Text = "Line count:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(12, 456);
            label5.Name = "label5";
            label5.Size = new Size(195, 41);
            label5.TabIndex = 6;
            label5.Text = "Words count:";
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 17F);
            txtFileName.Location = new Point(264, 147);
            txtFileName.Name = "txtFileName";
            txtFileName.ReadOnly = true;
            txtFileName.Size = new Size(435, 53);
            txtFileName.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Font = new Font("Segoe UI", 17F);
            txtSize.Location = new Point(264, 223);
            txtSize.Name = "txtSize";
            txtSize.ReadOnly = true;
            txtSize.Size = new Size(435, 53);
            txtSize.TabIndex = 8;
            // 
            // txtURL
            // 
            txtURL.Font = new Font("Segoe UI", 17F);
            txtURL.Location = new Point(264, 299);
            txtURL.Name = "txtURL";
            txtURL.ReadOnly = true;
            txtURL.Size = new Size(435, 53);
            txtURL.TabIndex = 9;
            // 
            // txtLineCount
            // 
            txtLineCount.Font = new Font("Segoe UI", 17F);
            txtLineCount.Location = new Point(264, 376);
            txtLineCount.Name = "txtLineCount";
            txtLineCount.ReadOnly = true;
            txtLineCount.Size = new Size(435, 53);
            txtLineCount.TabIndex = 10;
            // 
            // txtWordCount
            // 
            txtWordCount.Font = new Font("Segoe UI", 17F);
            txtWordCount.Location = new Point(264, 449);
            txtWordCount.Name = "txtWordCount";
            txtWordCount.ReadOnly = true;
            txtWordCount.Size = new Size(435, 53);
            txtWordCount.TabIndex = 11;
            // 
            // txtCharCount
            // 
            txtCharCount.Font = new Font("Segoe UI", 17F);
            txtCharCount.Location = new Point(264, 529);
            txtCharCount.Name = "txtCharCount";
            txtCharCount.ReadOnly = true;
            txtCharCount.Size = new Size(435, 53);
            txtCharCount.TabIndex = 12;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(744, 12);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(544, 706);
            rtbContent.TabIndex = 13;
            rtbContent.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(12, 536);
            label6.Name = "label6";
            label6.Size = new Size(235, 41);
            label6.TabIndex = 14;
            label6.Text = "Character count:";
            // 
            // Lab02_Bai02
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 730);
            Controls.Add(label6);
            Controls.Add(rtbContent);
            Controls.Add(txtCharCount);
            Controls.Add(txtWordCount);
            Controls.Add(txtLineCount);
            Controls.Add(txtURL);
            Controls.Add(txtSize);
            Controls.Add(txtFileName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnRead);
            Name = "Lab02_Bai02";
            Text = "Bài 02 - Đọc thông tin file";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFileName;
        private TextBox txtSize;
        private TextBox txtURL;
        private TextBox txtLineCount;
        private TextBox txtWordCount;
        private TextBox txtCharCount;
        private RichTextBox rtbContent;
        private Label label6;
    }
}