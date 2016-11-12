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
using System.Globalization;
using System.Threading;
using System.Data.SqlClient;

namespace GUI
{
    public partial class Form1 : Form
    {
        public string lnk_storage = "";
        public string lnk_storage_restore = "";
        public Form1()
        {
            
            InitializeComponent();
          
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dataGridView_heuristics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_heuristics.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        public int excuteAutoUpdate(int id, string address)
        {
            TrackingWebHYIPDatabase trackwebdata = new TrackingWebHYIPDatabase();
            BUS_TrackingWebHYIPDatabase bussdata = new BUS_TrackingWebHYIPDatabase();
            GetDataWeb getdt = new GetDataWeb();
            Tuple<string, string> info = getdt.GetDepositAndWithdraw(address);
            if (info.Item1!="")
            {
                string timenow = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss.fff");
                trackwebdata.MaWeb = id;
                trackwebdata.Deposit = float.Parse(info.Item1.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                trackwebdata.WithDraw = float.Parse(info.Item2.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                trackwebdata.Today = timenow;

                //insert TrackingWebHYIPDatabase
                int result = bussdata.InsertTrackingWebHYIPDatabase(trackwebdata);
                return result;
            }
            return -1;

        }
        
        private Task ProcessData(List< Tuple<int,string> > list,IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalprogress = list.Count;
            var progressreport = new ProgressReport();
            return Task.Run(()=> {
                for(int i=0;i<totalprogress;i++)
                {
                    int tep = i;
                    Tuple<int, string> temp = list[tep];
                    int id = temp.Item1;
                    string address = temp.Item2;
                    // label_autoupdate.Text = string.Format("Processing ...{0}",address);
                    
                    label_webtracking.Text = string.Format("Processing...{0}", address);
                    excuteAutoUpdate(id, address);
                    progressreport.PercentComplete = (tep + 1) * 100 / totalprogress;
                    progress.Report(progressreport);
                    Thread.Sleep(10);
                }
                progressBar1.Visible = false;
                label_webtracking.Visible = false;
                // LoadDataTracking();

            });

        }
        public void LoadDataTracking()
        {
            BUS_TrackingWebHYIPDatabase buss = new BUS_TrackingWebHYIPDatabase();
            DataTable dt = new DataTable();
            try
            {
               
                // (dataGridView1.BindingContext[dataGridView1.DataSource] as CurrencyManager).Refresh();
                dt.Load(buss.GetTrackingWebHYIPDatabase());
               
                dataGridView2.DataSource = dt;
                
               // dataGridView2.Columns[0].Visible = false;
                //
                //label_dep.Text = buss.TotalDeposit().ToString();
                //label_with.Text = buss.TotalWithdraw().ToString();

                // dataGridView1.Columns[2].Visible = false;
                dataGridView2.Columns["MaWeb"].Visible = false;
            }
            catch (Exception ex)
            {

            }
            label_total_tracking.Visible = true;
            label_total_tracking.Text = string.Format("Total web are tracking:{0}", dataGridView2.Rows.Count-1);
            for (int r = 0; r < dataGridView2.Rows.Count - 1; r++)
            {
                DataGridViewRow myrow = dataGridView2.Rows[r];
                string dttime_str = myrow.Cells["Date"].Value.ToString();
                DateTime dttime_datetime = DateTime.Parse(dttime_str);
                DateTime now = DateTime.Now;

                TimeSpan diff = now - dttime_datetime;

                string mw = myrow.Cells["MaWeb"].Value.ToString();
                if (diff.TotalDays >= 1)
                {
                    //myrow.DefaultCellStyle.BackColor = Color.Red;
                    myrow.Cells["Date"].Style.BackColor = Color.Red;
                    DataGridViewButtonCell btncell = new DataGridViewButtonCell();

                    myrow.Cells["dep"] = btncell;
                }

            }
        }
        public void LoadWebHeuristics(int value)
        {
            try
            {

                BUS_WEBHYIP buss = new BUS_WEBHYIP();
                DataTable dt = new DataTable();
                dt.Load(buss.GetWEBHeuristics(value));
                //foreach (DataRow row in dt.Rows)
                //{
                //    ListViewItem item = new ListViewItem(row[0].ToString());
                //    for(int i =0;i< dt.Columns.Count;i++)
                //    {
                //        item.SubItems.Add(row[i].ToString());
                //    }
                //    listView_heuristic.Items.Add(item);
                //}
                dataGridView_heuristics.DataSource = dt;
                label_heu_total.Text = string.Format("Total:{0}", dataGridView_heuristics.Rows.Count - 1);
                dataGridView_heuristics.Columns["ID"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void LoadData(string type)
        {
            BUS_WEBHYIP buss = new BUS_WEBHYIP();
            DataTable dt = new DataTable();
            
            
            try
            {
               // (dataGridView1.BindingContext[dataGridView1.DataSource] as CurrencyManager).Refresh();
                dt.Load(buss.GetWEBHYIP(type));
                dataGridView1.DataSource = dt;
                //
                label_dep.Text = buss.TotalDeposit().ToString();
                label_with.Text = buss.TotalWithdraw().ToString();
                /*
                if(! dataGridView1.Columns.Contains("cbname"))
                {
                    DataGridViewComboBoxColumn comb = new DataGridViewComboBoxColumn();
                    comb.HeaderText = "nnamme";
                    comb.Name = "cbname";
                    ArrayList row = new ArrayList();
                    foreach (DataRow dr in dt.Rows)
                    {
                        string h = dr["ID"].ToString();
                        row.Add(dr["ID"].ToString());
                    }
                    comb.Items.AddRange(row.ToArray());

                    dataGridView1.Columns.Add(comb);
                }

                */
                dataGridView1.Columns["ID"].Visible = false;

                //
                int count = dataGridView1.Rows.Count;
                for (int r = 0; r < count ; r++)
                {
                    DataGridViewRow row = dataGridView1.Rows[r];
                    string name = row.Cells["Status"].Value.ToString();
                    if(name=="SCAM")
                    {
                        row.Cells["Status"].Style.BackColor = Color.Red;
                    }
                   
                }


            }
            catch (Exception ex)
            {

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           // var checkedButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            LoadData("PAYING");
            LoadDataTracking();
            LoadWebHeuristics(3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var checkedButton = groupBox_invest.Controls.OfType<RadioButton>()  .FirstOrDefault(r => r.Checked);
            Invest frm = new Invest(this);
            frm.ShowDialog();
          
        }

      

        private void radioButton_invest_paying_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_invest_paying.Checked == true)
                LoadData("PAYING");

        }

        private void radioButton_trac_all_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton_invest_all_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_invest_all.Checked == true)
                LoadData("ALL");
        }

        private void radioButton_invest_scam_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_invest_scam.Checked == true)
                LoadData("SCAM");
        }
        bool CheckNameExits(string newlink,DataGridView dtg)
        {
            bool result = false;
            int count = dtg.Rows.Count;
            for (int r = 0;r<count-2;r++)
            {
                DataGridViewRow row = dtg.Rows[r];
                string name = row.Cells["name"].Value.ToString();
                if(String.Equals(newlink,name) )
                {
                    row.Cells["name"].Style.BackColor = Color.Red;
                    return true;
                }
            }

            return result;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
               if( dataGridView1.Columns[e.ColumnIndex].Name == "dailyprofit")
               {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string Name = selectedRow.Cells[3].Value.ToString();
                    string ID = selectedRow.Cells[2].Value.ToString();
                    float paid = float.Parse((selectedRow.Cells[9].Value.ToString()));
                    int dep = Convert.ToInt32(selectedRow.Cells[4].Value);
                    string stt = selectedRow.Cells[10].Value.ToString();
                    if (stt == "PAYING")
                    {

                        Withdraw frm = new Withdraw(this, Name, ID, paid, dep);
                        frm.ShowDialog();
                    }
                    else if(stt == "NOT JOIN")
                    {
                        MessageBox.Show("NOT JOIN");
                    }
                    else
                    {
                        MessageBox.Show("SCAM");
                    }
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "updatestatus")
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string Name = selectedRow.Cells[3].Value.ToString();
                    int ID = Convert.ToInt32(selectedRow.Cells[2].Value.ToString());
                    StatusUpdate frm = new StatusUpdate(this, Name, ID);
                    frm.ShowDialog();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TotalEarn")
            {
                //
                richTextBox1.Clear();
                String template ="DateWithdraw:{0}  Amount:{1} \n";
                      
                BUS_WithdrawHistory buswithdrawHis = new BUS_WithdrawHistory();
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                SqlDataReader rdr = buswithdrawHis.GetWithdrawHistory(Convert.ToInt32(selectedRow.Cells[2].Value.ToString()));
                
                while (rdr.Read())
                {
                    string daywi = rdr["DayWithdraw"].ToString();
                    float amount = float.Parse( rdr["Amount"].ToString());

                    richTextBox1.Text += String.Format(template, daywi, amount);

                }//
            }


        }

        private  async void button_update_tracking_Click(object sender, EventArgs e)
        {
            
             List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            BUS_TrackingWebHYIPDatabase buss = new BUS_TrackingWebHYIPDatabase();
            DataTable dt = new DataTable();
            try
            {
                dt.Load(buss.GetAutoUpdate());

            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (dt.Rows.Count > 0)
            {
              //  groupBox_autoupdate.Visible = true;
                progressBar1.Visible = true;
                label_webtracking.Visible = true;
                foreach (DataRow dr in dt.Rows)
                {
                    int v1 = dr.Field<int>(0);
                    string v2 = dr.Field<string>(1);
                    list.Add(Tuple.Create(v1,v2));
                }
                var progress = new Progress<ProgressReport>();
                progress.ProgressChanged += (o, report) =>
                {
                    progressBar1.Value = report.PercentComplete;
                    progressBar1.Update();
                };
                await ProcessData(list, progress);
                LoadDataTracking();
            }
            else
            {
                MessageBox.Show("Updated !");
            }
           
           

        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name != "")
            {


                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                string Name = selectedRow.Cells["name"].Value.ToString();
                if (Name != "")
                {
                    bool checkname =  CheckNameExits(Name, dataGridView2);
                    if (checkname)
                    {
                        MessageBox.Show("Name Exits");
                        selectedRow.Cells["name"].Value = "";

                    }
                    else
                    {
                        //insert vo TrackingWebHYIP
                        BUS_TrackingWebHYIP buss = new BUS_TrackingWebHYIP();
                        BUS_TrackingWebHYIPDatabase bussdata = new BUS_TrackingWebHYIPDatabase();

                        TrackingWebHYIP tracweb = new TrackingWebHYIP();
                        TrackingWebHYIPDatabase trackwebdata = new TrackingWebHYIPDatabase();
                        tracweb.Addrress = Name;
                        GetDataWeb getdt = new GetDataWeb();
                        Tuple<string, string> info = getdt.GetDepositAndWithdraw(Name);
                        if (info.Item1.ToString() == "cloudfare")
                        {
                            DialogResult result = MessageBox.Show("This webste use Cloudfare . Add manual");
                            if (result == DialogResult.OK)
                            {
                                AddWebTracking frm = new AddWebTracking(this);
                                frm.ShowDialog();
                            }
                        }
                        else if (info.Item1.ToString() == "Something Wrong" || info.Item1.ToString() == "" || info.Item2.ToString() == "")
                        {
                            DialogResult result = MessageBox.Show("Something wrong.Add manual");
                            if (result == DialogResult.OK)
                            {
                                AddWebTracking frm = new AddWebTracking(this);
                                frm.ShowDialog();
                            }
                        }
                        else
                        {


                            //Id web vua add vao co so du lieu
                            tracweb.GetInformationAuto = 1;
                            tracweb.Good = 1;
                            int ID = buss.InsertTrackingWebHYIP(tracweb);
                            //lay dep va with trang web


                            string timenow = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss.fff");
                            trackwebdata.MaWeb = ID;
                            trackwebdata.Deposit = float.Parse(info.Item1.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                            trackwebdata.WithDraw = float.Parse(info.Item2.ToString(), CultureInfo.InvariantCulture.NumberFormat);
                            trackwebdata.Today = timenow;

                            //insert TrackingWebHYIPDatabase
                            int result = bussdata.InsertTrackingWebHYIPDatabase(trackwebdata);
                            if (result != 0)
                            {

                                LoadDataTracking();
                            }
                        }




                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid[e.ColumnIndex, e.RowIndex].GetType() == typeof(DataGridViewButtonCell) && e.RowIndex >= 0)
            {


                if (dataGridView2.Columns[e.ColumnIndex].Name == "dep")
                {
                    int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                    int ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                    float dep = float.Parse(selectedRow.Cells["dep"].Value.ToString());
                    float withdr = float.Parse(selectedRow.Cells["with"].Value.ToString());
                    UpdateDepositWithdrawTracking frm = new UpdateDepositWithdrawTracking(this, ID,dep, withdr);
                    frm.ShowDialog();
                  

                }

            }
            else if (dataGridView2.Columns[e.ColumnIndex].Name == "Date")
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                int ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                string link = selectedRow.Cells[1].Value.ToString();
                Chart frm = new Chart(ID, link);
                frm.ShowDialog();

            }
            else if (dataGridView2.Columns[e.ColumnIndex].Name == "name")
            {
                //open browser

                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];
                int ID = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                string link = selectedRow.Cells[1].Value.ToString();
                System.Diagnostics.Process.Start(link);
            }
        }

        private void button_trac_Click(object sender, EventArgs e)
        {
            AddWebTracking frm = new AddWebTracking(this);
            frm.ShowDialog();
        }
        

        private void button_bk_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = @"D:\Practice\C#\HYIP\BK_Database";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                lnk_storage = dlg.SelectedPath;
                BUS_WEBHYIP buss = new BUS_WEBHYIP();
                int vl = buss.createbackupDatabase(lnk_storage);
                if(vl>0)
                {
                    MessageBox.Show("Ok");
                }
            }
            //

        }

        private void button_restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER databse backup files|*.bak";
            dlg.Title = "Database Restore";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                lnk_storage_restore = dlg.FileName;
            }

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            int vl = Convert.ToInt32(textBox_heuritic_value.Text);
            LoadWebHeuristics(vl);
        }

        private void dataGridView_heuristics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView_heuristics.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_heuristics.Rows[selectedrowindex];
            int ID = Convert.ToInt32(selectedRow.Cells["ID"].Value.ToString());
            string link = selectedRow.Cells[1].Value.ToString();
            Chart frm = new Chart(ID, link);
            frm.ShowDialog();
        }
    }
}
