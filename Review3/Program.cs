//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Transactions;

//class Employee
//{
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//    public string Department { get; set; }

//    public Employee(string name, decimal salary, string department)
//    {
//        Name = name;
//        Salary = salary;
//        Department = department;
//    }
//}

//class Program
//{
    
//    public static List<Employee> SearchByDepartment(List<Employee> employees, string department)
//    {
//       // return employees.Where(emp => emp.Department == department).ToList();

//            List<Employee> result = new List<Employee>();  

//            foreach (Employee emp in employees)
//            {
//                if (emp.Department == department)  
//                {
//                    result.Add(emp); 
//                }
//            }

//            return result;  
//        }
    

//    static void Main(string[] args)
//    {
        
//        List<Employee> employees = new List<Employee>
//        {
//            new Employee("Vaibhav", 50000, "IT"),
//            new Employee("Sujal", 60000, "HR"),
//            new Employee("Raj", 55000, "IT"),
//            new Employee("Rohit", 52000, "Finance")
//        };


//        Console.WriteLine("Departments");
//        Console.WriteLine("HR , IT , Finance");
//        Console.Write("Enter the name of the Deparment From Above :");
//        string depart = Console.ReadLine();


       
//        List<Employee> itEmployees = SearchByDepartment(employees, depart);

       
//        foreach (Employee emp in itEmployees)
//        {
//            Console.WriteLine($"Name: {emp.Name}, Salary: {emp.Salary}, Department: {emp.Department}");
//        }
//    }
//}
