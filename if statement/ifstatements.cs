using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.if_statement
{
    public class ifstatements
    {
        public static void OddEvenNumber(int number)
        {
            Console.Write("Enter Your number: ");
            number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("This number is Even number");
            }
            else
            {
                Console.WriteLine("This number is Odd number");
            }
        }

        public static void CelsciustoFahrenheit(double celsius)
        {
            Console.WriteLine("Enter a temperature in Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }

        public static void CalculateGrade(int score)
        {
            Console.Write("Enter your score: ");
            score = int.Parse(Console.ReadLine());

            if (score >= 80)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Your Grade is B");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Your Grade is C");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Your Grade is D");
            }
            else
            {
                Console.WriteLine("Your Grade is F");
            }
        }
    }
}