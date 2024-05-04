using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avion
{
   public enum  Culoarea
    {
        nedefinit=0,
        albastru=1,
        galben=2,
        alb=3,
        turcoaz=4,
        mov=5,
        negru=6,
        verde=7,
        rosu=8,
        gri=9,
        violet=10,
        visiniu=11,
        maro=12,
        portocaliu=13,
        roz=14,
        aurie=15,
        GriAlb=16,
        AlbastruVerde=17

    }
    public enum TipAvion
    {
        Nedefinit=0,
        Civil=1,
        Comercial=2,
        Experimental=3,
        Militar=4
    }
    [Flags]
    public enum Specializarea
    {
        nedefinit=0,
        civil=1,
        comercial=2,
        militar=4,
        experimental=8,
        cargo=16,
        de_afacere=32,
        de_antrenament=64,
        de_patrulare_marina=128,
        de_recunoastere_si_supraveghere=256,
        de_cautare_si_salvare=512            
    }
}
