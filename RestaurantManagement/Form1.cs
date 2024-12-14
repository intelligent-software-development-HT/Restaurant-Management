using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace RestaurantManagement
{
    public partial class Form1 : Form
    {
        FormMonAn formMonAn;
        FormLoaiMonAn formLoaiMonAn;
        private readonly PhanQuyenBLL _phanQuyenBLL = new PhanQuyenBLL();

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
            this.buttonMonAn.Click += ButtonMonAn_Click;
            this.buttonLoaiMonAn.Click += ButtonLoaiMonAn_Click;
            this.buttonBan.Click += ButtonBan_Click;
            this.pictureBoxClose.Click += PictureBoxClose_Click;
            this.pictureBoxMinimize.Click += PictureBoxMinimize_Click;
            this.buttonNhomNguoiDung.Click += ButtonNhomNguoiDung_Click;
            this.buttonTaiKhoan.Click += ButtonTaiKhoan_Click;
            this.buttonManHinh.Click += ButtonManHinh_Click;
            this.buttonThemVaoNhom.Click += ButtonThemVaoNhom_Click;
            this.buttonPhanQuyen.Click += ButtonPhanQuyen_Click;
            this.buttonDatMon.Click += ButtonDatMon_Click;
            this.buttonDonMon.Click += ButtonDonMon_Click;
            this.buttonThongKe.Click += ButtonThongKe_Click;
            //Lấy role của người dùng
            int maNhom = Convert.ToInt32(Properties.Settings.Default.maNhom);
            //Đưa vào hàm để phân quyền
            HandleQuyenTruyCap(maNhom);
        }

        private void ButtonThongKe_Click(object sender, EventArgs e)
        {
            ShowForm(new FormThongKe());
        }

        private void ButtonBan_Click(object sender, EventArgs e)
        {
            ShowForm(new FormBan());
        }

        private void ButtonDonMon_Click(object sender, EventArgs e)
        {
            ShowForm(new FormDonMon());
        }

        private void ButtonDatMon_Click(object sender, EventArgs e)
        {
            ShowForm(new FormDatMon());
        }

        private void ButtonPhanQuyen_Click(object sender, EventArgs e)
        {
            ShowForm(new FormPhanQuyen());
        }

        private void ButtonThemVaoNhom_Click(object sender, EventArgs e)
        {
            ShowForm(new FormThemNguoiDungVaoNhom());
        }

        private void ButtonManHinh_Click(object sender, EventArgs e)
        {
            ShowForm(new FormManHinh());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formDangNhap.Show();
        }

        private void ButtonTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowForm(new FormNguoiDung());
        }

        private void ButtonNhomNguoiDung_Click(object sender, EventArgs e)
        {
            ShowForm(new FormNhomNguoiDung());
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonMonAn_Click(object sender, EventArgs e)
        {
            ShowForm(new FormMonAn());
        }

        private void HandleQuyenTruyCap(int maNhom)
        {
            List<PhanQuyenDK> phanQuyenDKs = _phanQuyenBLL.GetQuyenTruyCapTheoNhom(maNhom).ToList();

            foreach (PhanQuyenDK phanQuyen in phanQuyenDKs)
            {
                bool quyenTruyCap = phanQuyen.CoQuyen;

                switch (phanQuyen.MaManHinh)
                {
                    case 1:
                        IsControlVisible(buttonDatMon, quyenTruyCap);
                        break;
                    case 2:
                        IsControlVisible(buttonDonMon, quyenTruyCap);
                        break;
                    case 3:
                        IsControlVisible(buttonBan, quyenTruyCap);
                        break;
                    case 4:
                        IsControlVisible(buttonLoaiMonAn, quyenTruyCap);
                        break;
                    case 5:
                        IsControlVisible(buttonMonAn, quyenTruyCap);
                        break;
                    case 6:
                        break;
                    case 7:
                        IsControlVisible(buttonTaiKhoan, quyenTruyCap);
                        break;
                    case 8:
                        IsControlVisible(buttonNhomNguoiDung, quyenTruyCap);
                        break;
                    case 9:
                        IsControlVisible(buttonManHinh, quyenTruyCap);
                        break;
                    case 10:
                        IsControlVisible(buttonPhanQuyen, quyenTruyCap);
                        break;
                    case 11:
                        IsControlVisible(buttonThemVaoNhom, quyenTruyCap);
                        break;
                    case 12:
                        IsControlVisible(buttonThongKe, quyenTruyCap);
                        break;
                    default:
                        break;
                }
            }
        }

        private void IsControlVisible(Control control, bool visible)
        {
            if (control == null)
            {
                return;
            }

            control.Visible = visible;
        }

        private void ShowForm(Form newForm)
        {
            if (panelMain.Controls.Count > 0)
            {
                var currentForm = panelMain.Controls[0] as Form;
                if (currentForm != null)
                {
                    currentForm.Close();
                    panelMain.Controls.Remove(currentForm);
                }
            }
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(newForm);
            newForm.Show();
        }
        private void ButtonLoaiMonAn_Click(object sender, EventArgs e)
        {
            ShowForm(new FormLoaiMonAn());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
