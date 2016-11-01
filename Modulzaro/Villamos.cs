using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro
{
    class Villamos : Kotottpalyas
    {
        public bool EgybeNyitott { get; set; }


        public Villamos(string nev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama, int sinszelesseg, Aramellatas aramellatas, bool egybeNyitott) : base(nev, azonosito, futottKm, ajtokSzama, ferohelyekSzama, sinszelesseg, aramellatas)
        {
            EgybeNyitott = egybeNyitott;
        }
    }

    
}