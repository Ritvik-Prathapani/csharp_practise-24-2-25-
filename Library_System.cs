using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class Library_System
    {
        public Library_System()
        {
            Console.WriteLine("this is a library system");
        }
        public Library_System(string title, string author)
        {
            Console.WriteLine($"title is {title} and author is {author}");
        }
        public Library_System(string title, int isbn)
        {
            Console.WriteLine($"title is {title} and isbn is {isbn}");
        }
    }
}
