using ConsoleApp3;
using ConsoleApp3;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Create
            Employee emp1 = new Employee() { Name = "Ahmed", Age = 20, Salary = 30000 };
            Employee emp2 = new Employee() { Name = "Ali", Age = 22, Salary = 30000 };

            using CompanyDbContext Context = new CompanyDbContext();


            //Console.WriteLine(Context.Entry(emp1).State);
            //Console.WriteLine(Context.Entry(emp2).State);

            //Console.WriteLine("===============================================");
            //Context.Employees.Add(emp1);
            //Context.Employees.Add(emp2);


            //Console.WriteLine(Context.Entry(emp1).State);
            //Console.WriteLine(Context.Entry(emp2).State);
            //Console.WriteLine("===============================================");

            Context.SaveChanges();
            //Console.WriteLine(Context.Entry(emp1).State);
            //Console.WriteLine(Context.Entry(emp2).State);
            #endregion

            #region retrive
            //var employees = Context.Employees.Where(e => e.Salary > 1000).AsNoTracking();

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.Name);
            //    Console.WriteLine(Context.Entry(employee).State);
            //}
            #endregion

            #region update
            //var emp = Context.Employees.FirstOrDefault(e => e.Id == 2);

            //if (emp is not null)
            //{
            //    Console.WriteLine(Context.Entry(emp).State);

            //    emp.Name = "Omar";
            //    Console.WriteLine("========================");
            //    Context.Employees.Update(emp);
            //    Console.WriteLine(Context.Entry(emp).State);


            //    Context.SaveChanges();
            //    Console.WriteLine("========================");
            //    Console.WriteLine(Context.Entry(emp).State);

            //}
            #endregion

            #region delete
            //var emp = Context.Employees.FirstOrDefault(e => e.Id == 2);

            //if (emp is not null)
            //{
            //    Console.WriteLine(Context.Entry(emp).State);

            //    Console.WriteLine("========================");
            //    Context.Employees.Remove(emp);
            //    Console.WriteLine(Context.Entry(emp).State);


            //    Context.SaveChanges();
            //    Console.WriteLine("========================");
            //    Console.WriteLine(Context.Entry(emp).State);

            //}
            #endregion


            Department department = new Department();


        }
    }
}
