using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Quenmatkhau : Form
    {
        public Quenmatkhau()
        {
            InitializeComponent();
            labelketqua.Text = "";
        }
        Modify modify = new Modify();
        private void button3_Click(object sender, EventArgs e)
        {
            string email = textemail.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng ký"); }
            else
            {
                string query = " select * from Taikhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count !=0)
                {
                    labelketqua.ForeColor = Color.Blue;
                    labelketqua.Text = "Mật khẩu:" + modify.TaiKhoans(query)[0].MatKhau;

                }
                else
                {
                    labelketqua.ForeColor = Color.Red;
                    labelketqua.Text = "Email này chưa được đăng ký!";
                }
            }
        }
    }
}
