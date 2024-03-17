using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targ_Avion
{
    internal class Avion
    {
        private string firma;
        private string model;
        private int an_fabricatie;
        private string culoare;
        private double greutate;
        private double pret;
        private int nr_de_pasageri;
        public Avion()
        {
            firma = string.Empty;
            model = string.Empty;
            an_fabricatie = 0;
            culoare = string.Empty;
            greutate = 0;
            pret = 0;
            nr_de_pasageri = 0;

        }
        public Avion(string firma,string model,int an_fabricatie,string culoare,double greutate,double pret,int nr_de_pasageri)
        {
            this.firma = firma;
            this.model = model;
            this.an_fabricatie = an_fabricatie;
            this.culoare = culoare;
            this.greutate = greutate;
            this.pret = pret;
            this.nr_de_pasageri = nr_de_pasageri;

        }
        public string Info()
        {
            string afisare = $"Firma:{firma}\n Model:{model}\n Anul in care este fabricat {an_fabricatie} \n Culoarea:{culoare}\n" +
                             $"Greutatea:{greutate}\n Pret:{pret}\n Numar de pasageri{nr_de_pasageri}";
            return afisare;
            
        }
        public void Citire()
        {
            
            //Citire
        }
        
    }
}
