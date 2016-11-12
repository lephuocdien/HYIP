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
   public class BUS_WithdrawHistory
    {
        ConectorFactory conector = null;
        public BUS_WithdrawHistory()
        {
            conector = new ConectorFactory();

        }

        public int InsertWithdrawHistory(WithdrawHistoryMODEL with)
        {
            int result = 0;
            try
            {
                result = conector.InsertTableWithdrawHistory(with);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader GetWithdrawHistory(int  id)
        {
            SqlDataReader dr = null;
            try
            {
                dr = conector.GetWithdrawHistoryID(id);
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
