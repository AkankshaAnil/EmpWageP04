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
            Console.WriteLine(" Welcome to Employment Wage Problem 101");

            Random random = new Random();
            bool isPresent = random.Next(2) == 0;

            if (isPresent)
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");

            }
        }
    }
}
