using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Niveldestocare_Date;

namespace Targ_Avioane_Interfata
{
    public class StocareFactoryTargAvioane
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareDate GetAdministratorStocareAvioane()
        {
            string formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];

            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    //case "bin":
                       // return new AdministrareStudenti_FisierBinar(caleCompletaFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareAvioane_FisierText(caleCompletaFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }

}

