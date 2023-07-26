using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageP04
{
    class attendence
    {
        public  void FindAttendence()
        {
            Console.WriteLine("Welcome to the Employee Wage Calculator!");

            Random random = new Random();
            int workType = random.Next(0, 3);

            int workHours;
            int hourlyPayRate;
            int dailyWage;

            switch (workType)
            {
                case 0: // Full-time
                    workHours = 8;
                    hourlyPayRate = 20;
                    dailyWage = workHours * hourlyPayRate;
                    Console.WriteLine("Employee is present and working full-time.");
                    Console.WriteLine("Daily wage: $" + dailyWage);
                    break;
                case 1: // Part-time
                    workHours = 4;
                    hourlyPayRate = 20;
                    dailyWage = workHours * hourlyPayRate;
                    Console.WriteLine("Employee is present and working part-time.");
                    Console.WriteLine("Daily wage: $" + dailyWage);
                    break;

                case 2: // Absent
                    Console.WriteLine("Employee is absent.");
                    Console.WriteLine("No daily wage earned.");
                    break;

                default:
                    Console.WriteLine("Invalid work type.");
                    break;

            }
        }
    }
}
