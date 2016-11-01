using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class Busz : Jarmu
    {
        public bool Hibrid { get; set; }
        public bool Csuklos { get; set; }
        private int tankUrtartalom;

        public int TankUrtartalom
        {
            get
            {
                return tankUrtartalom;
            }

            set
            {
                if (value < 50)
                {
                    throw new ArgumentException("Az ürtartalomnak legalább 50 liternek kell lenni!");
                }
                else
                {
                    tankUrtartalom = value;
                }
            }
        }

        public Busz(string nev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama, int tankUrtartalom, bool hibrid, bool csuklos) : base(nev, azonosito, futottKm, ajtokSzama, ferohelyekSzama)
        {
            this.tankUrtartalom = tankUrtartalom;
            Hibrid = hibrid;
            Csuklos = csuklos;
        }
       
    }
}