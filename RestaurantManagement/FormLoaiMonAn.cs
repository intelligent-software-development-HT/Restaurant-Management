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
    public partial class FormLoaiMonAn : Form
    {
        LoaiMonAnBLL loaiMonAnBLL = new LoaiMonAnBLL();
        bool _them;
        public FormLoaiMonAn()
        {
            InitializeComponent();
            this.Load += FormLoaiMonAn_Load;
            this.dataGridView1.CellClick += DataGridView1_CellClick;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonSua.Click += ButtonSua_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
            this.buttonCancel.Click += ButtonCancel_Click;
            this.buttonSave.Click += ButtonSave_Click;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                string tenLMA = textBoxTenLoaiMonAn.Text;
                LoaiMonAn l = new LoaiMonAn();
                l.TenLoaiMonAn = tenLMA;
                if (!loaiMonAnBLL.addLoaiMonAn(l))
                {
                    MessageBox.Show("Thêm loại món ăn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int maLoaiMonAn = int.Parse(textBoxMaLoaiMonAn.Text);
                string tenLMA = textBoxTenLoaiMonAn.Text;
                LoaiMonAn l = new LoaiMonAn();
                l.TenLoaiMonAn = tenLMA;
                if (!loaiMonAnBLL.editLoaiMonAn(maLoaiMonAn, l))
                {
                    MessageBox.Show("Sửa loại món ăn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            show();
            _them = false;
            loadData();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            show();
            _them = false;
        }

        void reset()
        {
            textBoxMaLoaiMonAn.Clear();
            textBoxTenLoaiMonAn.Clear();
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
        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            int maLoaiMonAn = int.Parse(textBoxMaLoaiMonAn.Text);

            if (!loaiMonAnBLL.deleteLoaiMonAn(maLoaiMonAn))
            {
                MessageBox.Show("Xóa loại món ăn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            textBoxMaLoaiMonAn.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTenLoaiMonAn.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void FormLoaiMonAn_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            loadDataGridView();
            textBoxMaLoaiMonAn.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            textBoxTenLoaiMonAn.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
        }
        void loadDataGridView()
        {
            List<LoaiMonAn> list = loaiMonAnBLL.getListLoaiMonAn();
            dataGridView1.DataSource = list;
        }
    }
}
