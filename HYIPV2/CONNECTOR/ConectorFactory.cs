using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using MODEL;
namespace CONECTOR
{
    public class ConectorFactory
    {
        // private string chuoi_ket_noi = "Data Source=LEDIEN-PC;Initial Catalog=HYIPDATABASE;Integrated Security=True";
        private string chuoi_ket_noi = @"Data Source=DESKTOP-5BP6LSU\SQLEXPRESS;Initial Catalog=HYIP;Integrated Security=True";
        private SqlCommand cmd = null;
        private SqlConnection conn = null;
        private SqlDataReader dr = null;
        public ConectorFactory()
        {
            conn = new SqlConnection(chuoi_ket_noi);
        }
        /// <summary>
        /// mo ket noi
        /// </summary>
        public void openConnection()
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// dong ket noi
        /// </summary>
        public void closeConnection()
        {
            try
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// lay du lieu 1 table 
        /// </summary>
        /// <param name="table"> ten table</param>
        /// <returns>tra ve sqldatareader</returns>
        public SqlDataReader getDataTable(string table)
        {
            try
            {
                string sql = "select * from " + table + " ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.closeConnection();
        }
        /// <summary>
        /// ham them du lieu vao bang WEBHYIP
        /// </summary>
        /// <param name="table">ten bang</param>
        /// <param name="web">doi tuong web </param>
        /// <returns> vi tri dong vua them thanh cong</returns>
        public int InsertTableWEBHYIP(WEBHYIPMODEL web)
        {
            try
            {
                string sql = " insert into WEBHYIP values('" + web.Name + "'," + web.Deposit + ",'" + web.DateJoin + "' ," + web.Status + "," + web.Monitor + "," + web.RCB + " ) SELECT SCOPE_IDENTITY()";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                this.closeConnection();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int InsertTableWithdrawHistory(WithdrawHistoryMODEL web)
        {
            try
            {
                string sql = "insert into WithdrawHistory values("+web.ID+","+web.WithDraw+",'"+web.DateWithdraw+"') ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                this.closeConnection();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader GetWithdrawHistoryID(int id)
        {

            try
            {
                string sql = "select Convert(varchar(10),CONVERT(date,DayWithdraw, 106), 103) DayWithdraw,Amount  from WithdrawHistory where MaWeb = " + id+" ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.closeConnection();
        }
        public int InsertTableTrackingWebHYIP(TrackingWebHYIP w)
        {
            try
            {
                string sql = " insert into TrackingWebHYIP values('" + w.Addrress + "'," + w.GetInformationAuto + ","+w.Good+") SELECT SCOPE_IDENTITY()";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                this.closeConnection();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public int BackupDatabase(string linkstorage)
        {
            string databasename = conn.Database.ToString();
            try
            {
                string sql = "BACKUP DATABASE ["+databasename+"] TO DISK='"+linkstorage+"\\" + "database" +"-" + DateTime.Now.ToString("yyyy-MM-dd--HH--mm-ss") +".bak' ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                this.closeConnection();
                return 1;
            }
            catch (Exception ex)
            {

                return  -1;
            }

        }
        public int InsertTableTrackingWebHYIPDATABASE(TrackingWebHYIPDatabase w)
        {
            try
            {
                string sql = " insert into TrackingWebHYIPDatabase values(" + w.MaWeb + "," + w.Deposit + "," + w.WithDraw + ",'" + w.Today + "')";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                this.closeConnection();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int GetIDFromNameInTracking(string name)
        {
            int ID = 0;
            try
            {
                string sql = "select ID from TrackingWebHYIP where AddressWeb='" + name + "'";
                // string sql = "select ID from TrackingWebHYIP where AddressWeb='web1'";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                ID = (int)cmd.ExecuteScalar();
                this.closeConnection();
                return ID;
            }
            catch (Exception)
            {


            }
            return ID;

        }

        public int InsertTableChartWeb(ChartWebHyip chart)
        {
            try
            {
                string sql = " insert into ChartWebHyip values(" + chart.MaWeb + ",'" + chart.Today + "'," + chart.TotalDeposit + "," + chart.TotalWithdraw + ") ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                this.closeConnection();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SqlDataReader GetDataWebHyip(string type)
        {

            try
            {
                string sql = "";
                if (type == "ALL")
                {
                    sql = "select w.ID, w.NameWeb,w.Deposit,w.DateJoin,mon.NameMonitor as Monitor,w.RCB,d.PercenttPaid,d.Progress as TotalEarn, s.NameStatus as Status from WEBHYIP w, RUNNING d , MONITOR mon , STATUSS s where w.ID = d.MaWeb and mon.ID = w.Monitor and  s.ID =w.Statuss";
                }
                else
                {
                   sql = "select w.ID, w.NameWeb,w.Deposit,w.DateJoin,mon.NameMonitor as Monitor,w.RCB,d.PercenttPaid,d.Progress as TotalEarn, s.NameStatus as Status from WEBHYIP w, RUNNING d , MONITOR mon , STATUSS s where w.ID = d.MaWeb and mon.ID = w.Monitor and  s.ID =w.Statuss and s.NameStatus='" + type+"'";
                }
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.closeConnection();
        }
        public SqlDataReader GetTrackingWebHYIPDatabase()
        {

            try
            {
                //                string sql = "select  trackdata.MaWeb,track.AddressWeb , trackdata.Deposit,trackdata.Withdraw ,trackdata.Deposit-trackdata.Withdraw as Profit ,Convert(varchar(10),CONVERT(date,trackdata.Today,106),103) as Date from TrackingWebHYIP track,TrackingWebHYIPDatabase trackdata,(select  track.AddressWeb,max(trackdata.Deposit) as Deposit from TrackingWebHYIP track, TrackingWebHYIPDatabase trackdata where track.ID = trackdata.MaWeb	group by track.AddressWeb) as tracktemp where track.ID	= trackdata.MaWeb and tracktemp.Deposit = trackdata.Deposit";
                //  string sql = "select  trackdata.MaWeb,track.AddressWeb , trackdata.Deposit,trackdata.Withdraw ,Convert(varchar(10),CONVERT(date,trackdata.Today, 106), 103) as Date from TrackingWebHYIP track,TrackingWebHYIPDatabase trackdata,(select track.AddressWeb,max(trackdata.Deposit) as Deposit from TrackingWebHYIP track, TrackingWebHYIPDatabase trackdata where track.ID = trackdata.MaWeb group by track.AddressWeb) as tracktemp where track.ID = trackdata.MaWeb and tracktemp.Deposit = trackdata.Deposit order by AddressWeb asc";
                string sql = "select  trackdata.MaWeb,track.AddressWeb , trackdata.Deposit,trackdata.Withdraw ,Convert(varchar(10),CONVERT(date,trackdata.Today, 106), 103) as Date from TrackingWebHYIP track,TrackingWebHYIPDatabase trackdata,(select track.AddressWeb,max(trackdata.Today) as TodayMax from TrackingWebHYIP track, TrackingWebHYIPDatabase trackdata	 where track.ID = trackdata.MaWeb group by track.AddressWeb) as tracktemp  where track.AddressWeb = tracktemp.AddressWeb  and trackdata.MaWeb = track.ID and tracktemp.TodayMax = trackdata.Today  and track.Good=1 order  by AddressWeb asc";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.closeConnection();
        }
        public SqlDataReader GetWebHeuristics(int value)
        {

            try
            {
                //string sql = "select t.AddressWeb from TrackingWebHYIP t,(select tracdata.MaWeb from TrackingWebHYIPDatabase tracdata,TrackingWebHYIP track where track.Good=1 and tracdata.MaWeb=track.ID  group by tracdata.MaWeb having count(tracdata.MaWeb) >=5)as result where t.ID = result.MaWeb";
                string sql = "select trac.ID ,trac.AddressWeb from TrackingWebHYIPDatabase trackdata, TrackingWebHYIP trac where trac.Good=1 and trac.ID = trackdata.MaWeb and DATEDIFF(day,trackdata.Today,GETDATE()) =0 and trackdata.Deposit -(	select trackdata1.Deposit	from TrackingWebHYIPDatabase trackdata1	where  DATEDIFF(day,trackdata1.Today,GETDATE()) =1 and trackdata1.MaWeb = trackdata.MaWeb) >" + value+" ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            this.closeConnection();
        }
        public SqlDataReader GetDataToAutoUpdate()
        {

            try
            {
                //string sql = "select  track.ID,track.AddressWeb from TrackingWebHYIP track,TrackingWebHYIPDatabase trackdata, (select  track.AddressWeb,max(trackdata.Deposit) as Deposit from TrackingWebHYIP track, TrackingWebHYIPDatabase trackdata where track.ID = trackdata.MaWeb	group by track.AddressWeb) as tracktemp where track.ID	= trackdata.MaWeb and tracktemp.Deposit = trackdata.Deposit and DATEDIFF(day,trackdata.Today,GETDATE()) >=1 and track.GetInformationAuto =1";
                string sql = "select trackdata.MaWeb,track.AddressWeb from TrackingWebHYIP track, TrackingWebHYIPDatabase trackdata where track.ID = trackdata.MaWeb and track.GetInformationAuto=1 and track.Good=1 group by trackdata.MaWeb,track.AddressWeb having DATEDIFF(day,max(trackdata.Today),GETDATE()) >=1";

                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader GetDataChartWebHYIP(int id)
        {

            try
            {
                string sql = "select Convert(varchar(10),CONVERT(date,Today,106),103),Deposit,Withdraw from TrackingWebHYIPDatabase where TrackingWebHYIPDatabase.MaWeb = " + id + " ORDER BY  CONVERT(DateTime, Today,101)  ASC";

                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                dr = cmd.ExecuteReader();

                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int TotalDeposit()
        {

            try
            {
                string sql = "select sum(Deposit) from WEBHYIP";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int total_dep = (int)cmd.ExecuteScalar();
                this.closeConnection();
                return total_dep;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public double TotalWithdraw()
        {

            try
            {
                string sql = "select sum(Progress) from RUNNING";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                double total_wihdraw = Convert.ToDouble(cmd.ExecuteScalar());
                this.closeConnection();
                return total_wihdraw;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader GetMonitor()
        {

            try
            {
                string sql = "select ID,NameMonitor from MONITOR";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                openConnection();
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public SqlDataReader GetSataus()
        {
            try
            {
                string sql = "select ID,NameStatus from STATUSS";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                openConnection();
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateRUNNING(RUNNING rn)
        {
            try
            {
                string sql = "update RUNNING set Progress=" + rn.Withdraw + ", PercenttPaid=" + rn.Percent + " where MaWeb=" + rn.ID + " ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int StatusWEBHYIP(STATUSS sta)
        {
            try
            {
                string sql = "update WEBHYIP set Statuss= " + sta.Name + " where WEBHYIP.ID =" + sta.ID + " ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ReDepositWEBHYIP(float rcb, int vl, int id)
        {
            try
            {
                string sql = "update WEBHYIP set Deposit= " + vl + ",RCB=WEBHYIP.RCB+" + rcb + " where WEBHYIP.ID =" + id + " ";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                return result;
                return 1;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public int InsertTableMONITOR(MONITOR mon)
        {
            try
            {
                string sql = " insert into MONITOR values('" + mon.Name + "')";
                cmd = new SqlCommand(sql);
                cmd.Connection = conn;
                this.openConnection();
                int result = cmd.ExecuteNonQuery();
                this.closeConnection();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
