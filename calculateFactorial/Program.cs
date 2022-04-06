using System;

namespace calculateFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int factorial = 1;

            Console.WriteLine("***************************");
            Console.WriteLine("    Factorial Number App   ");
            Console.WriteLine("***************************");
            Console.WriteLine("");            
            Console.WriteLine("Enter the number to execute");
            Console.WriteLine("");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i >= 1; i--)
            {
                factorial *= i;
                Console.WriteLine("Factorial of {0}! * {1} = {2}\n", number, i, factorial);
            }
            

            Console.WriteLine("The factorial of " + number + " results in " + factorial);
            Console.ReadLine();

        }
    }
}
