using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    enum Aramellatas
    {
        Áramszedő,
        Sin
    }

    abstract class Kotottpalyas : Jarmu
    {
        private int sinszelesseg;
        private Aramellatas aramellatas;

        public int Sinszelesseg
        {
            get
            {
                return sinszelesseg;
            }

            set
            {
                if (value < 100)
                {
                    throw new ArgumentException("A sinszelesseg lagalább 100cm kell hogy legyen!");
                }
                else
                {
                    sinszelesseg = value;
                }
            }
        }

        internal Aramellatas Aramellatas
        {
            get
            {
                return aramellatas;
            }

            set
            {
                aramellatas = value;
            }
        }

        public Kotottpalyas(string nev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama, int sinszelesseg, Aramellatas aramellatas) : base(nev, azonosito, futottKm, ajtokSzama, ferohelyekSzama)
        {
            this.sinszelesseg = sinszelesseg;
            this.aramellatas = aramellatas;
        }

        public override float AktualisAr()
        {
            return (1 / FutottKm) * Sinszelesseg;
        }
    }
}