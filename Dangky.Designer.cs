
namespace WindowsFormsApp1
{
    partial class Dangky
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDangky = new System.Windows.Forms.Button();
            this.texttentaikhoan = new System.Windows.Forms.TextBox();
            this.textmatkhau = new System.Windows.Forms.TextBox();
            this.textxacnhanmk = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(17, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên tài khoản:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(17, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(17, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận mật khẩu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(17, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonDangky
            // 
            this.buttonDangky.BackColor = System.Drawing.Color.Blue;
            this.buttonDangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDangky.ForeColor = System.Drawing.Color.White;
            this.buttonDangky.Location = new System.Drawing.Point(187, 510);
            this.buttonDangky.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDangky.Name = "buttonDangky";
            this.buttonDangky.Size = new System.Drawing.Size(221, 45);
            this.buttonDangky.TabIndex = 6;
            this.buttonDangky.Text = "Đăng ký";
            this.buttonDangky.UseVisualStyleBackColor = false;
            this.buttonDangky.Click += new System.EventHandler(this.buttonDangky_Click);
            // 
            // texttentaikhoan
            // 
            this.texttentaikhoan.Location = new System.Drawing.Point(239, 265);
            this.texttentaikhoan.Multiline = true;
            this.texttentaikhoan.Name = "texttentaikhoan";
            this.texttentaikhoan.Size = new System.Drawing.Size(297, 39);
            this.texttentaikhoan.TabIndex = 7;
            // 
            // textmatkhau
            // 
            this.textmatkhau.Location = new System.Drawing.Point(239, 318);
            this.textmatkhau.Multiline = true;
            this.textmatkhau.Name = "textmatkhau";
            this.textmatkhau.Size = new System.Drawing.Size(297, 39);
            this.textmatkhau.TabIndex = 7;
            // 
            // textxacnhanmk
            // 
            this.textxacnhanmk.Location = new System.Drawing.Point(239, 371);
            this.textxacnhanmk.Multiline = true;
            this.textxacnhanmk.Name = "textxacnhanmk";
            this.textxacnhanmk.Size = new System.Drawing.Size(297, 39);
            this.textxacnhanmk.TabIndex = 7;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(239, 424);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(297, 39);
            this.textemail.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logoneu;
            this.pictureBox1.Location = new System.Drawing.Point(67, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 601);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textxacnhanmk);
            this.Controls.Add(this.textmatkhau);
            this.Controls.Add(this.texttentaikhoan);
            this.Controls.Add(this.buttonDangky);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dangky";
            this.Text = "Dangky";
            this.Load += new System.EventHandler(this.Dangky_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDangky;
        private System.Windows.Forms.TextBox texttentaikhoan;
        private System.Windows.Forms.TextBox textmatkhau;
        private System.Windows.Forms.TextBox textxacnhanmk;
        private System.Windows.Forms.TextBox textemail;
    }
}