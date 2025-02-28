using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class ComplexNumber
    {
        public double Real { get; }
        public double Imaginary { get; }
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public void Display()
        {
            Console.WriteLine($"{Real} + {Imaginary}i");
        }
    }
}
