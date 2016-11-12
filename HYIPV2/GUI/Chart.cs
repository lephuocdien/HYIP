using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Net;
using System.IO;
using BUS;
using MODEL;
using System.Globalization;

namespace GUI
{
    public partial class Chart : Form
    {
        public int _id;
        public string _url = "";
        public Chart(int ID, string url)
        {
            InitializeComponent();

            _id = ID;
            _url = url;

        }

        private void Chart_Load(object sender, EventArgs e)
        {
            BUS_ChartWebHyip buss = new BUS_ChartWebHyip();

            DataTable dt = new DataTable();
            SqlDataReader dr = null;

            try
            {
                dr = buss.GetChartWEBHYIP(_id);

            }
            catch (Exception ex)
            {

            }
            //  dataGridView1.DataSource = dt;

            ///
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            //  chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False;
            while (dr.Read())
            {
                try
                {
                    string dtnow = dr.GetValue(0).ToString();

                    double depositsum = dr.GetDouble(1);
                    double withdrawsum = dr.GetDouble(2);
                    chart1.Series["TotalDeposit"].Points.AddXY(dtnow, depositsum);
                    chart1.Series["TotalWithdraw"].Points.AddXY(dtnow, withdrawsum);
                    chart1.Series["Profit"].Points.AddXY(dtnow, depositsum - withdrawsum);

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }

        Point? prevPosition = null;

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.Location;
            if (prevPosition.HasValue && pos == prevPosition.Value)
                return;
            // tooltip.RemoveAll();
            prevPosition = pos;
            var results = chart1.HitTest(pos.X, pos.Y, false, ChartElementType.PlottingArea);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.PlottingArea)
                {
                    chart1.Series["TotalDeposit"].ToolTip = "$ #VALY"; ;
                    chart1.Series["TotalWithdraw"].ToolTip = "$ #VALY"; ;
                    chart1.Series["Profit"].ToolTip = "$ #VALY"; ;
                }
            }
        }
       
    }
}
