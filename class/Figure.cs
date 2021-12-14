using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoriTest
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

