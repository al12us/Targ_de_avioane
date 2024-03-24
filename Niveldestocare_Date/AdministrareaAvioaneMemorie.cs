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

        public void AddAvion(AvionClass avionul)
        {
            avioane[nr_avioane] = avionul;
            nr_avioane++;
        }

        public AvionClass[] GetAvioane(out int nr_avioane)
        {
            nr_avioane = this.nr_avioane;
            return avioane;
        }
    }
}
