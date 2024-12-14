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
    public partial class FormThongBaoDatBan : Form
    {
        private readonly PhieuDatBanBLL _phieuDatBanBLL = new PhieuDatBanBLL();

        public FormThongBaoDatBan()
        {
            InitializeComponent();
            this.Load += FormThongBaoDatBan_Load;
            this.pictureBoxCloseModal.Click += PictureBoxCloseModal_Click;
        }

        private void PictureBoxCloseModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongBaoDatBan_Load(object sender, EventArgs e)
        {
            List<DatBan> datBans = _phieuDatBanBLL.GetDanhSachDatBan();

            if (datBans == null)
            {
                return;
            }

            dataGridViewThongBao.DataSource = datBans;
        }
    }
}
