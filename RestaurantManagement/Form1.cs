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
        public Form1()
        {
            InitializeComponent();
            this.buttonMonAn.Click += ButtonMonAn_Click;
            this.buttonLoaiMonAn.Click += ButtonLoaiMonAn_Click;
            this.pictureBoxClose.Click += PictureBoxClose_Click;
            this.pictureBoxMinimize.Click += PictureBoxMinimize_Click;
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

    }
}
