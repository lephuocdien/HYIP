using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MODEL;
using BUS;
using System.Globalization;

namespace GUI
{
    
    public partial class AddWebTracking : Form
    {
        public Form1 p_frm;
        public AddWebTracking(Form1 p)
        {
            InitializeComponent();
            p_frm = p;
        }

        private void AddWebTracking_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrackingWebHYIP tracweb = new TrackingWebHYIP();
            TrackingWebHYIPDatabase trackwebdata = new TrackingWebHYIPDatabase();
            BUS_TrackingWebHYIP buss = new BUS_TrackingWebHYIP();
            BUS_TrackingWebHYIPDatabase bussdata = new BUS_TrackingWebHYIPDatabase();

            //Id web vua add vao co so du lieu
            tracweb.GetInformationAuto = 0;
            tracweb.Addrress = textBox_addrress.Text;
            tracweb.Good = 1;
            int ID = buss.InsertTrackingWebHYIP(tracweb);
            //lay dep va with trang web


            string timenow = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss.fff");
            trackwebdata.MaWeb = ID;
            trackwebdata.Deposit = float.Parse(textBox_deposit.Text, CultureInfo.InvariantCulture.NumberFormat);
            trackwebdata.WithDraw = float.Parse(textBox_withdraw.Text, CultureInfo.InvariantCulture.NumberFormat);
            trackwebdata.Today = timenow;

            //insert TrackingWebHYIPDatabase
            int result = bussdata.InsertTrackingWebHYIPDatabase(trackwebdata);
            if (result != 0)
            {
                MessageBox.Show("OK");
                this.Close();
                p_frm.LoadDataTracking();
            }
        }
    }
}
