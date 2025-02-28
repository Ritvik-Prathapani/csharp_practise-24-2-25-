using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class Person
    {
        protected string name;
        protected int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual string getDetails()
        {
            return $"{name} {age}";
        }
    }
    class Stu: Person
    {
        private int rollno;
        private int cls;
        public Stu(string name,int age, int rollno, int cls): base(name,age)
        {
            this.rollno = rollno;
            this.cls = cls;
        }
        public override string getDetails()
        {
            return $"{name} {age} {rollno} {cls}";
        }
    }
    class Teacher: Person
    {
        private string subject;
        public Teacher(string name, int age,string subject): base(name,age)
        {
            this.subject = subject;
        }
    }
}
