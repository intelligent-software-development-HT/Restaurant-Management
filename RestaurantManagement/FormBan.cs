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
    public partial class FormBan : Form
    {
        BanBLL banBLL = new BanBLL();
        bool _them;
        public FormBan()
        {
            InitializeComponent();
            this.Load += FormBan_Load;
            this.dataGridView1.CellClick += DataGridView1_CellClick;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
            this.buttonSua.Click += ButtonSua_Click;
            this.buttonSave.Click += ButtonSave_Click;
            this.buttonCancel.Click += ButtonCancel_Click;
        }
        void reset()
        {
            textBoxMaBan.Clear();
            textBoxTenBan.Clear();
            textBoxTrangThai.Clear();
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
        private void FormBan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            show();
            _them = false;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                string tenBan = textBoxTenBan.Text;
                Ban b = new Ban();
                b.TenBan = tenBan;
                b.TrangThai = false;
                if(!banBLL.addBan(b))
                {
                    MessageBox.Show("Thêm bàn mới không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int maBan = int.Parse(textBoxMaBan.Text);
                string tenBan = textBoxTenBan.Text.Trim();
                bool trangThai = false;
                Ban b = new Ban();
                b.TenBan = tenBan;
                b.TrangThai = trangThai;
                if(!banBLL.editBan(maBan, b))
                {
                    MessageBox.Show("Sửa bàn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            show();
            _them = false;
            loadData();
        }

        private void ButtonSua_Click(object sender, EventArgs e)
        {
            _them = false;
            hide();
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            int maBan = int.Parse(textBoxMaBan.Text);
            if (!banBLL.deleteBan(maBan))
            {
                MessageBox.Show("Xóa bàn không thành công !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            loadData();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            _them = true;
            hide();
            reset();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaBan.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxTenBan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxTrangThai.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        void loadData()
        {
            loadDataGridView();
            //textBoxMaBan.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            //textBoxTenBan.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            //textBoxTrangThai.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }

        void loadDataGridView()
        {
            var bans = banBLL.getListBan();

            if (bans == null)
            {
                MessageBox.Show("Chưa có bàn trong hệ thống");
                return;
            }

            dataGridView1.DataSource = bans;
        }
    }
}
