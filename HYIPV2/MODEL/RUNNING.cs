using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class RUNNING
    {
        public RUNNING()
        {

        }
        private int _percent;

        public int Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private float _with;

        public float Withdraw
        {
            get { return _with; }
            set { _with = value; }
        }

    }
}
