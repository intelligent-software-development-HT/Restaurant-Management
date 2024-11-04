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
            this.Load += FormNhomNguoiDung_Load;
            this.dataGridViewNhomNguoiDung.CellClick += DataGridViewNhomNguoiDung_CellClick;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
            this.buttonSua.Click += ButtonSua_Click;
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGridViewNhomNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dataGridViewNhomNguoiDung.CurrentRow.Selected)
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
            List<NhomNguoiDung> nhomNguoiDung = _nhomNguoiDungBLL.getListNhomNguoiDung();

            dataGridViewNhomNguoiDung.DataSource = nhomNguoiDung;
        }
    }
}
