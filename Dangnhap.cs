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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void linkLabelquenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quenmatkhau f = new Quenmatkhau();
            f.Show();
        }

        private void linkLabeldangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dangky f = new Dangky();
            f.Show();
        }
        Modify modify = new Modify();
        private void button3_Click(object sender, EventArgs e)
        {
            string tentaikhoan = texttentaikhoan.Text;
            string matkhau = textmatkhau.Text;
            if (tentaikhoan.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
           else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "select * from Taikhoan where TenTaiKhoan = '"+tentaikhoan+"' and MatKhau = '"+matkhau+"' ";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Mainchinh mainchinh = new Mainchinh();
                    mainchinh.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản không chính xác!");
                }
            }
        }
        }
    }
