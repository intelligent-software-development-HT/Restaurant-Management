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
    public partial class FormMonAn : Form
    {
        MonAnBLL monAnBLL = new MonAnBLL();
        LoaiMonAnBLL loaiMonAnBLL = new LoaiMonAnBLL();
        bool _them;
        public FormMonAn()
        {
            InitializeComponent();
            this.Load += FormMonAn_Load;
            this.dataGridView1.CellClick += DataGridView1_CellClick;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonSua.Click += ButtonSua_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
            this.buttonSave.Click += ButtonSave_Click;
            this.buttonCancel.Click += ButtonCancel_Click;
        }
        void reset()
        {
            textBoxMaMonAn.Clear();
            textBoxTenMonAn.Clear();
            textBoxDonGia.Clear();
        }
        void show()
        {
            buttonSave.Hide();
            buttonCancel.Hide();
            buttonThem.Show();
            buttonXoa.Show();
            buttonSua.Show();
        }
        void hide()
        {
            buttonSave.Show();
            buttonCancel.Show();
            buttonThem.Hide();
            buttonXoa.Hide();
            buttonSua.Hide();
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            show();
            _them = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(_them)
            {
                MonAn m = new MonAn();
                m.TenMonAn = textBoxTenMonAn.Text;
                m.DonGia = int.Parse(textBoxDonGia.Text);
                m.MaLoaiMonAn = int.Parse(comboBoxLoaiMonAn.SelectedValue.ToString());
                if (!monAnBLL.addMonAn(m))
                {
                    MessageBox.Show("Thêm món ăn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int maMonAn = int.Parse(textBoxMaMonAn.Text);
                MonAn mNew = new MonAn();
                mNew.TenMonAn = textBoxMaMonAn.Text;
                mNew.DonGia = int.Parse(textBoxDonGia.Text);
                mNew.MaLoaiMonAn = int.Parse(comboBoxLoaiMonAn.SelectedValue.ToString());
                if (!monAnBLL.editMonAn(maMonAn, mNew))
                {
                    MessageBox.Show("Sửa món ăn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            show();
            _them = false;
            loadData();
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            int maMonAn = int.Parse(textBoxMaMonAn.Text);
            if (!monAnBLL.deleteMonAn(maMonAn))
            {
                MessageBox.Show("Xóa món ăn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadData();
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            _them = false;
            hide();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            _them = true;
            hide();
            reset();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaMonAn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxTenMonAn.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxDonGia.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxLoaiMonAn.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();


        }

        private void FormMonAn_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            loadDataGridView();
            loadCMB();
            textBoxMaMonAn.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBoxTenMonAn.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            textBoxDonGia.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            comboBoxLoaiMonAn.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
        }
        void loadCMB()
        {
            comboBoxLoaiMonAn.DataSource = loaiMonAnBLL.getListLoaiMonAn();
            comboBoxLoaiMonAn.DisplayMember = "TenLoaiMonAn";
            comboBoxLoaiMonAn.ValueMember = "MaLoaiMonAn";
        }
        void loadDataGridView()
        {
            dataGridView1.DataSource = monAnBLL.listMonAn();
            dataGridView1.Columns[0].HeaderText = "Mã món ăn"; 
            dataGridView1.Columns[1].HeaderText = "Tên món ăn";
            dataGridView1.Columns[2].HeaderText = "Đơn giá";
            dataGridView1.Columns[3].HeaderText = "Tên loại món ăn";
            
        }
    }
}
