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
        private const int NR_MAX_AVIOANE = 50;
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
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(avion.ConversieLaSir_PentruFisier());
            }
        }
        public AvionClass[] GetPlanes(out int nr_avioane)
        {
            AvionClass[] avioane = new AvionClass[NR_MAX_AVIOANE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nr_avioane = 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    avioane[nr_avioane++] = new AvionClass(linieFisier);
                }
            }

            return avioane;
        }
    }
}
