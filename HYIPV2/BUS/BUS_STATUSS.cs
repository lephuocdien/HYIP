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
    public class BUS_STATUSS
    {
        ConectorFactory conector = null;
        public BUS_STATUSS()
        {
            conector = new ConectorFactory();

        }
        public SqlDataReader GetStatus()
        {
            SqlDataReader dr = null;
            try
            {
                dr = conector.GetSataus();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
