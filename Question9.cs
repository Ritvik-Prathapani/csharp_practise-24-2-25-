using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    interface IPrintable
    {
        void print();
    }
    interface ISerializable
    {
        void savetofile(string content);
    }
    class report: IPrintable, ISerializable
    {
        public string content;
        public report(string content)
        {
            this.content = content;
        }

        public void print()
        {
            Console.WriteLine(content);
        }
        public void savetofile(string filename)
        {
            File.WriteAllText(filename, content);
        }
    }
}
