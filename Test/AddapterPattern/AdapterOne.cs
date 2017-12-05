using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AddapterPattern
{
    public class AdapterOne : IAdapter
    {
        private LibraryOne one = null;

        public AdapterOne()
        {
            one = new LibraryOne();
        }
        
        public void Do()
        {
            one.ThisIsHowOneDoesIt();
        }
    }
}
