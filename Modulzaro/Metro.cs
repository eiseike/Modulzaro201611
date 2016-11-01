using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class Metro : Kotottpalyas
    {
        private int szerelveny;

        public int Szerelveny
        {
            get
            {
                return szerelveny;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("A szerelvények számának lagalább egynek kell lenni!");
                }
                else
                {
                    szerelveny = value;
                }
            }
        }

        public Metro(string nev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama, int sinszelesseg, Aramellatas aramellatas, int szerelveny) : base(nev, azonosito, futottKm, ajtokSzama, ferohelyekSzama, sinszelesseg, aramellatas)
        {
            this.szerelveny = szerelveny;
        }
    }
}