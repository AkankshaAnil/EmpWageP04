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
            int attendance = random.Next(0, 3);

            if (attendance == 1)
            {
                int fullTimeWorkHours = 8;
                int hourlyPayRate = 20;
                int dailyWage = fullTimeWorkHours * hourlyPayRate;
                Console.WriteLine("Employee is present.");
                Console.WriteLine("Daily wage: $" + dailyWage);
            }
            else if (attendance == 2)
            {
                int PartTimeWorkHours = 4;
                int hourlyPayRate = 20;
                int dailyWage = PartTimeWorkHours * hourlyPayRate;
                Console.WriteLine("Employee is present part-time.");
                Console.WriteLine("Daily wage: $" + dailyWage);
            }
            else
            {
                Console.WriteLine("Employee is absent.");
                Console.WriteLine("No daily wage earned.");
            }
        }
    }
}
