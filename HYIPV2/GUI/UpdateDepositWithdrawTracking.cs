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
namespace GUI
{
    public partial class UpdateDepositWithdrawTracking : Form
    {
        public Form1 p;
        public int ID;
        public bool validate_textbx_dep;
        public bool validate_textbx_with;
        public float value_dep;
        public float value_with;
        public UpdateDepositWithdrawTracking(Form1 _p, int _id,float v1,float v2)
        {
            InitializeComponent();
            p = _p;
            ID = _id;
            value_dep = v1;
            value_with = v2;
        }

        private void UpdateDepositWithdrawTracking_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(textBox_dep.Text);
               validate_textbx_dep = true;
                errorProvider1.SetError(textBox_dep, "");
            }
            catch (Exception)
            {

                validate_textbx_dep = false;
                errorProvider1.SetError(textBox_dep, "error");

            }
            try
            {
                float.Parse(textBox_with.Text);
                validate_textbx_with = true;
                errorProvider1.SetError(textBox_with, "");
            }
            catch (Exception)
            {

                validate_textbx_with = false;
                errorProvider1.SetError(textBox_with, "error");
            }
            if(validate_textbx_dep && validate_textbx_with)
            {
                errorProvider1.Clear();
                float dep = float.Parse(textBox_dep.Text);
                float withdraw = float.Parse(textBox_with.Text);
                string timenow = DateTime.Now.ToString();
                //insert TrackingWebHYIPDatabase
                BUS_TrackingWebHYIPDatabase buss = new BUS_TrackingWebHYIPDatabase();
                TrackingWebHYIPDatabase model = new TrackingWebHYIPDatabase();
                model.MaWeb = ID;
                model.Deposit = dep;
                model.WithDraw = withdraw;
                model.Today = timenow;
                int result = buss.InsertTrackingWebHYIPDatabase(model);
                if (result != 0)
                {
                    MessageBox.Show("OK");
                    this.Close();
                    p.LoadDataTracking();
                }
            }else
            {
                MessageBox.Show("Check again !");
            }
        }

        private void textBox_dep_Leave(object sender, EventArgs e)
        {
           
                
           
        }

        private void textBox_with_Leave(object sender, EventArgs e)
        {
            
                try
                {
                    float.Parse(textBox_with.Text);
                    validate_textbx_with = true;
                    errorProvider1.SetError(textBox_with, "");
                }
                catch (Exception)
                {

                    validate_textbx_with = false;
                    errorProvider1.SetError(textBox_with, "error");
                }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_dep.Text = value_dep.ToString();
            textBox_with.Text = value_with.ToString();
        }
    }
}
