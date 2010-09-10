using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitySamples
{
    class NullLogger: ILogger 

    {
        #region ILogger Members

        public void Log(string message)
        {
            // Do nothing
        }

        #endregion
    }
}
