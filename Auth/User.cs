using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskInc.Auth
{
    public class User
    {
        public string UserName { get;  }
        public int UserId { get; }

        public bool isLoggedIn;
        public User(string name,int id,bool loggedIn)
        {
            UserName = name;
            UserId = id;
            isLoggedIn =loggedIn ;
        }
    }
}
/*
 * 
 * // Set the chart type to Bar
chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

// Add data to the chart
chart1.Series[0].Points.AddXY("Category 1", 10);
chart1.Series[0].Points.AddXY("Category 2", 15);
chart1.Series[0].Points.AddXY("Category 3", 8);
 * 
 * 
 * // Set the chart type to Line
chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

// Add data to the chart
chart1.Series[0].Points.AddXY("January", 50);
chart1.Series[0].Points.AddXY("February", 80);
chart1.Series[0].Points.AddXY("March", 60);

// Set the chart type to Pie
chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

// Add data to the chart
chart1.Series[0].Points.AddXY("Category 1", 30);
chart1.Series[0].Points.AddXY("Category 2", 20);
chart1.Series[0].Points.AddXY("Category 3", 50);

// Set the chart type to Column
chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

// Add data to the chart
chart1.Series[0].Points.AddXY("Category 1", 10);
chart1.Series[0].Points.AddXY("Category 2", 15);
chart1.Series[0].Points.AddXY("Category 3", 8);

// Assuming you have a DataTable called "data"

// Set the data source for the chart control
chart1.DataSource = data;

// Set the X and Y values for the chart series
chart1.Series[0].XValueMember = "Category";
chart1.Series[0].YValueMembers = "Value";

// Set the chart type to Bar
chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

// Refresh the chart to display the data
chart1.DataBind();

 */
