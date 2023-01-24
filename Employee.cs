using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double basic, hra, da, ta, gross, pf;
        private static int count;
        public Employee(string name, double basic)
        {
            count++;
            id = count;
            this.name = name;
            this.basic = basic;
        }

        public virtual void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            ta = basic * 0.10;
            pf = basic * 0.12;
            gross = (basic + hra + da + ta) - pf;
        }
        public string EmployeeDetails()
        {
            return $"\n Id ={id} \n Name ={name} \n Basic Salary ={basic} \n Gross of Employee ={gross}";
        }
    }

    public class Manager : Employee
    {
        private double food, ma;
        // base keyword will call the base class constructor
        public Manager(string name, double basic) : base(name, basic)
        {

        }
        public override void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            ta = basic * 0.10;
            pf = basic * 0.12;
            food = basic * 0.05;
            ma = basic * 0.12;
            gross = (basic + hra + da + ta + food) - (pf + ma);

        }
        public string DisplayManagerDetails()
        {
            return $"\n Id ={id} \n Name ={name} \n Basic Salary ={basic} \n Gross of Manager ={gross}";
        }
    }

}
