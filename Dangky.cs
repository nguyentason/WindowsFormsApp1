using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool checkAccount(string ac)//check mat khau va ten tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-z0-9]{6,24}$");
        }
        public bool checkEmail(string em)//check email
        {
            return Regex.IsMatch(em, "^[a-zA-z0-9]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void buttonDangky_Click(object sender, EventArgs e)
        {
            string tentaikhoan = texttentaikhoan.Text;
            string matkhau = textmatkhau.Text;
            string xacnhanmk = textxacnhanmk.Text;
            string email = textemail.Text;
            if (!checkAccount(tentaikhoan)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập tên mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (xacnhanmk != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email"); return; }
            if (modify.TaiKhoans("Select * from Taikhoan where Email = '" + email + "' ").Count != 0) { MessageBox.Show(" Email này đã được đăng ký, vui lòng đăng ký email khác!"); return; }
            try
            {
                string query = "Insert into Taikhoan values('"+tentaikhoan+"','"+matkhau+"','"+email+"')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information )==DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
            }
        }
    }
}
