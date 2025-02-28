using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    interface IVehicle
    {
        void Drive();
    }

    class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }
    class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike");
        }
    }
    class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            if (type.Equals("Car", StringComparison.OrdinalIgnoreCase))
                return new Car();
            else if (type.Equals("Bike", StringComparison.OrdinalIgnoreCase))
                return new Bike();
            else
                throw new ArgumentException("Invalid vehicle type");
        }
    }

}
