using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class WithdrawHistoryMODEL
    {
        public WithdrawHistoryMODEL()
        {
           
        }
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private float _withdraw;

        public float WithDraw
        {
            get { return _withdraw; }
            set { _withdraw = value; }
        }

        private string _dateWithdraw;

        public string DateWithdraw
        {
            get { return _dateWithdraw; }
            set { _dateWithdraw = value; }
        }

    }
}
