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
    public class BUS_MONITOR
    {
        ConectorFactory conector = null;
        public BUS_MONITOR()
        {
            conector = new ConectorFactory();

        }
        public SqlDataReader GetMonitor()
        {
            SqlDataReader dr = null;
            try
            {
                dr = conector.GetMonitor();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int InsertMonitor(MONITOR mon)
        {
            int result = 0;
            try
            {
                result = conector.InsertTableMONITOR(mon);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
