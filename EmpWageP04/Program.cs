﻿using EmpWageP04;

internal class Program
{
    public static void Main()
        {

        Console.WriteLine("Hello Fellow Learners!\nWelcome to Employee Wage Problem.\nEnter the index no. of the program you want to run.");
        Console.WriteLine("1.Basic Code\n2.Refactored Code");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                employee search = new employee();
                search.EmployeeWage();
                break;
            case 2:
                EmployeeWageCalculator employeeWageCalculator1 = new EmployeeWageCalculator();
                EmployeeWageCalculator.ComputeEmployeeWage();
                break;
            default:
                Console.WriteLine("Please Enter a Valid Index No.");
                break;
        }
        Console.ReadLine();
    }
    }
