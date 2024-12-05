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

        public FormDatMon()
        {
            InitializeComponent();
            this.Load += FormDatMon_Load;
            this.pictureBoxNotify.Click += PictureBoxNotify_Click;
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
        }

        private void LoadThucDon()
        {

        }

        private void LoadDanhSachBan()
        {
            List<Ban> bans = _banBLL.getListBan();

            if (bans?.Count <= 0)
            {
                MessageBox.Show("Hiện tại chưa bàn trên hệ thống.");
                return;
            }

            int tableCol = 4;
            int rowCountByTable = (int)Math.Ceiling((bans.Count * 1.0) / tableCol);

            this.tableLayoutPanelBan.ColumnCount = tableCol;
            this.tableLayoutPanelBan.RowCount = rowCountByTable < 4 ? rowCountByTable : 4;
            //this.tableLayoutPanelBan.Dock = DockStyle.Fill;

            foreach (var item in bans)
            {
                Button btnTable = new Button()
                {
                    Text = item.TenBan,
                    Size = new Size(60, 60),
                    //Dock = DockStyle.None,
                    Tag = item.MaBan,
                    BackColor = item.TrangThai == "Trống" ? Color.Magenta : Color.IndianRed
                };

                btnTable.Click += BtnTable_Click;

                this.tableLayoutPanelBan.Controls.Add(btnTable);
            }
        }

        private void BtnTable_Click(object sender, EventArgs e)
        {
            groupBoxDatMon.Text = (sender as Button).Text;
        }
    }
}
