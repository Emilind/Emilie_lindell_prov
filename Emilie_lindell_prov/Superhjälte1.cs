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

        public Superhjälte1()//Detta är en konstruktor och den kallas på automatiskt när instansen skapas i detta fall stryka och level
        {
            styrka = generator.Next(10, 150);//Jag använder mig av en random generator för att göra varje karaktär unik. 
            level = generator.Next(1, 25);
        }

        public override string ToString()// Jag använder detta för att kunna display i program.cs vilka värden och så som varje karaktär har. 
        {
            return base.ToString() +
                " Stryka:" + styrka + "  Level:" + level;
        }


    }
}
