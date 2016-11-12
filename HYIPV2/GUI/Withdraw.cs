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
    public partial class Withdraw : Form
    {
        Form1 _p_form;
        public int _deposit = 0;
        public float _paid = 0;
        public Withdraw(Form1 p, string name, string id, float paid, int dep)
        {
            InitializeComponent();
            textBox_name.Text = name;
            textBox_id.Text = id;
            _deposit = dep;
            _paid = paid;
            _p_form = p;
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RUNNING rn = new RUNNING();
            rn.ID = Convert.ToInt32(textBox_id.Text);
            float hasWithdraw = (float)_paid + float.Parse(textBox_withdraw.Text);
            decimal decimalValue = Math.Round((decimal)hasWithdraw, 2);
            rn.Withdraw = (float)decimalValue;
            int percent = (int)((hasWithdraw / _deposit) * 100);
            rn.Percent = percent;
            
            //
            BUS_RUNNING buss = new BUS_RUNNING();
            int result = buss.UpdateRUNNING(rn);
            if (result != 0)
            {
                //insert to WithdrawHistory
                WithdrawHistoryMODEL with = new WithdrawHistoryMODEL();
                with.ID = rn.ID;
                with.WithDraw = float.Parse(textBox_withdraw.Text);
                with.DateWithdraw = DateTime.Now.ToString();
                //
                BUS_WithdrawHistory busswith = new BUS_WithdrawHistory();
                int errorcode = busswith.InsertWithdrawHistory(with);
                if (errorcode != 0)
                {
                    MessageBox.Show("Success!");
                    this.Close();
                    _p_form.LoadData("PAYING");
                }
            }
        }

        private void btn_redep_Click(object sender, EventArgs e)
        {
            //
            BUS_WEBHYIP buss = new BUS_WEBHYIP();
            int id = Convert.ToInt32(textBox_id.Text);
            int vl = Convert.ToInt32(textBox1.Text);
            float rcb = float.Parse(textBox_rcb_re.Text);
            int result =  buss.UpdateStatusWEBDEPOSIT(rcb, vl + _deposit, id);
            if (result != 0)
            {
                RUNNING rn = new RUNNING();
                rn.ID = id;
                float hasWithdraw = (float)_paid + rcb;
                decimal decimalValue = Math.Round((decimal)hasWithdraw, 2);
                rn.Withdraw = (float)decimalValue;
                int percent = (int)((hasWithdraw / (vl+ _deposit)) * 100);
                rn.Percent = percent;

                //
                BUS_RUNNING bussr = new BUS_RUNNING();
                int resultr = bussr.UpdateRUNNING(rn);
                if (resultr != 0)
                {
                    MessageBox.Show("Success!");
                    this.Close();
                    _p_form.LoadData("PAYING");
                }
            }

          
        }
    }
}
