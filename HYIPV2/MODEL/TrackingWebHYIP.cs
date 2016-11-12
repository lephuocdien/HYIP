using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class TrackingWebHYIP
    {
        public TrackingWebHYIP()
        {

        }
        private string _address;

        public string Addrress
        {
            get { return _address; }
            set { _address = value; }
        }
        private int _GetInformationAuto;

        public int GetInformationAuto
        {
            get { return _GetInformationAuto; }
            set { _GetInformationAuto = value; }
        }
        private int isGood;

        public int Good
        {
            get { return isGood; }
            set { isGood = value; }
        }


    }
}
