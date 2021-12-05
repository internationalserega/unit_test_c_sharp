using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test_c_sharp
{
    class Figure
    {
        private bool colered = false;

        public bool Colored
        {
            get
            {
                return colered;
            }
            set
            {
                colered = value;
            }
        }
    }
}

