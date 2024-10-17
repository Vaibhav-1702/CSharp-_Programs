using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Review4
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int MonthsSinceJoining { get; set; }  // Number of months since the employee joined
    }

    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Vaibhav", Department = "IT", MonthsSinceJoining = 4 },
            new Employee { Name = "Raj", Department = "HR", MonthsSinceJoining = 7 },
            new Employee { Name = "Sujal", Department = "IT", MonthsSinceJoining = 3 }
        };


            Console.Write("Enter the departerment : ");
            string targetDepartment = Console.ReadLine();
            Console.Write("Enter Maximum Months : ");
            int maxMonths = int.Parse(Console.ReadLine());



            var recentEmployees = employees
                .Where(e => e.Department == targetDepartment || e.MonthsSinceJoining <= maxMonths)
                .ToList();

            recentEmployees.ForEach(e =>
                Console.WriteLine($"{e.Name} - {e.Department} - {e.MonthsSinceJoining} months since joining"));
        }
    }

}
