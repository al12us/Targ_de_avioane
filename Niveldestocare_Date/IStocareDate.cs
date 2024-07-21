using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avion;
using ProducatorAvioane;
namespace Niveldestocare_Date
{
    public interface IStocareDate
    {
        void AddPlane(AvionClass avion);
        List<AvionClass> GetPlanes();
        AvionClass GetPlane(int idAvion);
     
        bool UpdateAvion(AvionClass avionActualizat);




    }
}
