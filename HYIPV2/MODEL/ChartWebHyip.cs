using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
   public  class ChartWebHyip
    {
        private int _MaWeb;

        public int MaWeb
        {
            get { return _MaWeb; }
            set { _MaWeb = value; }
        }
        private string _today;

        public string Today
        {
            get { return _today; }
            set { _today = value; }
        }

        private float _totaldeposit;

        public float TotalDeposit
        {
            get { return _totaldeposit; }
            set { _totaldeposit = value; }
        }

        private float _totalwithdraw;

        public float TotalWithdraw
        {
            get { return _totalwithdraw; }
            set { _totalwithdraw = value; }
        }
        
        
    }
}
