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
    public class BUS_ChartWebHyip
    {
        ConectorFactory conector = null;
        public BUS_ChartWebHyip()
        {
            conector = new ConectorFactory();

        }
        public int InsertChartweb(ChartWebHyip web)
        {
            int result = 0;
            try
            {
                result = conector.InsertTableChartWeb(web);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader GetChartWEBHYIP(int id)
        {
            SqlDataReader dr = null;
            try
            {
                dr = conector.GetDataChartWebHYIP(id);
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
