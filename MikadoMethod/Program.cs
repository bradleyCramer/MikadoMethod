using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager manager = new EmployeeManager();
            manager.AddEmployee("John Doe", 30, "Finance");
            manager.AddEmployee("Jane Smith", 28, "HR");
            manager.AddEmployee("Emily Davis", 42, "Finance");
            manager.AddEmployee("Mark Taylor", 35, "IT");
            manager.AddEmployee("Sarah Brown", 32, "HR");
            manager.AddEmployee("Mike Johnson", 45, "IT");
            manager.DisplayEmployees();
        }
    }

    class EmployeeManager
    {
        private List<Employee> employees = new List<Employee>();

        public void AddEmployee(string name, int age, string department)
        {
            employees.Add(new Employee(name, age, department));
        }

        public void DisplayEmployees()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}, Department: {employee.Department}");
            }
        }
    }

    class Employee
    {
        public string Name { get; }
        public int Age { get; }
        public string Department { get; }

        public Employee(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }
    }
}
