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
    public partial class FormManHinh : Form
    {
        private readonly ManHinhBLL _manHinhBLL = new ManHinhBLL();

        public FormManHinh()
        {
            InitializeComponent();
            this.Load += FormManHinh_Load;
            this.Click += FormManHinh_Click;
            this.buttonHuy.Click += ButtonHuy_Click;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
            this.buttonSua.Click += ButtonSua_Click;
            this.dataGridViewManHinh.CellClick += DataGridViewManHinh_CellClick;
        }

        private void DataGridViewManHinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewManHinh.Rows.Count == 0 || !dataGridViewManHinh.CurrentRow.Selected)
            {
                return;
            }

            textBoxMaManHinh.Text = dataGridViewManHinh.CurrentRow.Cells[0].Value.ToString();
            textBoxTenManHinh.Text = dataGridViewManHinh.CurrentRow.Cells[1].Value.ToString();
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaManHinh.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm màn hình cần xóa.");
                return;
            }

            if (!IsInputValid(textBoxTenManHinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            ManHinh manHinh = new ManHinh();
            manHinh.MaManHinh = Convert.ToInt32(textBoxMaManHinh.Text);
            manHinh.TenManHinh = textBoxTenManHinh.Text;

            if (!_manHinhBLL.Update(manHinh))
            {
                MessageBox.Show("Cập nhật thất bại.");
                return;
            }

            MessageBox.Show("Cập nhật thành công.");
            FinishedAction();
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxMaManHinh.Text))
            {
                MessageBox.Show("Vui lòng chọn nhóm màn hình cần xóa.");
                return;
            }

            int maManHinh = Convert.ToInt32(textBoxMaManHinh.Text);

            if (!_manHinhBLL.Delete(maManHinh))
            {
                MessageBox.Show("Xóa thất bại.");
                return;
            }

            MessageBox.Show("Xóa thành công.");
            FinishedAction();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            if (!IsInputValid(textBoxTenManHinh.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            //Tạo controll để kiểm tra sau

            ManHinh manHinh = new ManHinh();
            manHinh.TenManHinh = textBoxTenManHinh.Text;

            if (!_manHinhBLL.Create(manHinh))
            {
                MessageBox.Show("Thêm thất bại.");
                return;
            }

            MessageBox.Show("Thêm thành công.");
            FinishedAction();
        }

        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void FormManHinh_Click(object sender, EventArgs e)
        {
            ClearInput();
            dataGridViewManHinh.ClearSelection();
        }

        private void FormManHinh_Load(object sender, EventArgs e)
        {
            LoadDataManHinh();
        }

        private void LoadDataManHinh()
        {
            List<ManHinh> manHinhs = _manHinhBLL.ReadNhomNguoiDungs().ToList();

            dataGridViewManHinh.DataSource = manHinhs;
        }

        private bool IsInputValid(string firstField)
        {
            return !string.IsNullOrWhiteSpace(firstField);
        }

        private void ClearInput()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = string.Empty;
                }
            }
        }

        private void FinishedAction()
        {
            ClearInput();
            LoadDataManHinh();
        }
    }
}
