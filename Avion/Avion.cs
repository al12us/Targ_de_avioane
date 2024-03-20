
namespace Avion
{
    public class AvionClass
    {
        public string firma { set; get; }
        public string model { set; get; }
        public int an_fabricatie { set; get; }
        public string culoare { set; get; }
        public double greutate { set; get; }
        public double pret { set; get; }
        public int nr_de_pasageri { set; get; }
        public AvionClass()
        {
            firma = model = string.Empty;

            an_fabricatie = 0;
            culoare = string.Empty;
            greutate = 0;
            pret = 0;
            nr_de_pasageri = 0;

        }
        public AvionClass(string firma, string model, int an_fabricatie, string culoare, double greutate, double pret, int nr_de_pasageri)
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
            string afisare = $"Firma:{firma ?? "Necunoscut"}\n Model:{model ?? "necunoscut"}\n Anul in care este fabricat {an_fabricatie} \n Culoarea:{culoare ?? "necunoscut"}\n" +
                             $"Greutatea:{greutate}\n Pret:{pret}\n Numar de pasageri{nr_de_pasageri}";
            return afisare;

        }


    }
}
