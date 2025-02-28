using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    sealed class SecuritySystem  
    {
        private string securityCode;

        public SecuritySystem(string code)
        {
            securityCode = code;
        }

        public void Authenticate(string enteredCode)
        {
            if (enteredCode == securityCode)
            {
                Console.WriteLine("Access Granted!");
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }
        }
    }

}
