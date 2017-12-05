using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.CofeeDecoratorPattern
{
    public class Tea : Beverage
    {
        public Beverage Beverage { get; set; }

        public Tea(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override int Cost()
        {
            return this.Beverage.Cost() + 5;
        }
    }
}
