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
            Superhjälte1 nySuperhjälte1 = new Superhjälte1();
            Hjälte nyhjälte = new Hjälte();
            Console.WriteLine("Hej och välkommen till Super Academy, vad är ditt coola superhjälte namn?");
            string dittNamn = "";//skriva in namnet
            nySuperhjälte1.namn = dittNamn;//för att koppla namnet till den klassen

            while ( dittNamn.Length < 3 || dittNamn.Length > 32 || dittNamn.Any(char.IsDigit) == true)//Så att spelaren inte kan vara dum
            {
                dittNamn = Console.ReadLine();

                if(dittNamn.Length < 3)
                {
                    Console.WriteLine("Too short!");
                }
                else if (dittNamn.Length > 32)
                {
                    Console.WriteLine("Too long!");
                }
                else if(dittNamn.Any(char.IsDigit) == true)
                {
                    Console.WriteLine("Only letters!");
                }
                else
                {
                    Console.WriteLine("Välkommen " + dittNamn + "! Detta är dina stats;");
                    Console.WriteLine(nySuperhjälte1);//Detta skriver ut spelarens värde på sin karaktär och tar då infon från klassen
                    Console.WriteLine(nyhjälte);
                }
            }
            
            

            
            
            Console.ReadLine();
        }
    }
}
