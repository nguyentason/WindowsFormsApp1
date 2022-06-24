
namespace WindowsFormsApp1
{
    partial class Quenmatkhau
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelketqua = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.logoneu;
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelketqua
            // 
            this.labelketqua.AutoSize = true;
            this.labelketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelketqua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelketqua.Location = new System.Drawing.Point(38, 328);
            this.labelketqua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelketqua.Name = "labelketqua";
            this.labelketqua.Size = new System.Drawing.Size(79, 20);
            this.labelketqua.TabIndex = 8;
            this.labelketqua.Text = "Kết quả:";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelemail.Location = new System.Drawing.Point(38, 265);
            this.labelemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(132, 20);
            this.labelemail.TabIndex = 8;
            this.labelemail.Text = "Email đăng ký:";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(189, 256);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(240, 39);
            this.textemail.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(143, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Lấy lại mật khẩu";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 466);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelketqua);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Quenmatkhau";
            this.Text = "Quenmatkhau";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelketqua;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Button button3;
    }
}