using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WheatherObservablePattern
{
    public interface IObservable
    {
        void Add(IObserver iObserver);
        void Remove(IObserver iObserver);
        void Notify(string temperature);
    }
}
