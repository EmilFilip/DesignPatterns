using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.AddapterPattern
{
    public class AdapterTwo : IAdapter
    {
        private LibraryTwo two = null;

        public AdapterTwo()
        {
            two = new LibraryTwo();
        }
        
        public void Do()
        {
            Console.WriteLine(two.ThisIsHowTwoDoesIt() + "\n"); ;
        }
    }
}
