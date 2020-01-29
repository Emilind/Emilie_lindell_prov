using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_lindell_prov
{
    class Superhjälte3: Hjälte
    {
        private int styrka = 0;
        private int level = 0;

        public Superhjälte3()//Detta är en konstruktor och den kallas på automatiskt när instansen skapas i detta fall stryka och level
        {
            styrka = generator.Next(15, 201);
            level = generator.Next(1, 10);
        }
    }
}
