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
            bool isPresent = random.Next(0, 2) == 0;

            if (isPresent)
            {
                int fullTimeWorkHours = 8;
                int hourlyPayRate = 20;
                int dailyWage = fullTimeWorkHours * hourlyPayRate;
                Console.WriteLine("Employee is present.");
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
