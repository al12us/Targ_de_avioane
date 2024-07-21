using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Avion;
namespace Niveldestocare_Date
{
   public class AdministrareAvioane_FisierBinar:IStocareDate
    {
        private const int ID_PRIMUL_AVION = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareAvioane_FisierBinar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

            //Explicatiile din lucrarea de laborator PIU
            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }

        }

        public void AddPlane(AvionClass avion)
        {


            avion.ID_avion = GetID();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializare unui obiect
                    b.Serialize(sBinFile, avion);
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<AvionClass> GetPlanes()
        {
            List<AvionClass> avioane = new List<AvionClass>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        avioane.Add((AvionClass)b.Deserialize(sBinFile));
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return avioane;
        }
        public AvionClass GetPlane(int idAvion)
        {
            throw new Exception("Optiunea GetPlane by Id nu este implementata");
        }
        public bool UpdateAvion(AvionClass avionActualizat){
            throw new Exception("Optiunea UpdateAvion nu este implementata");
        }


        private int GetID()
        {
            int IdAvion = ID_PRIMUL_AVION;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        AvionClass avion = (AvionClass)b.Deserialize(sBinFile);
                        IdAvion = avion.ID_avion + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdAvion;
        }
    }
}

   

