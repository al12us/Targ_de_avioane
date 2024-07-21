using Avion;
using ProducatorAvioane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niveldestocare_Date
{
    public class AdministrareProducatorMemorie:InterfaceProductPlane
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
        public ProductAvion CautareProducator(string compania,string TaradeOrigine, List<Specializarea> specializare)
        {
            foreach(var producator in producatori)
            {

                if (producator.companie == compania && producator.TaraOrigine == TaradeOrigine && specializare.All(s => producator.Specializari.Contains(s)))

                    return producator;
            }
            return null;

        }

        public ProductAvion GetProductPlane(string Companie, string TaradeOrgine)
        {
            throw new Exception("Optiunea GetProductPlane nu este implementata.");
        }
    }
}
