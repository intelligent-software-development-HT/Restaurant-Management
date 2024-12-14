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
            this.dataGridViewThongBao.MouseDown += DataGridViewThongBao_MouseDown;
            this.duyệtToolStripMenuItem.Click += DuyệtToolStripMenuItem_Click;
        }

        private void DuyệtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewThongBao.SelectedRows.Count <= 0)
            {
                return;
            }

            int maDatBan = Convert.ToInt32(dataGridViewThongBao.CurrentRow.Cells[0].Value);

            if (_phieuDatBanBLL.DuyetTrangThaiDatBan(maDatBan))
            {
                LoadDanhSachDatBan();
            }
        }

        private void DataGridViewThongBao_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridViewThongBao.HitTest(e.X, e.Y);

                if (hitTestInfo.RowIndex >= 0)
                {
                    dataGridViewThongBao.ClearSelection();
                    dataGridViewThongBao.Rows[hitTestInfo.RowIndex].Selected = true;

                    contextMenuStripTrangThaiDatMon.Show(dataGridViewThongBao, e.Location);
                }
            }
        }

        private void PictureBoxCloseModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongBaoDatBan_Load(object sender, EventArgs e)
        {
            LoadDanhSachDatBan();
        }

        private void LoadDanhSachDatBan()
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
