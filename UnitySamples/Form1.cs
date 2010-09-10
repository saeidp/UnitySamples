using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

 
namespace UnitySamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //A new comment using tortoise today at 14:45 PM
            IUnityContainer container = new UnityContainer();

            UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            section.Containers.Default.Configure(container);

            CustomerTasks tasks1 = container.Resolve<CustomerTasks>();

            CustomerTasks tasks2 = container.Resolve<CustomerTasks>();

            tasks1.SaveCustomer();

            tasks2.SaveCustomer();   
        
        }
    }
}
