using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class Student
    {
        private string _name;
        private int _rollno;
        public string name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("enter a proper value");
                _name = value;
            }
        }
        
        public int rollno
        {
            get { return _rollno; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("enter a value greater than 0");
                _rollno = value;
            }
        }
        public Student(string inputname, int inputrollno)
        {
            this.name = inputname;
            this.rollno = inputrollno;
        }
        public void Display()
        {
            Console.WriteLine($"{this.name} {this.rollno}");
        }
    }
}
