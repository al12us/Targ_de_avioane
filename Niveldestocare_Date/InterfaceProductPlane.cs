using ProducatorAvioane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niveldestocare_Date
{
    public interface InterfaceProductPlane
    {

        void AddProducator(ProductAvion producatorul);
        List<ProductAvion> GetProducator();
        ProductAvion GetProductPlane(string Companie, string TaradeOrgine);


    }
}
