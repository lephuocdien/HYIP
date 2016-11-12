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
using MODEL;
using System.Data.Sql;
using System.Net;
using System.IO;
using System.Globalization;

namespace GUI
{
    public partial class Invest : Form
    {
        public Form1 p_form;
        public bool validateTextbox_rcb;
        public bool validateTextbox_dep;
        public Invest(Form1 p)
        {
            InitializeComponent();
            p_form = p;
        }

        private void Invest_Load(object sender, EventArgs e)
        {
            BUS_MONITOR buss = new BUS_MONITOR();
            BUS_STATUSS busstt = new BUS_STATUSS();
            DataTable dtMon = new DataTable();
            DataTable dtStatus = new DataTable();
            dtMon.Load(buss.GetMonitor());
            dtStatus.Load(busstt.GetStatus());

            //
            comboBox_monitor.DataSource = dtMon;
            comboBox_status.DataSource = dtStatus;
            comboBox_monitor.ValueMember = "ID";
            comboBox_monitor.DisplayMember = "NameMonitor";
            comboBox_status.ValueMember = "ID";
            comboBox_status.DisplayMember = "NameStatus";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validateTextbox_dep && validateTextbox_rcb && textBox_name.Text!="")
            {
                errorProvider1.Clear();
                //model web
                WEBHYIPMODEL web = new WEBHYIPMODEL();
                web.Name = textBox_name.Text;
                web.Deposit = Convert.ToInt32(textBox_dep.Text);
                web.DateJoin = dateTimePicker_timejoin.Value.ToString("MM-dd-yyyy HH:mm:ss.fff");
                web.Status = (int)comboBox_status.SelectedValue;
                web.Monitor = (int)comboBox_monitor.SelectedValue;
                web.RCB = float.Parse(textBox_rcb.Text);
                //call connector
                BUS_WEBHYIP buss = new BUS_WEBHYIP();
                int result =  buss.InsertWEBHYIP(web);
                if (result != 0)
                {

                    //truy van lay ra id web vua add vao
                    //result chinh la ID cua web moi vua tao
                    //  UpdateWebChart(result, web.Name, web.DateJoin);
                    MessageBox.Show("Success . Please add this web on tracking databse !");

                    //TrackingHYIPDatabase frm = new TrackingHYIPDatabase();
                    //frm.ShowDialog();


                    p_form.LoadData("PAYING");
                     this.Close();

                }
            }else
            {
                MessageBox.Show("Check again data input ");
            }
        }

        private void textBox_dep_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox_dep.Text);
                validateTextbox_dep = true;
                errorProvider1.SetError(textBox_dep, "");
            }
            catch (Exception)
            {
                validateTextbox_dep = false;
                errorProvider1.SetError(textBox_dep,"Error");
            }
        }

        private void textBox_rcb_Leave(object sender, EventArgs e)
        {
            try
            {
                float.Parse(textBox_rcb.Text);
                validateTextbox_rcb = true;
                errorProvider1.SetError(textBox_rcb, "");

            }
            catch (Exception)
            {
                validateTextbox_rcb = false;
                errorProvider1.SetError(textBox_rcb, "Error");
            }
        }
    }
}
