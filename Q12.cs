using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_exam
{
    using System;

    class Manager
    {
        public string Name;

        public Manager(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string DeptName;
        public Manager DeptManager;

        public Department(string deptName, string managerName)
        {
            DeptName = deptName;
            DeptManager = new Manager(managerName);
        }

        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone(); // Only copies references
        }

        public Department DeepCopy()
        {
            Department newDept = (Department)this.MemberwiseClone();
            newDept.DeptManager = new Manager(this.DeptManager.Name); // New object for reference type
            return newDept;
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DeptName}, Manager: {DeptManager.Name}");
        }
    }

}
