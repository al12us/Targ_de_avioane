using System;
using System.Collections.Generic;
using System.Linq;
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
        public AdministrareAvioane_FisierBinar(string NumeFisier)
        {


        }
    }
}
