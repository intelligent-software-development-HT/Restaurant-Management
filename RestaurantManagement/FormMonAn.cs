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
                mNew.TenMonAn = textBoxTenMonAn.Text;
                mNew.DonGia = int.Parse(textBoxDonGia.Text);
                int maLoaiMon = int.Parse(comboBoxLoaiMonAn.SelectedValue.ToString());
                mNew.LoaiMonAn = loaiMonAnBLL.getById(maLoaiMon);
                mNew.MaLoaiMonAn = maLoaiMon;
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
            int maMonAn = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            BindingDataMonAn(maMonAn);
        }

        private void BindingDataMonAn(int maMonAn)
        {
            MonAn monAn = monAnBLL.getById(maMonAn);

            textBoxMaMonAn.Text = monAn.MaMonAn.ToString();
            textBoxTenMonAn.Text = monAn.TenMonAn;
            textBoxDonGia.Text = monAn.DonGia.ToString();
            comboBoxLoaiMonAn.Text = monAn.LoaiMonAn.TenLoaiMonAn;
        }

        private void FormMonAn_Load(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            loadDataGridView();
            loadCMB();

            BindingDataMonAn(1);
        }

        void loadCMB()
        {
            comboBoxLoaiMonAn.DataSource = loaiMonAnBLL.getListLoaiMonAn();
            comboBoxLoaiMonAn.DisplayMember = "TenLoaiMonAn";
            comboBoxLoaiMonAn.ValueMember = "MaLoaiMonAn";
        }

        void loadDataGridView()
        {
            List<MonAn> monAns = monAnBLL.listMonAn();

            DataTable table = new DataTable();
            table.Columns.Add("MaMonAn");
            table.Columns.Add("TenMonAn");
            table.Columns.Add("MoTa");
            table.Columns.Add("DonGia");
            table.Columns.Add("TenLoaiMonAn");

            foreach (var item in monAns)
            {
                DataRow row = table.NewRow();
                row["MaMonAn"] = item.MaMonAn;
                row["TenMonAn"] = item.TenMonAn;
                row["MoTa"] = item.MoTa;
                row["DonGia"] = item.DonGia;
                row["TenLoaiMonAn"] = item.LoaiMonAn.TenLoaiMonAn;

                table.Rows.Add(row);
            }

            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "Mã món ăn"; 
            dataGridView1.Columns[1].HeaderText = "Tên món ăn";
            dataGridView1.Columns[2].HeaderText = "Mô tả";
            dataGridView1.Columns[3].HeaderText = "Đơn giá";
            dataGridView1.Columns[4].HeaderText = "Tên loại món ăn";
        }
    }
}
