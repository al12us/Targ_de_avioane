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
        public void Afisare()
        {
            Console.WriteLine($"Firma:{firma}");
            Console.WriteLine($"Model:{model}");
            Console.WriteLine($"An fabricatie:{an_fabricatie}");
            Console.WriteLine($"Culoare:{culoare}");
            Console.WriteLine($"Greutate:{greutate} t");
            Console.WriteLine($"Pret:{pret}");
            Console.WriteLine($"Numar_de_pasageri:{nr_de_pasageri}");
        }
        public void Citire()
        {
            
            //Citire
        }
        
    }
}
