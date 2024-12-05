using BLL;
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
    public partial class FormDonMon : Form
    {
        private readonly ChiTietHoaDonBLL _chiTietHoaDonBLL = new ChiTietHoaDonBLL();
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

            string status = comboBoxDonMon.SelectedText;

            if (!_chiTietHoaDonBLL.UpdateTrangThaiMon(1, status))
            {
                MessageBox.Show("Lỗi trong quá trình cập nhật. Vui lòng thử lại sau.");
                return;
            }

            MessageBox.Show("Cập nhật thành công");
            LoadDonMon();
            ClearThongTin();

        }

        private void ClearThongTin()
        {
            comboBoxDonMon.SelectedIndex = -1;
        }

        private void DataGridViewDonMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Binding trạng thái vào combobox   
        }

        private void FormDonMon_Load(object sender, EventArgs e)
        {
            LoadDonMon();
        }

        private void LoadDonMon()
        {
            var donMons = _chiTietHoaDonBLL.getListChiTietHoaDon();

            dataGridViewDonMon.DataSource = donMons;
        }
    }
}
