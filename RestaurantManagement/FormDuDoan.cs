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
            DateTime startDate = dateTimePicker1.Value;  // Ngày bắt đầu
            DateTime endDate = dateTimePicker2.Value;    // Ngày kết thúc

            // Tạo một danh sách các ngày giữa startDate và endDate
            List<DateTime> dateRange = new List<DateTime>();
            for (DateTime dt = startDate; dt <= endDate; dt = dt.AddDays(1))
            {
                dateRange.Add(dt); // Thêm từng ngày vào danh sách
            }

            // Tạo các mảng để lưu giá trị dự đoán (yLine)
            double[] yLine = new double[dateRange.Count];

            // Lặp qua các ngày trong mảng và tính toán giá trị cho yLine
            for (int i = 0; i < dateRange.Count; i++)
            {
                DateTime dt = dateRange[i]; // Lấy doanh thu cho ngày dt
                yLine[i] = Math.Round(tt.predicted(dt),0); // Lấy giá trị dự đoán cho ngày dt
            }

            // Xóa tất cả các chuỗi hiện có trên biểu đồ
            chart1.Series.Clear();

            // Thêm biểu đồ đường
            Series lineSeries = new Series
            {
                Name = "Dữ liệu Dự đoán",
                Color = System.Drawing.Color.Teal,
                ChartType = SeriesChartType.Line,
                BorderWidth = 3, // Độ dày đường
                IsValueShownAsLabel = true // Hiển thị nhãn trên các điểm dữ liệu
            };

            // Thêm điểm dữ liệu cho biểu đồ đường
            for (int i = 0; i < dateRange.Count; i++)
            {
                lineSeries.Points.AddXY(dateRange[i], yLine[i]);
            }

            chart1.Series.Add(lineSeries);

            // Thiết lập tiêu đề biểu đồ
            chart1.Titles.Clear();
            chart1.Titles.Add("Biểu đồ Dự đoán Doanh thu");
            chart1.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold);

            // Thiết lập tiêu đề trục
            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Giá trị Dự đoán";
            chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 12);
            chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 12);

            // Thêm lưới cho trục
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // Tùy chỉnh font và màu sắc cho nhãn
            foreach (var point in lineSeries.Points)
            {
                point.LabelForeColor = System.Drawing.Color.Black;
                point.Font = new Font("Arial", 10);
            }
        }
    }
}
