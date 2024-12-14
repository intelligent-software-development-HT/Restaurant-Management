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
    public partial class FormNhomNguoiDung : Form
    {
        private readonly NhomNguoiDungBLL _nhomNguoiDungBLL = new NhomNguoiDungBLL();
        public FormNhomNguoiDung()
        {
            InitializeComponent();
            this.Click += FormNhomNguoiDung_Click;
            this.Load += FormNhomNguoiDung_Load;
            this.dataGridViewNhomNguoiDung.CellClick += DataGridViewNhomNguoiDung_CellClick;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
            this.buttonSua.Click += ButtonSua_Click;
        }

        private void FormNhomNguoiDung_Click(object sender, EventArgs e)
        {
            dataGridViewNhomNguoiDung.ClearSelection();
            ClearInput();
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaNhom.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm người dùng cần xóa.");
                return;
            }

            if (!IsInputValid(textBoxTenNhom.Text, richTextBoxGhiChu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            NhomNguoiDung nhomNguoiDung = new NhomNguoiDung();
            nhomNguoiDung.MaNhom = Convert.ToInt32(textBoxMaNhom.Text);
            nhomNguoiDung.TenNhom = textBoxTenNhom.Text;
            nhomNguoiDung.GhiChu = richTextBoxGhiChu.Text;

            if (!_nhomNguoiDungBLL.Update(nhomNguoiDung))
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }

            MessageBox.Show("Cập nhật thành công.");
            FinishedAction();
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaNhom.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm người dùng cần xóa.");
                return;
            }

            int maNhomNguoiDung = Convert.ToInt32(textBoxMaNhom.Text);

            if (!_nhomNguoiDungBLL.Delete(maNhomNguoiDung))
            {
                MessageBox.Show("Xóa thất bại.");
                return;
            }

            MessageBox.Show("Xóa thành công.");
            FinishedAction();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            if (!IsInputValid(textBoxTenNhom.Text, richTextBoxGhiChu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            //Tạo controll để kiểm tra sau

            NhomNguoiDung nhomNguoiDung = new NhomNguoiDung();
            nhomNguoiDung.TenNhom = textBoxTenNhom.Text;
            nhomNguoiDung.GhiChu = richTextBoxGhiChu.Text;

            if (!_nhomNguoiDungBLL.Create(nhomNguoiDung))
            {
                MessageBox.Show("Thêm thất bại.");
                return;
            }

            MessageBox.Show("Thêm thành công.");
            FinishedAction();
        }

        private void DataGridViewNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNhomNguoiDung.Rows.Count == 0 || !dataGridViewNhomNguoiDung.CurrentRow.Selected)
            {
                return;
            }

            textBoxMaNhom.Text = dataGridViewNhomNguoiDung.CurrentRow.Cells[0].Value.ToString();
            textBoxTenNhom.Text = dataGridViewNhomNguoiDung.CurrentRow.Cells[1].Value.ToString();
            richTextBoxGhiChu.Text = dataGridViewNhomNguoiDung.CurrentRow.Cells[2].Value.ToString();
        }

        private void FormNhomNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataNhomNguoiDung();
        }

        private void LoadDataNhomNguoiDung()
        {
            List<NhomNguoiDung> nhomNguoiDung = _nhomNguoiDungBLL.ReadNhomNguoiDungs().ToList();

            dataGridViewNhomNguoiDung.DataSource = nhomNguoiDung;
        }

        private bool IsInputValid(string firstField, string secondField)
        {
            return !string.IsNullOrWhiteSpace(firstField) && !string.IsNullOrWhiteSpace(secondField);
        }

        private void ClearInput()
        {
            foreach (Control control in groupBoxNhomNguoiDung.Controls)
            {
                if (control.GetType() == typeof(TextBox) || control.GetType() == typeof(RichTextBox))
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void FinishedAction()
        {
            ClearInput();
            LoadDataNhomNguoiDung();
        }

        private void dataGridViewNhomNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxMaNhom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
