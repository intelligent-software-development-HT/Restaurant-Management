using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class FormDonMon : Form
    {
        private readonly ChiTietHoaDonBLL _chiTietHoaDonBLL = new ChiTietHoaDonBLL();
        private readonly MonAnBLL _monAnBLL = new MonAnBLL();
        private readonly HoaDonBLL _hoaDonBLL = new HoaDonBLL();
        private readonly BanBLL _banBLL = new BanBLL();

        public FormDonMon()
        {
            InitializeComponent();
            this.Load += FormDonMon_Load;
            this.dataGridViewDonMon.CellClick += DataGridViewDonMon_CellClick;
            this.buttonCapNhatTrangThai.Click += ButtonCapNhatTrangThai_Click;
        }

        private void ButtonCapNhatTrangThai_Click(object sender, EventArgs e)
        {
            if (comboBoxDonMon.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn trạng thái cập nhật");
                return;
            }

            int maCTHD = Convert.ToInt32(dataGridViewDonMon.CurrentRow.Cells[0].Value);
            string status = comboBoxDonMon.SelectedValue.ToString();

            if (!_chiTietHoaDonBLL.UpdateTrangThaiMon(maCTHD, status))
            {
                MessageBox.Show("Lỗi trong quá trình cập nhật. Vui lòng thử lại sau.");
                return;
            }

            LoadDonMon();
            ClearThongTin();
        }

        private void ClearThongTin()
        {
            comboBoxDonMon.SelectedIndex = -1;
        }

        private void DataGridViewDonMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDonMon.SelectedRows.Count <= 0)
            {
                return;
            }

            int maCTHD = Convert.ToInt32(dataGridViewDonMon.CurrentRow.Cells[0].Value);
            ChiTietHoaDon chiTietHoaDon = _chiTietHoaDonBLL.GetById(maCTHD);

            comboBoxDonMon.SelectedValue = chiTietHoaDon.TrangThaiMon;
        }

        private void FormDonMon_Load(object sender, EventArgs e)
        {
            LoadDonMon();
            LoadTrangThaiMon();
        }

        private void LoadTrangThaiMon()
        {
            Dictionary<string, string> trangThais = new Dictionary<string, string>
            {
                { "preparing", "Đang chuẩn bị" },
                { "completed", "Đã xong" },
                //{ "Đã hủy", "canceled" },
            };

            comboBoxDonMon.DataSource = new BindingSource(trangThais, null);
            comboBoxDonMon.DisplayMember = "Value";
            comboBoxDonMon.ValueMember = "Key";
        }

        private void LoadDonMon()
        {
            List<ChiTietHoaDon> donMons = _chiTietHoaDonBLL.getListChiTietHoaDon();

            DataTable tableDonMons = new DataTable();
            tableDonMons.Columns.Add("Mã CTHD");
            tableDonMons.Columns.Add("Tên món");
            tableDonMons.Columns.Add("Tên bàn");
            tableDonMons.Columns.Add("Số lượng");
            tableDonMons.Columns.Add("Trạng thái");
            tableDonMons.Columns.Add("Thời gian đặt");

            foreach (var item in donMons)
            {
                MonAn monAn = _monAnBLL.getById(item.MaMonAn);
                int maBan = _hoaDonBLL.GetById(item.MaHD ?? 0).MaBan ?? 0;
                Ban ban = _banBLL.GetById(maBan);

                DataRow rowDonMon = tableDonMons.NewRow();
                rowDonMon["Mã CTHD"] = item.MaCTHD;
                rowDonMon["Tên món"] = monAn.TenMonAn;
                rowDonMon["Tên bàn"] = ban.TenBan;
                rowDonMon["Số lượng"] = item.SoLuong;
                rowDonMon["Trạng thái"] = item.TrangThaiMon == "preparing" ? "Đang chuẩn bị" : "Đã xong";
                rowDonMon["Thời gian đặt"] = item.ThoiGianDatMon;

                tableDonMons.Rows.Add(rowDonMon);
            }

            dataGridViewDonMon.DataSource = tableDonMons;
        }
    }
}
