using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace UnitySamples
{
   public class CustomerTasks
    {
       private ILogger Logger;

       
       public CustomerTasks(ILogger Logger)
        {
            this.Logger = Logger;
        }

        
       //private ILogger logger = new NullLogger();
        //[Dependency]

        //public ILogger Logger
        //{

        //    get { return logger; }

        //    set { logger = value; }

        //}
       

        public void SaveCustomer()
        {

            Logger.Log("Saved customer");

        }
    }
}
