using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("Kishor", 41000);
            m1.CalculateSalary();
            Console.WriteLine(m1.DisplayManagerDetails());


            Employee e1 = new Employee("Tushar", 27000);
            e1.CalculateSalary();
            Console.WriteLine(e1.EmployeeDetails());

        }

    }
}
