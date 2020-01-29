using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_lindell_prov
{
    class Superhjälte1: Hjälte// Detta är arv och det visar att den kommer att ta allt som finns i klassen Hjälte och sedan kan jag modifera just denna klass här utan påverka dem andra som också ärver från samma klass.
    {
        private int styrka = 0;
        private int level = 0;

        public Superhjälte1(string x)
        {
            styrka = generator.Next(10, 150);
        }


    }
}
