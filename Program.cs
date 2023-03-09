using System.ComponentModel.Design;

namespace Leap_Year
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Year;
            Console.WriteLine("check weather a give year is leap year or not");

            Console.WriteLine("Input an year : ");

            Year=Convert.ToInt32(Console.ReadLine());

            //if (( Year % 400) == 0)
            //  Console.WriteLine("{0} is a leap year.\n", Year);
            // else if (( Year % 100) == 0)
            //   Console.WriteLine("{0} is not a leap year.\n", Year);
            //else if ((Year % 4) == 0) 
            //  Console.WriteLine("{0} is a leap year.\n", Year);
            // else 
            //  Console.WriteLine("{0} is not a leap year .\n", Year);

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) 
            Console.WriteLine("Is a leap year .\n", Year);
            else
                Console.WriteLine("{0}is not a leap year ", Year);

        }
    }
}