using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_lindell_prov
{
    class Superhjälte2: Hjälte
    {
        private int styrka = 0;
        private int level = 0;

        public Superhjälte2()//Detta är en konstruktor och den kallas på automatiskt när instansen skapas i detta fall stryka och level
        {
            styrka = generator.Next(10, 200);//Jag använder mig av en random generator för att göra varje karaktär unik. 
            level = generator.Next(1, 25);

        }
    }
}
