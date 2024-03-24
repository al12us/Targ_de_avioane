using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Avion;
using Niveldestocare_Date;
namespace Targ_Avion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AvionClass obiect = new AvionClass(0,"TAROM","B-20",2010,"violet",105.5,1000.16,1000);
           Console.WriteLine(obiect.Info());
            AdministrareAvioane_Memorie adminPlane = new AdministrareAvioane_Memorie();
            AvionClass avionNou=new AvionClass();
            int nr_avioane = 0;
            string optiune;
            do
            {

                Console.WriteLine("C. Citire informatii avion de la tastatura");
                Console.WriteLine("I. Afisarea informatiilor despre ultimului avion introdus");
                Console.WriteLine("A. Afisare avioane din fisier");
                Console.WriteLine("S. Salvare avion in vector de obiecte");
                Console.WriteLine("E.Cautarea dupa anumite criterii a avionului");
                Console.WriteLine("F.Cautarea avioanele dupa anumite criterii");
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

    }
}
