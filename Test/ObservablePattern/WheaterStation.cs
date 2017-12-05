using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WheatherObservablePattern
{
    public class WheaterStation : IObservable
    {
        public WheaterStation()
        {
            this.Observers = new List<IObserver>();
        }

        private List<IObserver> Observers { get; set; }

        public void Add(IObserver iObserver)
        {
            Observers.Add(iObserver);
        }

        public void Remove(IObserver iObserver)
        {
            Observers.Remove(iObserver);
        }

        public void Notify(string temperature)
        {
            foreach (var observer in Observers)
            {
                observer.Update(temperature);
            }
        }
    }
}
