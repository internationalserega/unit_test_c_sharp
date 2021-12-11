using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubTests
{
    class RepositoriName
    {
        private string name;
        //private string header '';
        //private string footer '';

        public RepositoriName(string name)
        {
            this.name = name;
        }
        /*
        public RepositoriName(string name, string header, string footer)
        {
            this.name = name;
            this.header = header;
            this.footer = footer;
        }
        */

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
