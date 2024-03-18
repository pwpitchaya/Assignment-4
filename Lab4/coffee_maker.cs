using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class coffee_maker
    {
        public int water, coffee, milk, chocolate;
        
      

        public  coffee_maker()
        {
            water = 1200;
            coffee = 500;
            milk = 500;
            chocolate = 500;
        }

        public bool makeBlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                //can make blackCoffee
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool makeLatte()
        {
            if (water >= 200 && coffee >= 20 && milk >= 10)
            {
                //can make Latte
                water = water - 200;
                coffee = coffee - 20;
                milk = milk - 10;
                return true;
            }

            else
            {

                return false;
            }
        }
        public bool makeMocha()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                chocolate = chocolate - 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool makeChocolate()
        {
            if (water >= 300 && chocolate >= 20)
            {
                water = water - 300;
                chocolate = chocolate - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
