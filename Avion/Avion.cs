
using System;

namespace Avion
{
    public class AvionClass
    {

        //constante
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int FIRMA = 1;
        private const int MODEL = 2;
        private const int AN_FABRICATIA = 3;
        private const int CULOARE = 4;
        private const int GREUTATE = 5;
        private const int PRET = 6;
        private const int NRPASAGERI = 7;

        //auto-implementari
        public int ID_avion{ set; get; }
        public string firma { set; get; }
        public string model { set; get; }
        public int an_fabricatie { set; get; }
        public Culoarea culoare { set; get; }
        public decimal greutate { set; get; }
        public decimal pret { set; get; }
        public int nr_de_pasageri { set; get; }
        public AvionClass()
        {
            firma = model = string.Empty;
            an_fabricatie = 0;
            greutate = 0;
            pret = 0;
            nr_de_pasageri = 0;

        }
        public AvionClass(int idAvion,string firma, string model, int an_fabricatie, Culoarea culoare, decimal greutate, decimal pret, int nr_de_pasageri)
        {
            this.ID_avion = idAvion;
            this.firma = firma;
            this.model = model;
            this.an_fabricatie = an_fabricatie;
            this.culoare = culoare;
            this.greutate = greutate;
            this.pret = pret;
            this.nr_de_pasageri = nr_de_pasageri;

        }
        //Constructor cu parametru pentru fisier
        public AvionClass(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.ID_avion = Convert.ToInt32(dateFisier[ID]);
            this.firma = dateFisier[FIRMA];
            this.model = dateFisier[MODEL];
            this.an_fabricatie = Convert.ToInt32(dateFisier[AN_FABRICATIA]);
            this.culoare = (Culoarea)Enum.Parse(typeof(Culoarea),dateFisier[CULOARE]);
            this.greutate = Convert.ToDecimal(dateFisier[GREUTATE]);
            this.pret = Convert.ToDecimal(dateFisier[PRET]);
            this.nr_de_pasageri = Convert.ToInt32(dateFisier[NRPASAGERI]);
        }
        public string Info
        {
            get
            {
                string afisare = $"ID:{ID_avion}\nFirma:{firma ?? "Necunoscut"}\n Model:{model ?? "necunoscut"}\n Anul in care este fabricat {an_fabricatie} \n Culoarea:{culoare}\n" +
                                 $"Greutatea:{greutate}\n Pret:{pret}\n Numar de pasageri:{nr_de_pasageri}";
                return afisare;
            }
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectAvionPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                ID_avion.ToString(),
                (firma ?? " NECUNOSCUT "),
                (model ?? " NECUNOSCUT "),
                an_fabricatie.ToString(),
                culoare.ToString(),
                greutate.ToString(),
                pret.ToString(),
                nr_de_pasageri.ToString());

            return obiectAvionPentruFisier;
        }


    }
}
