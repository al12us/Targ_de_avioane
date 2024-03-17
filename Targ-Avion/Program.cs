using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Targ_Avion.Avion;
namespace Targ_Avion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avion obiect = new Avion ("TAROM","B-20",2010,"violet",105.5,1000.16,1000);
            obiect.Info();
          
        } 
    }
}
