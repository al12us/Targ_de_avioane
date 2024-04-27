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
       
        private List<ProductAvion> producatori;
       

        public AdministrareProducatorMemorie()
        {
            producatori = new List<ProductAvion>();
           
        }
        public void AddProducator(ProductAvion producatorul)
        {
           producatori.Add(producatorul);
        }
        public List<ProductAvion> GetProducator()
        {
        
            return producatori;

        }
        //Cautarea producatorului va fi facuta pe trei criterii(companie,tara de origine si specializare)
        public ProductAvion CautareProducator(string compania,string TaradeOrigine,Specializarea spec)
        {
            foreach(var producator in producatori)
            {

                if (producator.companie == compania && producator.TaraOrigine == TaradeOrigine && producator.specializare==spec)

                    return producator;
            }
            return null;

        }
    }
}
