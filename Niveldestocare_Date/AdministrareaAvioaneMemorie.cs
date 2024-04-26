using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avion;
namespace Niveldestocare_Date
{
    public class AdministrareAvioane_Memorie
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
        public List<AvionClass> GetAvioane()
        {
           
            return avioane;
        }

    }
}
