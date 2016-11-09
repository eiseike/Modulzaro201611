using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class DBHiba
    {
        string uzenet;
        Jarmu hibas;

        public string Uzenet
        {
            get { return uzenet; }
            //set { uzenet = value; }
        }

        internal Jarmu Hibas
        {
            get { return hibas; }
            //set { hibas = value; }
        }

        public DBHiba(string _uzenet, Jarmu _hibas)
        {
            this.uzenet = _uzenet;
            this.hibas = _hibas;
        }

        public override string ToString()
        {
            //return base.ToString();
            return uzenet;
        }
    }
}
