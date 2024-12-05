using LibDAL;
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

namespace Nike_Shop_Management.GUI
{
    public partial class StatisticsManagement : Form
    {
        private DbContextDataContext db = new DbContextDataContext();
        private static Random random = new Random();
        public StatisticsManagement()
        {
            InitializeComponent();
        }

        private void StatisticsManagement_Load(object sender, EventArgs e)
        {
            loadTop5ProductRevenue();
        }
        private void loadTop5ProductRevenue()
        {
            var topProducts = db.user_order_products
                                .GroupBy(u => u.product_name)
                                .Select(g => new
                                {
                                    ProductName = g.Key,
                                    TotalPrice = g.Sum(x => x.price)
                                })
                                .OrderByDescending(x => x.TotalPrice)
                                .Take(5)
                                .ToList();


            if(topProducts.Count > 0)
            {
                chart1.Series.Clear();
                chart1.ChartAreas.Clear();

                chart1.Titles.Clear();
                chart1.Titles.Add("Biểu đồ 5 sản phẩm có doanh thu cao nhất");

                chart1.Titles[0].Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                chart1.Titles[0].ForeColor = Color.DarkBlue;
                chart1.Titles[0].Alignment = ContentAlignment.TopCenter;

                System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
                chartArea.Name = "MainArea";
                chart1.ChartAreas.Add(chartArea);

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                series.Name = "Series1";

                for (int i = 0; i < topProducts.Count; i++)
                {
                    var point = series.Points.AddXY(topProducts[i].ProductName, topProducts[i].TotalPrice);

                    series.Points[i].Label = topProducts[i].TotalPrice.ToString("C0"); // Hiển thị dưới dạng tiền tệ (VND, USD, ...)

                    series.Points[i].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));


                }

                series.ChartType = SeriesChartType.Column;

                chart1.Series.Add(series);
            }
        }
    }
}
