using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsCSharp.Structural
{

    /*
         Real world example

        Every organization is composed of employees. Each of the employees has the same features 
        i.e. has a salary, has some responsibilities, may or may not report to someone,
        may or may not have some subordinates etc.

        In plain words

        Composite pattern lets clients treat the individual objects in a uniform manner.

        Wikipedia says
        In software engineering, the composite pattern is a partitioning design pattern. 
        The composite pattern describes that a group of objects is to be treated in the same way as a 
        single instance of an object. The intent of a composite is to "compose" objects into tree structures 
        to represent part-whole hierarchies.
        Implementing the composite pattern lets clients treat individual objects and compositions uniformly.
             */

    //Taking our employees example from above. Here we have different employee types

    interface Employee
    {
        string GetName();
        void SetSalary(float salary);
        float GetSalary();
        List<int> GetRoles();
    }

    public class Developer : Employee
    {
        protected float salary;
        protected string name;
        protected List<int> roles;
        public Developer(float salary, string name)
        {
            this.salary = salary;
            this.name = name;
        }
        public string GetName() => this.name;
        public void SetSalary(float salary) => this.salary = salary;
        public float GetSalary() => this.salary;
        public List<int> GetRoles() => this.roles;
    }

    public class Designer : Employee
    {
        protected float salary;
        protected string name;
        protected List<int> roles;

        public Designer(float salary, string name)
        {
            this.salary = salary;
            this.name = name;
        }
        public string GetName() => this.name;
        public void SetSalary(float salary) => this.salary = salary;
        public float GetSalary() => this.salary;
        public List<int> GetRoles() => this.roles;

    }
    //Then we have an organization which consists of several different types of employees

    class Organization
    {
        protected List<Employee> employees = new List<Employee>();
        public void AddEmployee(Employee employee) => this.employees.Add(employee);
        public float GetNetSalaries()
        {
            float netSalary = 0;
            foreach (var employee in employees)
            {
                netSalary += employee.GetSalary();
            }

            return netSalary;
        }
    }


    class Composite
    {
        //public static void Main(string[] args)
        //{
        //    // Prepare the employees
        //    Developer john = new Developer(10000, "John Doe");
        //    Designer jane = new Designer(15000, "Jane Doe");

        //    // Add them to organization
        //    Organization organization = new Organization();
        //    organization.AddEmployee(john);
        //    organization.AddEmployee(jane);
        //    Console.WriteLine("Net salaries: " + organization.GetNetSalaries()); // Net Salaries: 27000
        //}
    }
}
