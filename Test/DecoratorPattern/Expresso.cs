using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.CofeeDecoratorPattern
{
    public class Expresso : Beverage
    {
        public Beverage Beverage { get; set; }

        public Expresso(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override int Cost()
        {
            return this.Beverage.Cost() + 7;
        }
    }
}
