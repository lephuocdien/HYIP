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
    public class BUS_TrackingWebHYIPDatabase
    {
        ConectorFactory conector = null;

        public BUS_TrackingWebHYIPDatabase()
        {
            conector = new ConectorFactory();
        }
        public int InsertTrackingWebHYIPDatabase(TrackingWebHYIPDatabase trac)
        {
            return conector.InsertTableTrackingWebHYIPDATABASE(trac);
        }
        public SqlDataReader GetTrackingWebHYIPDatabase()
        {
            SqlDataReader dr = null;
            try
            {
                dr = conector.GetTrackingWebHYIPDatabase();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public SqlDataReader GetAutoUpdate()
        {
            SqlDataReader dr = null;
            try
            {
                dr = conector.GetDataToAutoUpdate();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int GetIDfromNameTracking(string name)
        {
            return conector.GetIDFromNameInTracking(name);
        }
    }
}
