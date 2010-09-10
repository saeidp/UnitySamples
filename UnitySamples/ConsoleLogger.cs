using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitySamples
{
    class ConsoleLogger : ILogger 
    {
        #region ILogger Members

        public void Log(string message)
        {
            
            Console.WriteLine(message);
        }

        #endregion
    }
}
