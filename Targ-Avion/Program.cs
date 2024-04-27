using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Avion;
using Niveldestocare_Date;
using System.Runtime.ConstrainedExecution;
using Microsoft.SqlServer.Server;
using System.Reflection;
using ProducatorAvioane;
namespace Targ_Avion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvionClass obiect = new AvionClass(0, "TAROM", "B-20", 2010, Culoarea.violet, 105.5m, 1000.16m, 1000);
            Console.WriteLine(obiect.Info);
  
          
            //Cu fisiere
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareAvioane_FisierText adminPLANE = new AdministrareAvioane_FisierText(numeFisier);
            ///Citire la tastatura
            AdministrareAvioane_Memorie adminPlane = new AdministrareAvioane_Memorie();
            AvionClass avionNou = new AvionClass();
            List<AvionClass> avioane = new List<AvionClass>();
           
            string optiune;

            //adaugarea tablou in scara
            //File.ReadAllLines citeste toate liniile din fisier
            string[] linii = File.ReadAllLines("avioane.txt");
            AvionClass[][] planes = new AvionClass[26][];
            Console.WriteLine();
            ///S-a adaugat producatorul de avioane
            ProductAvion producator = new ProductAvion();
            ProductAvion exemplu = new ProductAvion(0, "AIRBUS", "Franta", 1970, 4000, Specializarea.civil);
            Console.WriteLine(exemplu.InfoProduct);
            //Se adauga o lista
            List<ProductAvion> producatori = new List<ProductAvion>();
            AdministrareProducatorMemorie adminProductPlane = new AdministrareProducatorMemorie();
            string numeFisier_2 = ConfigurationManager.AppSettings["NumeFisier_2"];
            AdministratorProducator_FisierText administratorProducatorPlane = new AdministratorProducator_FisierText(numeFisier_2);
            int nr_producatori = 0;
            string [] linii_de_banda = File.ReadAllLines("producatorideavioane.txt");
            ProductAvion[][] the_productsplane = new ProductAvion[26][];

            do
            {

                Console.WriteLine("C. Citire informatii avion de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultimului avion introdus");
                Console.WriteLine("A. Afisare avioane din fisier");
                Console.WriteLine("S. Salvare avion in vector de obiecte");
                Console.WriteLine("D.Afisare in fisier avioane");
                Console.WriteLine("B.Salvare avion in fisier");
                Console.WriteLine("E.Cautarea dupa anumite criterii a avionului");
                Console.WriteLine("F.Cautarea avioanele dupa anumite criterii");
                Console.WriteLine("L.Tablou in scara la avioane");
                ///Entitatea Product Avion
                Console.WriteLine("R.Citire de la tastatura pentru entitatea ProductAvion");
                Console.WriteLine("TB.Afisarea informatiilor despre ultimul producator de avioane introdus");
                Console.WriteLine("AC.Afisare producatori de aeronave din fisier");
                Console.WriteLine("SC.Salvarea producator de avioane");
                Console.WriteLine("ED.Cautarea dupa anumite criterii a producatorului");
                Console.WriteLine("DT.Afisare in fisier producatori de avioane");
                Console.WriteLine("BD.Salvare producator_de_avioane in fisier");
                Console.WriteLine("BL.Tabloul in scara la producatorul de avioane");
                Console.WriteLine("X. Inchidere program");

                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "C":
                        avionNou = CitireAvionulTastatura();
                        break;
                    case "I":
                        AfisareAvion(avionNou);
                        break;
                    case "A":
                        avioane = adminPlane.GetAvioane();
                        AfisareAvioane(avioane);

                        break;
                    case "S":
                        int idAvion = avioane.Count + 1;
                        avionNou.ID_avion = idAvion;
                        //adaugare avion in vectorul de obiecte
                        adminPlane.AddPlane(avionNou);
                        break;
                    case "D":

                       avioane = adminPLANE.GetPlanes();
                        AfisareAvioane(avioane);  
                        break;
                    case "B":
                         idAvion = avioane.Count+1;
                        avionNou.ID_avion = idAvion;
                        //adaugare avion in fisier
                        adminPLANE.AddPlane(avionNou);
                      
                        break;
                    case "E":
                        string Firma;
                        string Model;
                        int fabricatie;
                        Console.WriteLine("Firma:");
                        Firma = Console.ReadLine();
                        Console.WriteLine("Model");
                        Model = Console.ReadLine();
                        Console.WriteLine("Anul in care a fost fabricat");
                        fabricatie = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Culoarea avionului:");
                        string color = Console.ReadLine();
                        Culoarea culoare = (Culoarea)Enum.Parse(typeof(Culoarea), color);
                        Console.WriteLine(adminPlane.GetPlane(Firma, Model, fabricatie, culoare).Info);
                        break;
                    case "F":

                        Firma = Console.ReadLine();
                        Model = Console.ReadLine();
                        List<AvionClass> avioane_gasite = adminPlane.GetAvion(Firma, Model);
                        foreach (AvionClass avion in avioane_gasite)
                        {
                            Console.WriteLine(avion);
                        }
                        break;
                    case "L":
                        Afisare_Vector_de_tablou_scara(planes, linii);
                        break;
                    ///Producator de avioane
                    case "R":
                        //Citeste producatorul de avioane
                       producator= CitireDeLaTastatura();
                        break;
                    case "TB":
                        AfisareProducator(producator);
                        break;
                    ///Afisarea in memorie a producatorilor de aeronave
                    case "AC":
                        producatori = adminProductPlane.GetProducator();
                        AfisProductAeronave(producatori);
                        break;
                        //Salvare vector de obiecte din clasa ProductAvion
                    case "SC":
                        int idProductAvion = nr_producatori + 1;
                        producator.ID_Producator = idProductAvion;
                        //adaugare producator in vectorul de obiecte
                        adminProductPlane.AddProducator(producator);
                        break;
                    ///Cautarea producatorului de aeronave
                    case "ED":
                        Console.WriteLine("Compania de aeronave");
                        string compania = Console.ReadLine();
                        Console.WriteLine("Tara de origine:");
                        string tara = Console.ReadLine();
                        Console.WriteLine("Specializarea producatorului de aeronave");
                        string _spec= Console.ReadLine();
                        Specializarea spec = (Specializarea)Enum.Parse(typeof(Specializarea),_spec);
                        Console.WriteLine(adminProductPlane.CautareProducator(compania,tara,spec).InfoProduct);
                        break;
                    case "DT":
                         producatori= administratorProducatorPlane.GetProducts();
                        AfisProductAeronave(producatori);
                        break;
                    case "BD":
                        idProductAvion = ++nr_producatori;
                        producator.ID_Producator = idProductAvion;
                        //adauga producatorul de avioane in fisier
                        administratorProducatorPlane.AddProducator(producator);
                        break;
                    case "BL":
                        Afisare_Vector_de_tablou_scara_productPlane(the_productsplane, linii_de_banda);
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }

            } while (optiune.ToUpper() != "X");

            Console.ReadKey();

        }

        public static AvionClass CitireAvionulTastatura()
        {
            Console.WriteLine("Introduceti Firma");
            string Firma = Console.ReadLine();

            Console.WriteLine("Introduceti Modelul");
            string modelul = Console.ReadLine();
            Console.WriteLine("An de fabricatie");
            int an_fabricatia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti Culoarea");
            string culoare = Console.ReadLine();
            Culoarea culoarea = (Culoarea)Enum.Parse(typeof(Culoarea), culoare);
            Console.WriteLine("Introduceti greutatea");
            decimal greutatea = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Introduceti pretul");
            decimal pretul = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Introduceti numarul de pasageri de la tastatura");
            int nrpassageri = Convert.ToInt32(Console.ReadLine());


            AvionClass avion = new AvionClass(0, Firma, modelul, an_fabricatia, culoarea, greutatea, pretul, nrpassageri);

            return avion;
        }
        public static void AfisareAvion(AvionClass avion)
        {
            string infoAvion = string.Format("Avionul cu id-ul #{0} are numele: {1} {2} {3} {4} {5} {6} {7}",
                    avion.ID_avion,
                    avion.firma ?? " NECUNOSCUT ",
                    avion.model ?? " NECUNOSCUT ",
                    avion.an_fabricatie,
                    avion.culoare.ToString(),
                    avion.greutate,
                    avion.pret,
                    avion.nr_de_pasageri);


            Console.WriteLine(infoAvion);
        }

        public static void AfisareAvioane(List<AvionClass> avioane) { 
        
            Console.WriteLine("Avioanele sunt:");
            foreach(var avion in avioane)
            {
                string infoAvion = avion.Info;
                Console.WriteLine(infoAvion);
            }
        }

        public static void Afisare_Vector_de_tablou_scara(AvionClass[][] planes, string[] linii)
        {
            //split-ul este separeaza datele prin ;
            for (int i = 0; i < 26; i++)
            {
                char litera = (char)('a' + i); //gasirea cuvintelor care incep cu litera a,b  pana la z
                planes[i] = linii
                .Select(line =>
                {
                    string[] parts = line.Split(';');
                    return new AvionClass
                    {
                        ID_avion = int.Parse(parts[0]),
                        firma = parts[1],
                        model = parts[2],
                        an_fabricatie = int.Parse(parts[3]),
                        culoare = (Culoarea)Enum.Parse(typeof(Culoarea), parts[4]),
                        greutate = decimal.Parse(parts[5]),
                        pret = decimal.Parse(parts[6]),
                        nr_de_pasageri = int.Parse(parts[7])
                    };
                })
                .Where(plane => plane.firma.StartsWith(litera.ToString(), StringComparison.OrdinalIgnoreCase))
                //Where -este functia care filtreaza datele din fisier,StringComparison.OrdinalIgnoreCase verifica
                // daca un cuvant a inceput cu o litera
                .ToArray();
            }

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine($"Avioanele care încep cu '{(char)('a' + i)}':");
                //foreach--este o structura de control care itereaza fiecare element dintr-o colectie
                //In acest proiect se pacurge fiecare avion din sub-tabloul specificat.
                foreach (AvionClass plane in planes[i])
                {
                    string afisare = $"ID:{plane.ID_avion}\nFirma:{plane.firma ?? "Necunoscut"}\n Model:{plane.model ?? "necunoscut"}\n Anul in care este fabricat {plane.an_fabricatie} \n Culoarea:{plane.culoare}\n" +
                           $"Greutatea:{plane.greutate}\n Pret:{plane.pret}\n Numar de pasageri:{plane.nr_de_pasageri}";
                    Console.WriteLine(afisare);
                }
            }


        }
        ///Producatorul de avioane
        ///
        public static ProductAvion CitireDeLaTastatura()
        {
            Console.WriteLine("Introduceti numele companiei");
            string compania = Console.ReadLine();
            Console.WriteLine("Introduceti tara de origine");
            string tara_de_origine = Console.ReadLine();
            Console.WriteLine("Introduce de la tastatura anul in care a fost infiintat compania");
            int an_infiintare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce de la tastatura nr de angajati ");
            int numar_de_angajati = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Specializarea cu care se ocupa compani de aeronave");
            string spec = Console.ReadLine();
            Specializarea specializ = (Specializarea)Enum.Parse(typeof(Specializarea), spec);

            ProductAvion producator = new ProductAvion(0, compania, tara_de_origine, an_infiintare, numar_de_angajati, specializ);

            return producator;

        }
        public static void AfisareProducator(ProductAvion producator)
        {
            string InfoProductator = String.Format("Producatorul cu ID:{0} are urmatoarele date:{1} {2} {3} {4} {5}",
                producator.ID_Producator,
                producator.companie ?? "NECUNOSCUT",
                producator.TaraOrigine ?? "NECUNOSCUT",
                producator.AnInfiintare,
                producator.nrAngajati,
                producator.specializare.ToString());
            Console.WriteLine(InfoProductator);
        }

        public static void AfisProductAeronave(List<ProductAvion> producatori)
        {
            Console.WriteLine("Producatorii de avioane sunt:");
            foreach(var producatorul in producatori)
            {
                string InfoProducator=producatorul.InfoProduct;
                Console.WriteLine(InfoProducator);
            }


        }
        public static void Afisare_Vector_de_tablou_scara_productPlane(ProductAvion[][] the_productsplane, string[] linii_de_banda)
        {
            //split-ul este separeaza datele prin ;
            for (int i = 0; i < 26; i++)
            {
                char litera = (char)('a' + i); //gasirea cuvintelor care incep cu litera a,b  pana la z
                the_productsplane[i] = linii_de_banda
                .Select(line =>
                {
                    string[] parts = line.Split(';');
                    return new ProductAvion
                    {
                        ID_Producator = int.Parse(parts[0]),
                        companie = parts[1],
                        TaraOrigine = parts[2],
                        AnInfiintare = int.Parse(parts[3]),
                        nrAngajati = int.Parse(parts[4]),
                        specializare = (Specializarea)Enum.Parse(typeof(Specializarea), parts[5])
                      
                    };
                })
                .Where(product_plane => product_plane.companie.StartsWith(litera.ToString(), StringComparison.OrdinalIgnoreCase))
                //Where -este functia care filtreaza datele din fisier,StringComparison.OrdinalIgnoreCase verifica
                // daca un cuvant a inceput cu o litera
                .ToArray();
            }

            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine($"Avioanele care încep cu '{(char)('a' + i)}':");
                //foreach--este o structura de control care itereaza fiecare element dintr-o colectie
                //In acest proiect se pacurge fiecare producator de avioane din sub-tabloul specificat.
                foreach (ProductAvion product_plane in the_productsplane[i])
                {
                    string afisare = $"ID:{product_plane.ID_Producator}\nCompania:{product_plane.companie ?? "Necunoscut"}\n Tara de origine:{product_plane.TaraOrigine ?? "necunoscut"}\n Anul in care a fost infiintat {product_plane.AnInfiintare} \n Numarul de angajati:{product_plane.nrAngajati}\n" +
                           $"Specializarea:{product_plane.specializare}";
                    Console.WriteLine(afisare);
                }
            }


        }

    }
}
