using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WheatherObservablePattern
{
    public interface IObserver
    {
        void Update(string temperature);
    }
}
