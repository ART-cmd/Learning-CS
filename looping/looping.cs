using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CS.looping
{
    public class loopings
    {
        public static void LoopOnetoTen()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            for (int a = 1; a <= 10; a++)
            {
                Console.WriteLine(a);
            }
        }

        public static void CalFactorial(int number)
        {
            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());
            int factorial = 1;
            int i = 1;
            while (i <= number)
            {
                factorial *= i;
                i++;
            }
            Console.WriteLine("The factorial of " + number + " is " + factorial);
        }

        public static void MultiplyTable(int number)
        {
            Console.WriteLine("Enter number:");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(number + "*" + i + "*" + (number * i));
            }

            Console.WriteLine("Enter a number:");
            number = int.Parse(Console.ReadLine());
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(number + " x " + j + " = " + (number * j));
                j++;
            }
        }

        public static void Findsum(int n)
        {
            Console.Write("Enter number:");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            while (i <= n)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("The sum of the first " + n + " natural numbers is " + sum);
        }
    }
}