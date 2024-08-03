using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleFactory
{
    public class Resturant
    {
        public Burger OrderBurger(string type)
        {
            SimpleBurgerFactory s1= new SimpleBurgerFactory();
            Burger burger = s1.CreateBurger(type);
            burger.Prepare();

            return burger;
        }
    }
}
