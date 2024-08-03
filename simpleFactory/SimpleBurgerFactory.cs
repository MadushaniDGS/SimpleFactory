using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleFactory
{
    public class SimpleBurgerFactory
    {
        public Burger CreateBurger(string type)
        {
            Burger burger = null;

            if(type == "beef")
            {
                burger = new BeefBurger();
            }
            else if (type == "veggi")
            {
                burger = new VeggiBurger();
            }

            return burger;
        }

    }
}
