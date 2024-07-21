using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Avion;
namespace Niveldestocare_Date
{
    public class AdministrareAvioane_Memorie:IStocareDate
    {
        

        
        private List<AvionClass> avioane;

        public AdministrareAvioane_Memorie()
        {
            avioane = new List<AvionClass>();

        }
        public void AddPlane(AvionClass avionul)
        {
           avioane.Add(avionul);
        }
        public AvionClass GetPlane(string Firma, string Model,int fabricatie,Culoarea Culoare)
        {
            foreach (var avion in avioane)
            {
                if (avion.firma == Firma && avion.model == Model && avion.an_fabricatie==fabricatie  && avion.culoare==Culoare)
                    return avion;
            }
            return null;

        }
        public List<AvionClass> GetAvion(string Firma,string Model)
        {
            
            var temp = new List <AvionClass>();
            foreach(var avion in avioane)
            {

                if (avion.firma == Firma && avion.model==Model)
                {
                    temp.Add(avion);
                }


            }
            return temp;
        }
        public List<AvionClass> GetPlanes()
        {
           
            return avioane;
        }

         public AvionClass GetPlane(int idAvion)
        {
            throw new Exception("Optiunea GetPlane by Id nu este implementata");
        }


        public bool UpdateAvion(AvionClass avionActualizat)
        {
            throw new Exception("Optiunea UpdateAvion nu este implementata");
        }
    }
    
}
