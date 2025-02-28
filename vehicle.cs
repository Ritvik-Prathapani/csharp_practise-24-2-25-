using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class vehicle
    {
        public virtual void start()
        {
            Console.WriteLine("start");
        }
    }
    class car: vehicle
    {
        public override void start()
        {
            Console.WriteLine("car is starting");
        }
    }
    class bike: vehicle
    {
        public override void start()
        {
            Console.WriteLine("bike is starting");
        }
    }
}
