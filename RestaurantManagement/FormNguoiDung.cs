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
    public partial class FormNguoiDung : Form
    {
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();

        public FormNguoiDung()
        {
            InitializeComponent();
            this.Load += FormNguoiDung_Load;
            this.Click += FormNguoiDung_Click;
            this.dataGridViewNguoiDung.CellClick += DataGridViewNguoiDung_CellClick;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
            this.buttonSua.Click += ButtonSua_Click;
            this.buttonHuy.Click += ButtonHuy_Click;
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void FormNguoiDung_Click(object sender, EventArgs e)
        {
            dataGridViewNguoiDung.ClearSelection();
            ClearInput();
        }

        private void DataGridViewNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNguoiDung.Rows.Count == 0 || !dataGridViewNguoiDung.CurrentRow.Selected)
            {
                return;
            }

            textBoxTenDangNhap.Text = dataGridViewNguoiDung.CurrentRow.Cells[0].Value.ToString();
            checkBoxHoatDong.Checked = Convert.ToBoolean(dataGridViewNguoiDung.CurrentRow.Cells[2].Value);
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa.");
                return;
            }

            if (!IsInputValid(textBoxTenDangNhap.Text, textBoxMatKhau.Text, textBoxXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!IsPasswordValid(textBoxMatKhau.Text, textBoxXacNhan.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            NguoiDung nguoiDung = new NguoiDung();
            nguoiDung.TenDangNhap = textBoxTenDangNhap.Text;
            nguoiDung.MatKhau = textBoxMatKhau.Text;
            nguoiDung.HoatDong = checkBoxHoatDong.Checked;

            if (!_nguoiDungBLL.DoiMatKhau(nguoiDung))
            {
                MessageBox.Show("Đổi mật khẩu thất bại.");
                return;
            }

            MessageBox.Show("Đổi mật khẩu thành công.");
            FinishedAction();
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa.");
                return;
            }

            string tenDangNhap = textBoxTenDangNhap.Text;

            if (!_nguoiDungBLL.Delete(tenDangNhap))
            {
                MessageBox.Show("Xóa người dùng thất bại.");
                return;
            }

            MessageBox.Show("Xóa người dùng thành công.");
            FinishedAction();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            if (!IsInputValid(textBoxTenDangNhap.Text, textBoxMatKhau.Text, textBoxXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!IsPasswordValid(textBoxMatKhau.Text, textBoxXacNhan.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.");
                return;
            }

            NguoiDung nguoiDung= new NguoiDung();
            nguoiDung.TenDangNhap = textBoxTenDangNhap.Text;
            nguoiDung.MatKhau = textBoxMatKhau.Text;
            nguoiDung.HoatDong = checkBoxHoatDong.Checked;

            if (!_nguoiDungBLL.Create(nguoiDung))
            {
                MessageBox.Show("Thêm người dùng thất bại.");
                return;
            }

            MessageBox.Show("Thêm người dùng thành công.");
            FinishedAction();
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataNguoiDung();
        }

        private void LoadDataNguoiDung()
        {
            List<NguoiDung> nguoiDungs = _nguoiDungBLL.ReadNguoiDungs().ToList();

            dataGridViewNguoiDung.DataSource = nguoiDungs;
        }

        private void ClearInput()
        {
            foreach (Control control in groupBoxNguoiDung.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = string.Empty;
                }
                else if (control.GetType() == typeof(CheckBox))
                {
                    (control as CheckBox).Checked = false;
                }
            }
        }

        private bool IsInputValid(string firstField, string secondField, string thirdField)
        {
            return !string.IsNullOrWhiteSpace(firstField) && !string.IsNullOrWhiteSpace(secondField) && !string.IsNullOrWhiteSpace(thirdField);
        }

        private void FinishedAction()
        {
            ClearInput();
            LoadDataNguoiDung();
        }

        private bool IsPasswordValid(string password, string confirmPassword)
        {
            return password.Equals(confirmPassword);
        }
    }
}
