using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class FormDangNhap : Form
    {
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private readonly NguoiDungNhomNguoiDungBLL _nguoiDungNhomNguoiDungBLL = new NguoiDungNhomNguoiDungBLL();
        public FormDangNhap()
        {
            InitializeComponent();
            this.Load += FormDangNhap_Load;
            this.buttonDangNhap.Click += ButtonDangNhap_Click;
            this.textBoxTenDangNhap.KeyPress += TextBoxTenDangNhap_KeyPress;
            this.textBoxMatKhau.KeyPress += TextBoxMatKhau_KeyPress;
        }

        private void TextBoxMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void TextBoxTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void ButtonDangNhap_Click(object sender, EventArgs e)
        {
            if (!IsInputValid(textBoxTenDangNhap.Text, textBoxMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.");
                return;
            }

            //Tiếp tục kiểm tra valid textbox
            //Không cho nhập khoảng trắng (oke)
            //Kiểm tra độ dài phù hợp

            string username = textBoxTenDangNhap.Text;
            string password = textBoxMatKhau.Text;

            if (!_nguoiDungBLL.DangNhap(username, password))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.");
                return;
            }

            MessageBox.Show("Đăng nhập thành công.");
            DangNhapHeThong(username);
        }

        private void DangNhapHeThong(string username)
        {
            NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung = _nguoiDungNhomNguoiDungBLL.GetNhomCuaNguoiDung(username);

            Properties.Settings.Default.maNhom = nguoiDungNhomNguoiDung.MaNhomNguoiDung.ToString();
            Properties.Settings.Default.tenDangNhap = nguoiDungNhomNguoiDung.TenDangNhap;
            LoadFormMain();
        }

        private void LoadFormMain()
        {
            Form1 formMain = new Form1();
            formMain.Show();
            Hide();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private bool IsInputValid(string username, string password)
        {
            return !string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password);
        }
    }
}
