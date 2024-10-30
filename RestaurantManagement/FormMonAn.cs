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
    public partial class FormMonAn : Form
    {
        MonAnBLL monAnBLL = new MonAnBLL();
        public FormMonAn()
        {
            InitializeComponent();
            this.Load += FormMonAn_Load;
        }

        private void FormMonAn_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            dataGridView1.DataSource = monAnBLL.listMonAn();
        }
    }
}
