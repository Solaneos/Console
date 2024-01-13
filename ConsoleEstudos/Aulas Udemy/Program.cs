using ConsoleEstudos.Aulas_Udemy.Entities;
using ConsoleEstudos.Aulas_Udemy.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEstudos.Aulas_Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            var deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            Enum.TryParse(Console.ReadLine(), out WorkerLevel level);
            //WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            var baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dpt = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dpt);

            Console.Write("How many contracts to this worker? ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                var date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                var valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                var hours = int.Parse(Console.ReadLine());

                var contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculete income (MM/YYYY): ");
            var monthAndYear = Console.ReadLine();

            var month = int.Parse(monthAndYear.Substring(0, 2));
            var year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
