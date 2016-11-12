using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class WEBHYIPMODEL
    {
        public WEBHYIPMODEL()
        {
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int dep;

        public int Deposit
        {
            get { return dep; }
            set { dep = value; }
        }

        private string datejoin;

        public string DateJoin
        {
            get { return datejoin; }
            set { datejoin = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private int mon;

        public int Monitor
        {
            get { return mon; }
            set { mon = value; }
        }
        private float rcb;

        public float RCB
        {
            get { return rcb; }
            set { rcb = value; }
        }

       
        
        

    }
}
