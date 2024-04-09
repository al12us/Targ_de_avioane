using Avion;
using ProducatorAvioane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niveldestocare_Date
{
    public class AdministrareProducatorMemorie
    {
        private const int NR_MAX_PRODUCATORI = 50;
        private ProductAvion[] producatori;
        private int nr_producatori;

        public AdministrareProducatorMemorie()
        {
            producatori = new ProductAvion[NR_MAX_PRODUCATORI];
            nr_producatori = 0;
        }
        public void AddProducator(ProductAvion producatorul)
        {
            producatori[nr_producatori] = producatorul;
            nr_producatori++;
        }
        public ProductAvion[] GetProducator(out int nr_producatori)
        {
            nr_producatori=this.nr_producatori;
            return producatori;

        }
        //Cautarea producatorului va fi facuta pe trei criterii(companie,tara de origine si specializare)
        public ProductAvion CautareProducator(string compania,string TaradeOrigine,Specializarea spec)
        {
            for(int i = 0; i < nr_producatori; i++)
            {

                if (producatori[i].companie == compania && producatori[i].TaraOrigine == TaradeOrigine && producatori[i].specializare==spec)

                    return producatori[i];
            }
            return null;

        }
    }
}
