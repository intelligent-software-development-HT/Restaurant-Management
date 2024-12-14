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
            this.dataGridViewDonMon.RowPrePaint += DataGridViewDonMon_RowPrePaint;
            this.buttonDaXong.Click += ButtonDaXong_Click;
        }

        private void ButtonDaXong_Click(object sender, EventArgs e)
        {
            int maCTHD = Convert.ToInt32(dataGridViewDonMon.CurrentRow.Cells[0].Value);
            string status = "completed";

            if (!_chiTietHoaDonBLL.UpdateTrangThaiMon(maCTHD, status))
            {
                MessageBox.Show("Lỗi trong quá trình cập nhật. Vui lòng thử lại sau.");
                return;
            }

            LoadDonMon();
        }

        private void DataGridViewDonMon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridViewDonMon.Rows[e.RowIndex];
            if (row.Cells[4].Value.ToString() == "Đã xong")
            {
                dataGridViewDonMon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                dataGridViewDonMon.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                dataGridViewDonMon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                dataGridViewDonMon.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void FormDonMon_Load(object sender, EventArgs e)
        {
            LoadDonMon();
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
