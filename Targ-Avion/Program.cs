﻿using System;
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
            Console.WriteLine(obiect.Info());
            Console.WriteLine();
            ///S-a adaugat producatorul de avioane
            ProductAvion producator = new ProductAvion();
            ProductAvion exemplu = new ProductAvion(0, "AIRBUS", "Franta", 1970, 4000, Specializarea.civil);
            Console.WriteLine(exemplu.InfoProduct());
            AdministrareProducatorMemorie adminProductPlane = new AdministrareProducatorMemorie();
            //Cu fisiere
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            AdministrareAvioane_FisierText adminPLANE = new AdministrareAvioane_FisierText(numeFisier);
            ///Citire la tastatura
            AdministrareAvioane_Memorie adminPlane = new AdministrareAvioane_Memorie();
            // se aplica la ambele
            AvionClass avionNou = new AvionClass();
            int nr_avioane = 0;
            int nr_producatori = 0;
            string optiune;

            //adaugarea tablou in scara
            //File.ReadAllLines citeste toate liniile din fisier
            string[] linii = File.ReadAllLines("avioane.txt");
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
                ///Entitatea Product Avion
                Console.WriteLine("R.Citire de la tastatura pentru entitatea ProductAvion");
                Console.WriteLine("TB.Afisarea informatiilor despre ultimul producator de avioane introdus");
                Console.WriteLine("AC.Afisare producatori de aeronave din fisier");
                Console.WriteLine("SC.Salvarea producator de avioane");
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

                        AvionClass[] avioanele = adminPLANE.GetPlanes(out nr_avioane);
                        AfisareAvioane(avioanele, nr_avioane);
                        break;
                    case "B":
                        idAvion = ++nr_avioane;
                        avionNou.ID_avion = idAvion;
                        //adaugare avion in fisier
                        adminPLANE.AddPlane(avionNou);

                        break;
                    case "E":
                        string Firma;
                        string Model;
                        int fabricatie;
                        Firma = Console.ReadLine();
                        Model = Console.ReadLine();
                        fabricatie = Convert.ToInt32(Console.ReadLine());
                        string color = Console.ReadLine();
                        Culoarea culoare = (Culoarea)Enum.Parse(typeof(Culoarea), color);
                        Console.WriteLine(adminPlane.GetPlane(Firma, Model, fabricatie, culoare).Info());
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
                    ///Producator de avioane
                    case "R":
                        //Citeste producatorul de avioane
                       producator= CitireDeLaTastatura();
                        break;
                    case "TB":
                        AfisareProducator(producator);
                        break;
                    case "AC":
                        ProductAvion[] producatori = adminProductPlane.GetProducator(out  nr_producatori);
                        AfisProductAeronave(producatori, nr_producatori);
                        break;
                    case "SC":
                        int idProductAvion = nr_producatori + 1;
                        producator.ID_Producator = idProductAvion;
                        //adaugare avion in vectorul de obiecte
                        adminProductPlane.AddProducator(producator);
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

        public static void AfisareAvioane(AvionClass[] avioane, int nr_avioane)
        {
            Console.WriteLine("Avioanele sunt:");
            for (int contor = 0; contor < nr_avioane; contor++)
            {
                string infoAvion = avioane[contor].Info();
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

        public static void AfisProductAeronave(ProductAvion [] producatori,int nr_producatori)
        {
            Console.WriteLine("Producatorii de avioane sunt:");
            for(int contor_prod = 0; contor_prod < nr_producatori; contor_prod++)
            {
                string InfoProducator=producatori[contor_prod].InfoProduct();
                Console.WriteLine(InfoProducator);
            }


        }

     }
}
