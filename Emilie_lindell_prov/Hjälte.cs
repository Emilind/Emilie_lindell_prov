using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emilie_lindell_prov
{
    class Hjälte
    {
        public Random generator = new Random();
        public string namn;//För namnen på hjätarna
        public int hp = 100;//För hur mycket health dem har. 
       
        public void skada(int antal)//Visar hur mycket skada som en karaktär tar vi exempelvi en fight.
        {
            hp -= antal;
        }
        public override string ToString()// För att kunna display informationen i main
        {
            return base.ToString() +
                " HP:" + hp;//Displayar enbart hp för namnet står redan
        }


    }
}
