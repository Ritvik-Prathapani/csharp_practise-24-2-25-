using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class ConfigurationManager
    {
        private static ConfigurationManager? instance = null;

        private static readonly object lockObject = new object();

        private ConfigurationManager()
        {
            Console.WriteLine("Configuration Manager Initialized.");
        }

        public static ConfigurationManager GetInstance()
        {
            if (instance == null)  
            {
                lock (lockObject)  
                {
                    if (instance == null)  
                    {
                        instance = new ConfigurationManager();
                    }
                }
            }
            return instance;
        }
        public void ShowConfig()
        {
            Console.WriteLine("Showing system configuration...");
        }
    }

}
