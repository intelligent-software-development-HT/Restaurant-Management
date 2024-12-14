using Accord.Statistics.Analysis;
using Accord.Statistics.Models.Regression.Linear;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThuatToan
    {
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        MultipleLinearRegression linearRegression = new MultipleLinearRegression(); 
        public void trainModel()
        {
            var data = hoaDonBLL.getDT();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Thu", typeof(double));
            dataTable.Columns.Add("Thang", typeof(double));
            dataTable.Columns.Add("Nam", typeof(double));
            dataTable.Columns.Add("DoanhThu", typeof(double));
            foreach (var i in data)
            {
                dataTable.Rows.Add(i.Thu, i.Thang, i.Nam, i.DoanhThu);
            }
            double[][] features = new double[dataTable.Rows.Count][];
            double[] revenue = new double[dataTable.Rows.Count];

            // Lấy dữ liệu từ DataTable vào các mảng
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                features[i] = new double[]
                {
            Convert.ToDouble(dataTable.Rows[i]["Thu"]),
            Convert.ToDouble(dataTable.Rows[i]["Thang"]),
            Convert.ToDouble(dataTable.Rows[i]["Nam"])
                };

                revenue[i] = Convert.ToDouble(dataTable.Rows[i]["DoanhThu"]);
            }
            var mlra = new MultipleLinearRegressionAnalysis(intercept: true)
            {
                Inputs = new[] { "Thu", "Ngay", "Thang", "Nam" }, // Không cần Codification ở đây
                Output = "DoanhThu"
            };

            mlra.OrdinaryLeastSquares.IsRobust = true;

            linearRegression = mlra.Learn(features, revenue);

            double predicted = mlra.Transform(features[0]);
            double r2 = mlra.RSquared;
        }
        public double predicted(DateTime dt)
        {
            double thu = (int)dt.DayOfWeek == 0 ? 7 : (int)dt.DayOfWeek;  // Thứ 7 là 7, không phải 0

            // Lấy số tháng (1 đến 12)
            double thang = dt.Month;

            // Lấy năm (chuyển đổi thành double)
            double nam = dt.Year;

            // Đưa vào mảng double[]
            double[] dateArray = { thu, thang, nam };
            double predict = linearRegression.Transform(dateArray);
            return predict;
        }
    }
}
