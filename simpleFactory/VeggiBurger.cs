using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleFactory
{
    public class VeggiBurger : Burger
    {
        public override void Prepare()
        {
            Console.WriteLine("I'm Preparing a veggi burger");
        }
    }
}
