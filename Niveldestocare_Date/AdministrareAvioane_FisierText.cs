using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Avion;

namespace Niveldestocare_Date
{
    public class AdministrareAvioane_FisierText
    {
       
        private const int ID_PRIMUL_AVION = 1; 
        private const int INCREMENT = 1;
        private string numeFisier;

        public AdministrareAvioane_FisierText(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddPlane(AvionClass avion)
        {
            avion.ID_avion = GetID();
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(avion.ConversieLaSir_PentruFisier());
            }
        }
        public List<AvionClass> GetPlanes()
        {
            List<AvionClass> avioane = new List<AvionClass>();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                

                // citeste cate o linie si creaza un obiect de tip Avion
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    avioane.Add( new AvionClass(linieFisier));
                }
            }
         
            return avioane;
        }
        public AvionClass GetPlane(string Firma, string Model,int AN_Fabricatie,Culoarea color)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Avion
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    AvionClass avion = new AvionClass(linieFisier);
                    if (avion.firma.Equals(Firma) && avion.model.Equals(Model) && avion.an_fabricatie.Equals(AN_Fabricatie) && avion.culoare.Equals(color))
                        return avion;
                }
            }

            return null;
        }
        public AvionClass GetPlane(int idAvion)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Avion
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    AvionClass avion = new AvionClass(linieFisier);
                    if (avion.ID_avion == idAvion)
                        return avion;
                }
            }

            return null;
        }
        private int GetID()
        {
            int IDAvion = ID_PRIMUL_AVION;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Avion pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    AvionClass avion = new AvionClass(linieFisier);
                    IDAvion= avion.ID_avion + INCREMENT;
                }
            }

            return IDAvion;
        }
    }
}
