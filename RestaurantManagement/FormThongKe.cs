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
using System.Windows.Forms.DataVisualization.Charting;

namespace RestaurantManagement
{
    public partial class FormThongKe : Form
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        public FormThongKe()
        {
            InitializeComponent();
            this.Load += FormThongKe_Load;
            this.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            if (comboBox1.SelectedIndex == 0)
            {
                thongKeDoanhThu(startDate, endDate);
            }
            else
            {
                thongKeMonAn(startDate, endDate);
            }
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            loadCmB();
        }
        void thongKeDoanhThu(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            var data = hoaDonBLL.GetDoanhThu(startDate, endDate);
            dt.Columns.Add("Ngay", typeof(DateTime));
            dt.Columns.Add("DoanhThu", typeof(double));

            foreach (var item in data)
            {
                dt.Rows.Add(item.Ngay, item.DoanhThu);
            }

            chart1.Series.Clear(); // Xóa các series cũ

            Series barSeries = new Series
            {
                Name = "Doanh Thu",
                Color = System.Drawing.Color.FromArgb(167,62,20),
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Column // Thay đổi loại biểu đồ thành cột
            };

            // Thêm dữ liệu vào series
            foreach (DataRow row in dt.Rows)
            {
                barSeries.Points.AddXY(row["Ngay"], row["DoanhThu"]);
            }

            chart1.Series.Add(barSeries);
            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Doanh Thu";
        }
        void thongKeMonAn(DateTime startDate, DateTime endDate)
        {
            DataTable dt = new DataTable();
            var data = hoaDonBLL.thongKeMonAn(startDate, endDate);

            // Đảm bảo rằng data không phải là null và có dữ liệu
            if (data != null)
            {
                dt.Columns.Add("MonAn", typeof(string));
                dt.Columns.Add("SoLuong", typeof(int));

                foreach (var item in data)
                {
                    // Kiểm tra item có dữ liệu không
                    if (item != null)
                    {
                        dt.Rows.Add(item.TenMonAn, item.TongSoLuong);
                    }
                }
            }

            chart1.Series.Clear(); // Xóa các series cũ

            Series barSeries = new Series
            {
                Name = "Doanh Thu",
                Color = System.Drawing.Color.FromArgb(167, 62, 20),
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Column // Thay đổi loại biểu đồ thành cột
            };

            // Thêm dữ liệu vào series
            foreach (DataRow row in dt.Rows)
            {
                barSeries.Points.AddXY(row["MonAn"], row["SoLuong"]);
            }

            chart1.Series.Add(barSeries);

            // Đảm bảo rằng có ít nhất một ChartArea
            if (chart1.ChartAreas.Count > 0)
            {
                chart1.ChartAreas[0].AxisX.Title = "Món ăn";
                chart1.ChartAreas[0].AxisY.Title = "Số lượng";
            }
            else
            {
                MessageBox.Show("Không có ChartArea nào trong biểu đồ.");
            }
        }
        void loadCmB()
        {
            string[] listValue =
            {
                "Doanh thu",
                "Món ăn"
            };
            comboBox1.Items.AddRange(listValue);
            comboBox1.SelectedIndex = 0;
        }
    }
}
