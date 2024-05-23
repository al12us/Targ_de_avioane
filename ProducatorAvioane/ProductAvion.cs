using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Avion;
namespace ProducatorAvioane
{
    public class ProductAvion

    {
        private const char SEPARATOARE_SECUNDAR_FISIER = ';';
        private const char SEPARATOARE_PRIMAR_FISIER = ' ';
        private const int ID = 0;
        private const int COMPANIE = 1;
        private const int TARA = 2;
        private const int AN_INFIINTARE = 3;
        private const int NRANGAJATI = 4;
        private const int SPECIALIZARE = 5;
       
        //auto-implementari pentru entitatea producatorul de avioane
        public int ID_Producator { get; set; }
        public string companie { get; set;}
        public string TaraOrigine { get; set; }
        public int AnInfiintare { get; set;}
        public int nrAngajati { get; set;}
        public List<Specializarea> Specializari { get; set; }
   
        public ProductAvion()
        {
            companie=TaraOrigine = string.Empty;
            AnInfiintare = 0;
            nrAngajati = 0;
            Specializari = new List<Specializarea>();

        }
        public ProductAvion(int ID_Producator,string companie,string TaraOrigine,int AnInfiintare,int nrAngajati, List<Specializarea> Specializari)
        {
            this.ID_Producator = ID_Producator;
            this.companie = companie;
            this.TaraOrigine = TaraOrigine;
            this.AnInfiintare = AnInfiintare;
            this.nrAngajati = nrAngajati;
            this.Specializari= Specializari;
        }
        //Constructorul pentru fisierul Producatorul de avioane
        public ProductAvion(string linieFisierB)
        {
            var dateFisier_Beta = linieFisierB.Split(SEPARATOARE_SECUNDAR_FISIER);

            this.ID_Producator = Convert.ToInt32(dateFisier_Beta[ID]);
            this.companie = dateFisier_Beta[COMPANIE];
            this.TaraOrigine = dateFisier_Beta[TARA];
            this.AnInfiintare = Convert.ToInt32(dateFisier_Beta[AN_INFIINTARE]);
            this.nrAngajati = Convert.ToInt32(dateFisier_Beta[NRANGAJATI]);
        
            var specializariString = dateFisier_Beta[SPECIALIZARE].Split(SEPARATOARE_PRIMAR_FISIER);
            foreach (var specializare in specializariString)
            {
                if (Enum.TryParse(specializare.Trim(), out Specializarea specializareParsed))
                {
                    Specializari.Add(specializareParsed);
                }
            }
        }
        public string InfoProduct
        {
            get
            {
                string afis = $"ID:{ID_Producator}\n Compania:{companie}\n Tara de origine:{TaraOrigine}\n Infiintat din  {AnInfiintare} \n " +
                              $"Numar de angajati:{nrAngajati}\n Specilizarea:{Specializari}";
                return afis;
            }
          }
        public string ConversieSir_PentruFisier()
        {
            string obiectProductAvionfisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}",
                SEPARATOARE_SECUNDAR_FISIER,
                ID_Producator.ToString(),
                (companie ?? "NECUNOSCUT"),
                (TaraOrigine ?? "NECUNOSCUT"),
                AnInfiintare.ToString(),
                nrAngajati.ToString(),
                Specializari.ToString());
            
            return obiectProductAvionfisier;
        }
    }
}
