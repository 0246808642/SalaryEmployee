using SalaryEmployee.Entities;
using System.Globalization;

namespace SalaryEmployee
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours:");
                int hours = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Value per hour: ");
                double valuePerHour =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {  
                   list.Add(new Employee(name, hours, valuePerHour));
                }

                
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (Employee em in list)
            {
                Console.WriteLine(em.Name + "- $" + em.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
