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
    public partial class FormGopBan : Form
    {
        public int MaBan { get; set; }
        private readonly BanBLL _banBLL = new BanBLL();

        public FormGopBan()
        {
            InitializeComponent();
            this.buttonThucHien.Click += ButtonThucHien_Click;
            this.buttonBoQua.Click += ButtonBoQua_Click;
        }

        public FormGopBan(int maBan)
        {
            InitializeComponent();
            this.Load += FormGopBan_Load;
            this.buttonThucHien.Click += ButtonThucHien_Click;
            this.buttonBoQua.Click += ButtonBoQua_Click;

            MaBan = maBan;
        }

        private void FormGopBan_Load(object sender, EventArgs e)
        {
            List<Ban> bans = _banBLL.getListBan().Where(r => r.TrangThai == 0).ToList();

            checkedListBoxBanGop.Items.Clear();

            checkedListBoxBanGop.DisplayMember = "TenBan";

            foreach (var item in bans)
            {
                int index = checkedListBoxBanGop.Items.Add(item);

                //if (item.TrangThai)
                //{
                //    checkedListBoxBanGop.SetItemChecked(index, true);
                //}
            }

            lblTenBan.Text = _banBLL.GetById(MaBan).TenBan;
        }

        private void ButtonBoQua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonThucHien_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkedListBoxBanGop.CheckedItems.Count <= 0)
                {
                    MessageBox.Show("Vui lòng chọn bàn để gộp");
                    return;
                }

                //Gán trạng thái của các bàn gộp thành mã bàn chính
                foreach (var item in checkedListBoxBanGop.CheckedItems)
                {
                    if (item is Ban ban)
                    {
                        _banBLL.CapNhatTrangThaiBan(ban.MaBan, MaBan);
                    }
                }

                //thực hiện thành công mới close
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gộp bàn không thành công");
            }
        }
    }
}
