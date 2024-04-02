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
        private const int NR_MAX_AVIOANE = 50;

        private  AvionClass[] avioane;
        private int nr_avioane;
        public AdministrareAvioane_Memorie()
        {
             avioane= new AvionClass[NR_MAX_AVIOANE];
             nr_avioane = 0;
        }

        public void AddPlane(AvionClass avionul)
        {
            avioane[nr_avioane] = avionul;
            nr_avioane++;
        }
        public AvionClass GetPlane(string Firma, string Model,int fabricatie,Culoarea Culoare)
        {
            for (int i = 0; i < nr_avioane; i++)
            {
                if (avioane[i].firma == Firma && avioane[i].model == Model && avioane[i].an_fabricatie==fabricatie  && avioane[i].culoare==Culoare)
                    return avioane[i];
            }
            return null;

        }
        public AvionClass[] GetAvion(string Firma,string Model, out int nr_avioane)
        {
            nr_avioane = 0;
            AvionClass[] temp = new AvionClass[avioane.Length];
            for (int i = 0; i < temp.Length; i++)
            {

                if (avioane[i].firma == Firma && avioane[i].model==Model)
                {
                    temp[i] = avioane[i];
                    nr_avioane++;
                }


            }
            return temp;
        }
        public AvionClass[] GetAvioane(out int nr_avioane)
        {
            nr_avioane = this.nr_avioane;
            return avioane;
        }

    }
}
