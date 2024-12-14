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
    public partial class FormDatMon : Form
    {
        private readonly BanBLL _banBLL = new BanBLL();
        private readonly MonAnBLL _monAnBLL = new MonAnBLL();
        private readonly LoaiMonAnBLL _loaiMonBLL = new LoaiMonAnBLL();
        private readonly NhanVienBLL _nhanVienBLL = new NhanVienBLL();
        private readonly DatMonBLL _datMonBLL = new DatMonBLL();
        private readonly HoaDonBLL _hoaDonBLL = new HoaDonBLL();
        private readonly ChiTietHoaDonBLL _chiTietHoaDonBLL = new ChiTietHoaDonBLL();

        public FormDatMon()
        {
            InitializeComponent();
            this.Load += FormDatMon_Load;
            this.pictureBoxNotify.Click += PictureBoxNotify_Click;
            this.nudSoLuong.ValueChanged += NudSoLuong_ValueChanged;
            this.buttonThemMon.Click += ButtonThemMon_Click;
            this.buttonThanhToan.Click += ButtonThanhToan_Click;
            this.buttonInHoaDon.Click += ButtonInHoaDon_Click;
        }
        private void ButtonInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int maBan = Convert.ToInt32(groupBoxDatMon.Tag);
                HoaDon hoaDon = _hoaDonBLL.GetByBan(maBan);
                Ban ban = _banBLL.GetById(maBan);
                NhanVien nhanVien = _nhanVienBLL.GetById(hoaDon.MaNV);
                List<ChiTietHoaDon> chiTietHoaDons = _chiTietHoaDonBLL.GetDanhSachMonDat(hoaDon.MaHD);

                _hoaDonBLL.InHoaDon(hoaDon.MaHD, hoaDon.NgayLap.ToString(), ban.TenBan, nhanVien.TenNV, hoaDon.TongTien, chiTietHoaDons);
            }
            catch (Exception ex)
            {
                MessageBox.Show("In hóa đơn thất bại");
                return;
            }

            MessageBox.Show("In hóa đơn thành công");
        }

        private void ButtonThanhToan_Click(object sender, EventArgs e)
        {
            int maBan = Convert.ToInt32(groupBoxDatMon.Tag);
            HoaDon hoaDon = _hoaDonBLL.GetByBan(maBan);

            DialogResult result = MessageBox.Show("Bạn muốn thanh toán?", "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            if (!_hoaDonBLL.XuLyThanhToan(hoaDon.MaHD, maBan))
            {
                MessageBox.Show("Thanh toán thất bại.");
                return;
            }

            LoadDanhSachBan();
            LoadThongTinDatMon(0);
        }

        private void ButtonThemMon_Click(object sender, EventArgs e)
        {
            if (!panelThongTinDatMon.Visible)
            {
                MessageBox.Show("Vui lòng chọn món");
                return;
            }

            int soLuong = Convert.ToInt32(nudSoLuong.Value);
            int maMon = Convert.ToInt32(lblTenMon.Tag);
            int maBan = Convert.ToInt32(groupBoxDatMon.Tag);
            NhanVien nhanVien = _nhanVienBLL.GetByTenDangNhap(labelTenDangNhap.Tag.ToString());
            HoaDon hoaDon = _hoaDonBLL.GetByBan(maBan);
            int maHoaDon = hoaDon?.MaHD ?? 0;

            var thongTinDatMon = new DatMonDTO
            {
                MaHoaDon = maHoaDon,
                MaMonAn = maMon,
                MaBan = maBan,
                MaNhanVien = nhanVien.MaNV,
                SoLuong = soLuong,
            };

            if (!_datMonBLL.XuLyDatMon(thongTinDatMon))
            {
                MessageBox.Show("Đặt món không thành công.");
                return;
            }

            if (maHoaDon == 0)
            {
                HoaDon hoaDonNew = _hoaDonBLL.GetByBan(maBan);
                maHoaDon = hoaDonNew.MaHD;
            }

            LoadThongTinDatMon(maHoaDon);
            LoadDanhSachBan();
        }

        private void LoadThongTinDatMon(int maHoaDon = 0)
        {
            listViewDonMon.Items.Clear();

            List<ChiTietHoaDon> chiTietHoaDons = _chiTietHoaDonBLL.GetDanhSachMonDat(maHoaDon);

            foreach (var donMon in chiTietHoaDons)
            {
                MonAn monAn = _monAnBLL.getById(donMon.MaMonAn);

                var item = new ListViewItem(monAn.TenMonAn);

                item.SubItems.Add(donMon.SoLuong.ToString());
                item.SubItems.Add(monAn.DonGia.ToString());
                item.SubItems.Add(donMon.ThanhTien.ToString());

                listViewDonMon.Items.Add(item);
            }

            int total = chiTietHoaDons.Sum(r => r.ThanhTien).Value;

            textBoxTongTien.Text = total.ToString();
        }

        private void NudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int subtotal = Convert.ToInt32(textBoxDonGia.Text) * (int)nudSoLuong.Value;

                lblThanhTien.Text = subtotal.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void PictureBoxNotify_Click(object sender, EventArgs e)
        {
            FormThongBaoDatBan form = new FormThongBaoDatBan();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(620, 80);
            form.ShowDialog();
        }

        private void FormDatMon_Load(object sender, EventArgs e)
        {
            LoadDanhSachBan();
            LoadThucDon();
            
            panelThongTinDatMon.Visible = false;
            labelTenDangNhap.Text = "Hello " + Properties.Settings.Default.tenDangNhap;
            labelTenDangNhap.Tag = Properties.Settings.Default.tenDangNhap;
            
        }


        private void LoadThucDon()
        {
            LoadDanhSachLoaiMon();
            LoadDanhSachThucDon();
        }
        private void LoadDanhSachLoaiMon()
        {
            List<LoaiMonAn> loaiMons = _loaiMonBLL.getListLoaiMonAn();

            if (loaiMons?.Count <= 0)
            {
                return;
            }

            this.flowLayoutPanelLoaiMon.Controls.Clear();

            // Nút "Tất cả"
            Button btnTatCa = new Button
            {
                Text = "Tất cả",
                Margin = new Padding(5),
                Tag = 0,
                AutoSize = true,// Kích thước cố định
                BackColor = Color.White // Màu nền
            };
            btnTatCa.Click += BtnTatCa_Click;
            this.flowLayoutPanelLoaiMon.Controls.Add(btnTatCa);

            // Thêm các loại món
            foreach (var item in loaiMons)
            {
                Button btnLoaiMon = new Button
                {
                    Text = item.TenLoaiMonAn,
                    Margin = new Padding(5),
                    Tag = item.MaLoaiMonAn,
                    AutoSize = true,
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                };

                btnLoaiMon.Click += BtnLoaiMon_Click;
                this.flowLayoutPanelLoaiMon.Controls.Add(btnLoaiMon);
            }

            // Tính toán tổng chiều rộng của các nút
            int totalWidth = flowLayoutPanelLoaiMon.Controls.OfType<Button>().Sum(btn => btn.Width + btn.Margin.Horizontal + (loaiMons.Count * 7));

            // Cài đặt giá trị cho HScrollBar
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = totalWidth - this.flowLayoutPanelLoaiMon.Width; // Tổng chiều rộng - chiều rộng của FlowLayoutPanel
            hScrollBar1.LargeChange = this.flowLayoutPanelLoaiMon.Width; // Kích thước cuộn lớn
            hScrollBar1.SmallChange = 10; // Kích thước cuộn nhỏ

            // Đặt chiều rộng của FlowLayoutPanel nếu cần
            flowLayoutPanelLoaiMon.Width = totalWidth; // Cập nhật chiều rộng của FlowLayoutPanel
        }



        private void BtnTatCa_Click(object sender, EventArgs e)
        {
            LoadDanhSachThucDon();
        }

        private void BtnLoaiMon_Click(object sender, EventArgs e)
        {
            int maLoai = Convert.ToInt32((sender as Button).Tag);
            LoadDanhSachThucDon(maLoai);
        }

        private void LoadDanhSachThucDon(int maLoaiMon = 0)
        {
            List<MonAn> mons = maLoaiMon == 0 ? _monAnBLL.listMonAn() : _monAnBLL.GetMonAnsByLoaiMon(maLoaiMon);

            if (mons?.Count <= 0)
            {
                this.tableLayoutPanelMon.Controls.Clear();
                return;
            }

            int tableCol = 3;
            int controlHeight = 100;
            int rowCountByTable = (int)Math.Ceiling((mons.Count * 1.0) / tableCol);

            // Xóa cấu hình cũ
            this.tableLayoutPanelMon.Controls.Clear();
            this.tableLayoutPanelMon.ColumnStyles.Clear();
            this.tableLayoutPanelMon.RowStyles.Clear();

            // Cấu hình số cột
            this.tableLayoutPanelMon.ColumnCount = tableCol;
            for (int i = 0; i < tableCol; i++)
            {
                this.tableLayoutPanelMon.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / tableCol));
            }

            // Cấu hình số hàng
            this.tableLayoutPanelMon.RowCount = rowCountByTable;
            for (int i = 0; i < rowCountByTable; i++)
            {
                this.tableLayoutPanelMon.RowStyles.Add(new RowStyle(SizeType.Absolute, controlHeight));
            }

            this.tableLayoutPanelMon.AutoScroll = true;

            int totalControl = 4 * rowCountByTable;
            int totalTableSpace = totalControl < 16 ? 16 : totalControl;
            for (int index = 0; index < totalTableSpace; index++)
            {
                if (index < mons.Count)
                {
                    Button btnMonAn = new Button
                    {
                        Text = mons[index].TenMonAn,
                        Dock = DockStyle.Fill,
                        Tag = mons[index].MaMonAn,
                        Margin = new Padding(8),
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Flat

                    };
                    btnMonAn.Click += BtnMonAn_Click;
                    this.tableLayoutPanelMon.Controls.Add(btnMonAn, index % tableLayoutPanelMon.ColumnCount,
                    index / tableLayoutPanelMon.ColumnCount);
                }
                else
                {
                    Label emptyLabel = new Label
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(5),
                    };
                    this.tableLayoutPanelMon.Controls.Add(emptyLabel, index % tableLayoutPanelMon.ColumnCount,
                    index / tableLayoutPanelMon.ColumnCount);
                }
            }
        }

        private void BtnMonAn_Click(object sender, EventArgs e)
        {
            int maMonAn = Convert.ToInt32((sender as Button).Tag);

            MonAn monAn = _monAnBLL.getById(maMonAn);

            if (monAn == null)
            {
                return;
            }

            panelThongTinDatMon.Visible = true;

            lblTenMon.Tag = monAn.MaMonAn;
            lblTenMon.Text = monAn.TenMonAn;
            nudSoLuong.Value = 1;
            textBoxDonGia.Text = monAn.DonGia.ToString();
            lblThanhTien.Text = monAn.DonGia.ToString();
        }

        private void LoadDanhSachBan()
        {
            List<Ban> bans = _banBLL.getListBan();

            if (bans?.Count <= 0)
            {
                MessageBox.Show("Hiện tại chưa có bàn trên hệ thống.");
                return;
            }

            int tableCol = 4; // Số cột cố định
            int controlHeight = 100;
            int rowCountByTable = (int)Math.Ceiling((bans.Count * 1.0) / tableCol);

            // Xóa cấu hình cũ
            this.tableLayoutPanelBan.Controls.Clear();
            this.tableLayoutPanelBan.ColumnStyles.Clear();
            this.tableLayoutPanelBan.RowStyles.Clear();

            // Cấu hình số cột
            this.tableLayoutPanelBan.ColumnCount = tableCol;
            for (int i = 0; i < tableCol; i++)
            {
                this.tableLayoutPanelBan.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / tableCol));
            }

            // Cấu hình số hàng
            this.tableLayoutPanelBan.RowCount = rowCountByTable;

            int totalControl = 4 * rowCountByTable;
            int totalTableSpace = totalControl < 16 ? 16 : totalControl;

            for (int i = 0; i < rowCountByTable; i++)
            {
                this.tableLayoutPanelBan.RowStyles.Add(new RowStyle(SizeType.Absolute, controlHeight));
            }

            this.tableLayoutPanelBan.AutoScroll = true;

            for (int index = 0; index < totalTableSpace; index++)
            {
                if (index < bans.Count)
                {
                    Button btnTable = new Button
                    {
                        Text = bans[index].TenBan,
                        Dock = DockStyle.Fill,
                        Tag = bans[index].MaBan,
                        Margin = new Padding(5),
                        BackColor = !bans[index].TrangThai ? Color.FromArgb(0, 128, 128) : Color.FromArgb(172, 26, 8),
                        ForeColor = Color.White
                    };
                    btnTable.Click += BtnTable_Click;
                    this.tableLayoutPanelBan.Controls.Add(btnTable, index % tableLayoutPanelBan.ColumnCount,
                    index / tableLayoutPanelBan.ColumnCount);
                }
                else
                {
                    Label emptyLabel = new Label
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(5),
                    };
                    this.tableLayoutPanelBan.Controls.Add(emptyLabel, index % tableLayoutPanelBan.ColumnCount,
                    index / tableLayoutPanelBan.ColumnCount);
                }
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            groupBoxDatMon.Text = (sender as Button).Text;
            panelThongTinDatMon.Visible = false;
            groupBoxDatMon.Tag = (sender as Button).Tag;//Mã hóa đơn

            HoaDon hoaDon = _hoaDonBLL.GetByBan(Convert.ToInt32(groupBoxDatMon.Tag));

            if (hoaDon != null)
            {
                buttonThanhToan.Enabled = true;
            }
            else
            {
                buttonThanhToan.Enabled = false;
            }

            LoadThongTinDatMon(hoaDon?.MaHD ?? 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            flowLayoutPanelLoaiMon.Left = -hScrollBar1.Value;
        }
    }
}
