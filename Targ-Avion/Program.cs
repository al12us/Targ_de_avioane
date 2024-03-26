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
namespace Targ_Avion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvionClass obiect = new AvionClass(0,"TAROM","B-20",2010,"violet",105.5,1000.16,1000);
           Console.WriteLine(obiect.Info());
            //Cu fisiere
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareAvioane_FisierText adminPLANE = new AdministrareAvioane_FisierText(numeFisier);
            ///Citire la tastatura
            AdministrareAvioane_Memorie adminPlane = new AdministrareAvioane_Memorie();
            // se aplica la ambele
            AvionClass avionNou=new AvionClass();
            int nr_avioane = 0;
            string optiune;

            //adaugarea tablou in scara
            //File.ReadAllLines citeste toate liniile din fisier
            string [] linii = File.ReadAllLines("avioane.txt");
            AvionClass[][] planes = new AvionClass[26][];

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
                Console.WriteLine("L.Tablou in scara");
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
                        AvionClass[] avioane = adminPlane.GetAvioane(out nr_avioane);
                        AfisareAvioane(avioane, nr_avioane);

                        break;
                    case "S":
                        int idAvion = nr_avioane + 1;
                        avionNou.ID_avion = idAvion;
                        //adaugare avion in vectorul de obiecte
                        adminPlane.AddPlane(avionNou);
                        break;
                    case "D":
                      
                        AvionClass[] avioanele= adminPLANE.GetPlanes(out nr_avioane);
                        AfisareAvioane(avioanele, nr_avioane);
                        break;
                    case "B":
                         idAvion = ++nr_avioane;
                        avionNou.ID_avion = idAvion;
                        //adaugare student in fisier
                        adminPLANE.AddPlane(avionNou);

                        break;
                    case "E":
                        string Firma;
                        string Model;
                        int fabricatie;
                        string Culoare;
                        Firma = Console.ReadLine();
                        Model = Console.ReadLine();
                        fabricatie = Convert.ToInt32(Console.ReadLine());
                        Culoare = Console.ReadLine();
                        Console.WriteLine(adminPlane.GetPlane(Firma, Model,fabricatie,Culoare).Info());
                        break;
                    case "F":
                        
                        /*Firma = Console.ReadLine();
                        Model = Console.ReadLine();
                        AvionClass[] avioane_gasite = adminPlane.GetAvion(Firma, Model,out int nr_avioane1);
                        foreach (AvionClass avion in avioane_gasite)
                        {
                            Console.WriteLine(avion);
                        }*/
                        break;
                    case "L":
                        Afisare_Vector_de_tablou_scara(planes, linii);
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
            string modelul= Console.ReadLine();
            Console.WriteLine("An de fabricatie");
            int an_fabricatia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti Culoarea");
            string culoarea = Console.ReadLine();

            Console.WriteLine("Introduceti greutatea");
            double greutatea = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti pretul");
            double pretul = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti numarul de pasageri de la tastatura");
            int nrpassageri = Convert.ToInt32(Console.ReadLine());


            AvionClass avion = new AvionClass(0, Firma, modelul,an_fabricatia,culoarea,greutatea,pretul,nrpassageri);

            return avion;
        }
        public static void AfisareAvion(AvionClass avion)
        {
            string infoStudent = string.Format("Avionul cu id-ul #{0} are numele: {1} {2} {3} {4} {5} {6} {7}",
                    avion.ID_avion,
                    avion.firma ?? " NECUNOSCUT ",
                    avion.model ?? " NECUNOSCUT ",
                    avion.an_fabricatie,
                    avion.culoare ?? "NECUNOSCUT",
                    avion.greutate,
                    avion.pret,
                    avion.nr_de_pasageri);
                    

            Console.WriteLine(infoStudent);
        }

        public static void AfisareAvioane(AvionClass[] avioane, int nr_avioane)
        {
            Console.WriteLine("Avioanele sunt:");
            for (int contor = 0; contor < nr_avioane; contor++)
            {
                string infoAvion = avioane[contor].Info();
                Console.WriteLine(infoAvion);
            }
        }

        public static void Afisare_Vector_de_tablou_scara(AvionClass[][] planes ,string[]linii)
        {
            //split-ul este separeaza datele prin ;
           for (int i = 0; i < 26; i++)
            {
                char litera = (char)('a' + i);
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
                        culoare = parts[4],
                        greutate = double.Parse(parts[5]),
                        pret = double.Parse(parts[6]),
                        nr_de_pasageri = int.Parse(parts[7])
                    };
                })
                .Where(plane => plane.firma.StartsWith(litera.ToString(), StringComparison.OrdinalIgnoreCase))
                //Where -este functia care filtreaza datele din fisier,StringComparison.OrdinalIgnoreCase verifica
                // daca un cuvant a inceput cu o litera
                .ToArray();
            }

           for(int i = 0; i < 26; i++)
            {
                Console.WriteLine($"Avioanele care încep cu '{(char)('a' + i)}':");
                //foreach--este o structura de control care itereaza fiecare element dintr-o colectie
                //In acest proiect se pacurge fiecare avion din sub-tabloul specificat.
                foreach(AvionClass plane in planes[i])
                {
                    string afisare = $"ID:{plane.ID_avion}\nFirma:{plane.firma ?? "Necunoscut"}\n Model:{plane.model ?? "necunoscut"}\n Anul in care este fabricat {plane.an_fabricatie} \n Culoarea:{plane.culoare ?? "necunoscut"}\n" +
                           $"Greutatea:{plane.greutate}\n Pret:{plane.pret}\n Numar de pasageri:{plane.nr_de_pasageri}";
                    Console.WriteLine(afisare);
                }
            }
            

        }

    }

}
