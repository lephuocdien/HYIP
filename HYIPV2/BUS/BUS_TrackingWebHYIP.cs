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
    public class BUS_TrackingWebHYIP
    {
        ConectorFactory conector = null;
        
        public BUS_TrackingWebHYIP()
        {
            conector = new ConectorFactory();
        } 

        public int InsertTrackingWebHYIP(TrackingWebHYIP tracking)
        {
            return conector.InsertTableTrackingWebHYIP(tracking);
        }

    }
}
