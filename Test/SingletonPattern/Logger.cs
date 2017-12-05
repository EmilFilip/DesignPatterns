using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SingletonPattern
{
    public class Logger
    {
        private static volatile Logger _logger; //Volatile is not needed for .NET version 2.0 or newer
        private static readonly object _syncLock = new object();

        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if (_logger is null)
            {
                lock (_syncLock)
                {
                    if (_logger is null)
                    {
                        _logger = new Logger();
                    }
                }
            }
            return _logger;
        }
    }
}
