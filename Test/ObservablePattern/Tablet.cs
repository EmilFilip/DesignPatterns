using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WheatherObservablePattern
{
    public class Tablet : IObserver
    {
        public void Update(string temperature)
        {
            Console.WriteLine("The temperature on the tablet is: " + temperature.ToString());
        }
    }
}
