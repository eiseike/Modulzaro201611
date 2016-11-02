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


        public Villamos(string gyartoNev, string azonosito, int futottKm, int ajtokSzama, int ferohelyekSzama, int sinszelesseg, AramellatasTipusok aramellatasTipusok, bool egybeNyitott) : base(gyartoNev, azonosito, futottKm, ajtokSzama, ferohelyekSzama, sinszelesseg, aramellatasTipusok)
        {
            EgybeNyitott = egybeNyitott;
        }
    }

    
}