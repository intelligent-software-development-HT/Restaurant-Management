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
        MonAnBLL monAnBLL = new MonAnBLL();
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = monAnBLL.listMonAn(); 
        }
    }
}
