using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class FormThemNguoiDungVaoNhom : Form
    {
        private readonly NhomNguoiDungBLL _nhomNguoiDungBLL = new NhomNguoiDungBLL();
        private readonly NguoiDungBLL _nguoiDungBLL = new NguoiDungBLL();
        private readonly NguoiDungNhomNguoiDungBLL _nguoiDungNhomNguoiDung = new NguoiDungNhomNguoiDungBLL();

        public FormThemNguoiDungVaoNhom()
        {
            InitializeComponent();
            this.Load += FormThemNguoiDungVaoNhom_Load;
            this.Click += FormThemNguoiDungVaoNhom_Click;
            this.buttonThem.Click += ButtonThem_Click;
            this.buttonXoa.Click += ButtonXoa_Click;
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewNguoiDung.CurrentRow == null || comboBoxNhomNguoiDung.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn đầy đủ thông tin.");
                return;
            }

            string tenDangNhap = dataGridViewThemVaoNhom.CurrentRow.Cells[0].Value.ToString();
            int maNhom = Convert.ToInt32(dataGridViewThemVaoNhom.CurrentRow.Cells[1].Value);

            NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung = new NguoiDungNhomNguoiDung();
            nguoiDungNhomNguoiDung.TenDangNhap = tenDangNhap;
            nguoiDungNhomNguoiDung.MaNhomNguoiDung = maNhom;

            if (!_nguoiDungNhomNguoiDung.RemoveNguoiDungKhoiNhom(nguoiDungNhomNguoiDung))
            {
                MessageBox.Show("Xóa người dùng khỏi nhóm thất bại.");
                return;
            }

            LoadDataNguoiDungNhomNguoiDung();
        }

        private void ButtonThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem đã chọn đủ chưa
            if (dataGridViewNguoiDung.CurrentRow == null || comboBoxNhomNguoiDung.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn đầy đủ thông tin.");
                return;
            }

            string tenDangNhap = dataGridViewNguoiDung.CurrentRow.Cells[0].Value.ToString();
            int maNhom = (comboBoxNhomNguoiDung.SelectedItem as NhomNguoiDung).MaNhom;

            NguoiDungNhomNguoiDung nguoiDungNhomNguoiDung = new NguoiDungNhomNguoiDung();
            nguoiDungNhomNguoiDung.TenDangNhap = tenDangNhap;
            nguoiDungNhomNguoiDung.MaNhomNguoiDung = maNhom;

            if (!_nguoiDungNhomNguoiDung.AddNguoiDungVaoNhom(nguoiDungNhomNguoiDung))
            {
                MessageBox.Show("Thêm vào nhóm thất bại.");
                return;
            }

            LoadDataNguoiDungNhomNguoiDung();
        }

        private void FormThemNguoiDungVaoNhom_Click(object sender, EventArgs e)
        {
            dataGridViewNguoiDung.ClearSelection();
            dataGridViewThemVaoNhom.ClearSelection();
        }

        private void FormThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            LoadDataNguoiDung();
            LoadDataNguoiDungNhomNguoiDung();
            LoadDataNhomNguoiDung();
        }

        private void LoadDataNhomNguoiDung()
        {
            List<NhomNguoiDung> nhomNguoiDungs = _nhomNguoiDungBLL.ReadNhomNguoiDungs().ToList();

            comboBoxNhomNguoiDung.DataSource = nhomNguoiDungs;
            comboBoxNhomNguoiDung.DisplayMember = "TenNhom";
            comboBoxNhomNguoiDung.ValueMember = "MaNhom";
        }

        private void LoadDataNguoiDungNhomNguoiDung()
        {
            List<NguoiDungNhomNguoiDung> nguoiDungNhomNguoiDungs = _nguoiDungNhomNguoiDung.getListNguoiDungNhomNguoiDung().ToList();

            var table = new DataTable();
            table.Columns.Add("TenDangNhap");
            table.Columns.Add("NhomNguoiDung");

            foreach (var item in nguoiDungNhomNguoiDungs)
            {
                DataRow row = table.NewRow();
                row["TenDangNhap"] = item.TenDangNhap;
                row["NhomNguoiDung"] = item.MaNhomNguoiDung;

                table.Rows.Add(row);
            }

            dataGridViewThemVaoNhom.DataSource = table;
        }

        private void LoadDataNguoiDung()
        {
            List<NguoiDung> nguoiDungs = _nguoiDungBLL.ReadNguoiDungs().ToList();

            var table = new DataTable();
            table.Columns.Add("TenDangNhap");
            table.Columns.Add("HoatDong");

            foreach (var item in nguoiDungs)
            {
                DataRow row = table.NewRow();
                row["TenDangNhap"] = item.TenDangNhap;
                row["HoatDong"] = item.HoatDong;

                table.Rows.Add(row);
            }

            dataGridViewNguoiDung.DataSource = table;
        }
    }
}
