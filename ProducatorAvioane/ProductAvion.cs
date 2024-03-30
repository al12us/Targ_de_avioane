using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ProducatorAvioane
{
    public class ProductAvion
    {    
        //auto-implementari pentru entitatea producatorul de avioane
        public string companie { get; set;}
        public string TaraOrigine { get; set; }
        public int AnInfiintare { get; set;}
        public int nrAngajati { get; set;}
        public string specializare { get; set;}
       public ProductAvion()
        {
            companie=TaraOrigine = string.Empty;
            AnInfiintare = 0;
            nrAngajati = 0;
            specializare = string.Empty;

        }
        public ProductAvion(string companie,string TaraOrigine,int AnInfiintare,int nrAngajati,string specializare)
        {
            this.companie = companie;
            this.TaraOrigine = TaraOrigine;
            this.AnInfiintare = AnInfiintare;
            this.nrAngajati = nrAngajati;
            this.specializare = specializare;
        }
        public string InfoProduct()
        {
            string afis = $"Compania:{companie}\n Tara de origine:{TaraOrigine}\n Infiintat din  {AnInfiintare} \n " +
                          $"Numar de angajati:{nrAngajati}\n Specilizarea:{specializare}";
            return afis;
        }
    }
}
