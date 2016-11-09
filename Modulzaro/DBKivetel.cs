using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class DBKivetel : Exception
    {
        string eredetiUzenet;

        public string EredetiUzenet
        {
            get { return eredetiUzenet; }
            //set { eredetiUzenet = value; }
        }

        public DBKivetel(string _uzenet, string _eredetiUzenet) : base(_uzenet)
        {
            this.eredetiUzenet = _eredetiUzenet;
        }
    }
}
