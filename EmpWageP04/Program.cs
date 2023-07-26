using EmpWageP04;

internal class Program
{
    public static void Main()
        {
            Console.WriteLine("Hello User! Welcome.");
            Console.WriteLine("Please enter the purpose of your searching");
            string purpose = Console.ReadLine();
            Console.WriteLine(" " + purpose);
            Console.WriteLine("Let's begin!");

            attendence search = new attendence();
            search.FindAttendence();

            Console.ReadLine();
        }
    }
