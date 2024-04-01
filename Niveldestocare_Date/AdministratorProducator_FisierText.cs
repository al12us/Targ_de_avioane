using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProducatorAvioane;
using System.IO;
using Avion;
namespace Niveldestocare_Date
{
    public class AdministratorProducator_FisierText
    {

        private const int NR_MAX_PRODUCATORI = 50;
        private string numeFisier_2;
        public AdministratorProducator_FisierText(string numeFisier_2)
        {
            this.numeFisier_2 = numeFisier_2;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier_2, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }
        public void AddProducator(ProductAvion producator)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier_2, true))
            {
                //streamWriterFisierText.WriteLine(producator.ConversieSir_PentruFisier());
            }
        }
        public ProductAvion[] GetProducts(out int nr_producatori)
        {
            ProductAvion[] producatori = new ProductAvion[NR_MAX_PRODUCATORI]; 
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier_2))
            {
                string linieFisierB;
                nr_producatori= 0;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisierB = streamReader.ReadLine()) != null)
                {
                    producatori[nr_producatori++] = new ProductAvion(linieFisierB);
                }
            }

            return producatori;
        }
    }
}
