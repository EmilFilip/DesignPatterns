using System;

namespace Test.WheatherObservablePattern
{
    public class MobilePhone : IObserver
    {
        public void Update(string temperature)
        {
            Console.WriteLine("The temperature on the mobile is: " + temperature.ToString());
        }
    }
}
