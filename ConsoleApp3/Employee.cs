using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        //[ForeignKey("Department")]
        //public int DeptId { get; set; }
        //public Department? Department { get; set; }

        //public Department? ManagedDepartment { get; set; }
    }
}
