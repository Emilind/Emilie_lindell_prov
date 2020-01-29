using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_lindell_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till Super Academy, vad är ditt coola superhjälte namn?");
            string dittNamn = Console.ReadLine();
            Superhjälte1 nySuperhjälte1 = new Superhjälte1();
            Console.WriteLine("Välkommen " + dittNamn + "! Detta är dina stats;");
            Console.WriteLine(nySuperhjälte1);

            
            nySuperhjälte1.namn = dittNamn;
            Console.ReadLine();
        }
    }
}
