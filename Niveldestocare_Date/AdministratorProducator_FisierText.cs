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

        private const int ID_PRIMUL_PRODUCATOR_AVION = 1;
        private const int INCREMENT = 1;
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
             producator.ID_Producator =GetIDProduct();
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier_2, true))
            {
                streamWriterFisierText.WriteLine(producator.ConversieSir_PentruFisier());
            }
        }
        public List<ProductAvion> GetProducts()
        {
            List<ProductAvion> producatori = new List<ProductAvion>(); 
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier_2))
            {
                string linieFisierB;
          

                // citeste cate o linie si creaza un obiect de tip ProductAvion
                // pe baza datelor din linia citita
                while ((linieFisierB = streamReader.ReadLine()) != null)
                {
                    producatori.Add (new ProductAvion(linieFisierB));
                }
            }

            return producatori;
        }
        public ProductAvion GetProductPlane(string Companie, string TaradeOrgine)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier_2))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Avion
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    ProductAvion producator= new ProductAvion(linieFisier);
                    if (producator.Equals(Companie) && producator.Equals(TaradeOrgine))
                        return producator;
                }
            }

            return null;
        }
        private int GetIDProduct()
        {
            int IDProductPlane = ID_PRIMUL_PRODUCATOR_AVION;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier_2))
            {
                string linieFisierB;

                //citeste cate o linie si creaza un obiect de tip Avion pe baza datelor din linia citita
                while ((linieFisierB = streamReader.ReadLine()) != null)
                {
                    ProductAvion producator = new ProductAvion(linieFisierB);
                    IDProductPlane = producator.ID_Producator + INCREMENT;
                }
            }

            return IDProductPlane;
        }
    }
}
