using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public  class TrackingWebHYIPDatabase
    {
        public TrackingWebHYIPDatabase()
        {

        }
        private int _maweb;

        public int MaWeb
        {
            get { return _maweb; }
            set { _maweb = value; }
        }
        private float _deposit;

        public float Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }

        private float _withdaw;

        public float WithDraw
        {
            get { return _withdaw; }
            set { _withdaw = value; }
        }

        private string _today;

        public string Today
        {
            get { return _today; }
            set { _today = value; }
        }

    }
}
