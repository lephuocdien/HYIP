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
    public class BUS_RUNNING
    {
        ConectorFactory conector = null;
        public BUS_RUNNING()
        {
            conector = new ConectorFactory();

        }
        public int UpdateRUNNING(RUNNING rn)
        {
            int result = 0;
            try
            {
                result = conector.UpdateRUNNING(rn);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
