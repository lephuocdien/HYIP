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
using System.Data.SqlClient;

namespace GUI
{
    public partial class StatusUpdate : Form
    {
        Form1 _pform;
        STATUSS sta = null;
        public StatusUpdate(Form1 p, string name, int id)
        {
            InitializeComponent();
            sta = new STATUSS();
            sta.ID = id;
            sta.Name = name;
            _pform = p;
        }

        private void StatusUpdate_Load(object sender, EventArgs e)
        {
            label_name.Text = sta.Name;
            label_id.Text = sta.ID.ToString();
            //load 
            BUS_STATUSS buss = new BUS_STATUSS();
            DataTable dt = new DataTable();
            dt.Load(buss.GetStatus());
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "NameStatus";
            comboBox1.ValueMember = "ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BUS_WEBHYIP buss = new BUS_WEBHYIP();
            sta.ID = Convert.ToInt32(label_id.Text);
            sta.Name = comboBox1.SelectedValue.ToString();
            int result = buss.UpdateStatusWEBHYIP(sta);
            if (result != 0)
            {
                MessageBox.Show("Success!");
                this.Close();
                _pform.LoadData("PAYING");

            }
        }
    }
}
