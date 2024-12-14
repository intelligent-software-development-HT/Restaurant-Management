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
using Accord.Statistics.Analysis;
using Accord.Statistics.Models.Regression.Linear;
using BLL;
using DTO;
namespace RestaurantManagement
{
    public partial class FormDuDoan : Form
    {
        ThuatToan tt = new ThuatToan();
        public FormDuDoan()
        {
            InitializeComponent();
            this.Load += FormDuDoan_Load;
        }

        private void FormDuDoan_Load(object sender, EventArgs e)
        {
            tt.trainModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ DateTimePicker
            DateTime startDate = dateTimePicker1.Value;  // Ngày bắt đầu
            DateTime endDate = dateTimePicker2.Value;    // Ngày kết thúc

            // Tạo một danh sách các ngày giữa startDate và endDate
            List<DateTime> dateRange = new List<DateTime>();
            for (DateTime dt = startDate; dt <= endDate; dt = dt.AddDays(1))
            {
                dateRange.Add(dt); // Thêm từng ngày vào danh sách
            }

            // Tạo các mảng để lưu doanh thu (yBar) và giá trị dự đoán (yLine)
            double[] yLine = new double[dateRange.Count];

            // Lặp qua các ngày trong mảng và tính toán giá trị cho yBar và yLine
            for (int i = 0; i < dateRange.Count; i++)
            {
                DateTime dt = dateRange[i]; // Lấy doanh thu cho ngày dt
                yLine[i] = tt.predicted(dt);             // Lấy giá trị dự đoán cho ngày dt
            }

            // Xóa tất cả các chuỗi hiện có trên biểu đồ
            chart1.Series.Clear();


            // Thêm biểu đồ đường
            Series lineSeries = new Series
            {
                Name = "Line Data",
                Color = System.Drawing.Color.Red,
                ChartType = SeriesChartType.Line // Biểu đồ đường
            };

            // Thêm điểm dữ liệu cho biểu đồ đường
            for (int i = 0; i < dateRange.Count; i++)
            {
                lineSeries.Points.AddXY(dateRange[i], yLine[i]);
            }

            chart1.Series.Add(lineSeries);

            // Tiêu đề biểu đồ
            chart1.Titles.Add("Combined Bar and Line Chart");

            // Thiết lập tiêu đề trục
            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Doanh Thu / Dự Đoán";
        }
    }
}
