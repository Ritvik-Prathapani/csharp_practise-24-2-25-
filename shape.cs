using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    abstract class shape
    {
        public abstract double CalculateArea();
    }
    class circle: shape
    {
        private double radius;
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

    }

    class rectangle : shape
    {
        private double length;
        private double width;
        public rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }
}
