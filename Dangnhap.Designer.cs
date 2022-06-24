
namespace WindowsFormsApp1
{
    partial class Dangnhap
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
            this.linkLabelquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.linkLabeldangky = new System.Windows.Forms.LinkLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.texttentaikhoan = new System.Windows.Forms.TextBox();
            this.textmatkhau = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelquenmatkhau
            // 
            this.linkLabelquenmatkhau.AutoSize = true;
            this.linkLabelquenmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelquenmatkhau.Location = new System.Drawing.Point(62, 354);
            this.linkLabelquenmatkhau.Name = "linkLabelquenmatkhau";
            this.linkLabelquenmatkhau.Size = new System.Drawing.Size(122, 20);
            this.linkLabelquenmatkhau.TabIndex = 3;
            this.linkLabelquenmatkhau.TabStop = true;
            this.linkLabelquenmatkhau.Text = "Quên mật khẩu";
            this.linkLabelquenmatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelquenmatkhau_LinkClicked);
            // 
            // linkLabeldangky
            // 
            this.linkLabeldangky.AutoSize = true;
            this.linkLabeldangky.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabeldangky.Location = new System.Drawing.Point(309, 354);
            this.linkLabeldangky.Name = "linkLabeldangky";
            this.linkLabeldangky.Size = new System.Drawing.Size(69, 20);
            this.linkLabeldangky.TabIndex = 4;
            this.linkLabeldangky.TabStop = true;
            this.linkLabeldangky.Text = "Đăng ký";
            this.linkLabeldangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabeldangky_LinkClicked);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(132, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Đăng nhập";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // texttentaikhoan
            // 
            this.texttentaikhoan.Location = new System.Drawing.Point(132, 227);
            this.texttentaikhoan.Multiline = true;
            this.texttentaikhoan.Name = "texttentaikhoan";
            this.texttentaikhoan.Size = new System.Drawing.Size(250, 40);
            this.texttentaikhoan.TabIndex = 6;
            // 
            // textmatkhau
            // 
            this.textmatkhau.Location = new System.Drawing.Point(132, 286);
            this.textmatkhau.Multiline = true;
            this.textmatkhau.Name = "textmatkhau";
            this.textmatkhau.PasswordChar = '*';
            this.textmatkhau.Size = new System.Drawing.Size(250, 40);
            this.textmatkhau.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.analysis;
            this.pictureBox3.Location = new System.Drawing.Point(62, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(62, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logoneu;
            this.pictureBox1.Location = new System.Drawing.Point(77, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 531);
            this.Controls.Add(this.textmatkhau);
            this.Controls.Add(this.texttentaikhoan);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.linkLabeldangky);
            this.Controls.Add(this.linkLabelquenmatkhau);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dangnhap";
            this.Text = "Dangnhap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabelquenmatkhau;
        private System.Windows.Forms.LinkLabel linkLabeldangky;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox texttentaikhoan;
        private System.Windows.Forms.TextBox textmatkhau;
    }
}