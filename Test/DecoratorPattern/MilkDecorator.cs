using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.CofeeDecoratorPattern
{
    public class MilkDecorator : AddOnDecorator
    {
        public override int Cost()
        {
            return 1;
        }
    }
}
