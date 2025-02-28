using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    class user
    {
        protected string name;
        protected string role;
        public user(string name,string role)
        {
            this.name = name;
            this.role = role;
        }
        public virtual void access()
        {
            Console.WriteLine($"{name} {role}");
        }
    }
    class admin: user
    {
        public admin(string user): base(user,"admin")
        {}
        public override void access()
        {
            Console.WriteLine($"{name} {role}");
        }
    }
    class customer: user
    {
        public customer(string user) : base(user, "customer") { }
        public override void access()
        {
            Console.WriteLine($"{name} {role}");
        }
    }
}
