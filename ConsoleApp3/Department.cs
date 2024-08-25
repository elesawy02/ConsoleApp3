using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        #region One
        //[ForeignKey("Manager")]
        //public int MGRId { get; set; }
        ////[ForeignKey("MGRId")]
        //public Employee? Manager { get; set; }
        #endregion

        //public List<Employee> Employees { get; set; }
        //[InverseProperty("ManagedDepartment")]
        //public Employee? Manager { get; set; }
        //[InverseProperty("Department")]
        //public ICollection<Employee> employees { get; set; } = new List<Employee>();
    }
}
