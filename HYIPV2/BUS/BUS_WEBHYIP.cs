using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MODEL;
using CONECTOR;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_WEBHYIP
    {
        ConectorFactory conector = null;
        public BUS_WEBHYIP()
        {
            conector = new ConectorFactory();

        }
        public SqlDataReader GetWEBHYIP(string type)
        {
            SqlDataReader dr = null;          
            try
            {
                dr = conector.GetDataWebHyip(type);               
                return dr;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
        }

        public SqlDataReader GetWEBHeuristics(int value)
        {
            SqlDataReader dr = null;
            try
            {
                dr = conector.GetWebHeuristics(value);
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public int TotalDeposit()
        {
            int total_dep = 0; 
            try
            {
                total_dep= conector.TotalDeposit();
                return total_dep;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public double TotalWithdraw()
        {
            
            double total_with = 0;
            try
            {
                total_with = conector.TotalWithdraw();
                return total_with;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
     
     
        public int InsertWEBHYIP(WEBHYIPMODEL web)
        {
            int result = 0;
            try
            {
                result = conector.InsertTableWEBHYIP(web);
                return result;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

       

        public int UpdateStatusWEBHYIP(STATUSS  sta)
        {
            int result = 0;
            try
            {
                result = conector.StatusWEBHYIP(sta);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateStatusWEBDEPOSIT(float rcb,int vl,int id)
        {
            int result = 0;
            try
            {
                result = conector.ReDepositWEBHYIP(rcb,vl,id);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int createbackupDatabase(string link)
        {
            int result = 0;
            try
            {
                result = conector.BackupDatabase(link);
                return result;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

       
    }
}
