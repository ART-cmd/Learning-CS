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

        public static void CelToFah(double celsius)
        {
            Console.WriteLine("Enter a temperature in Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }

        public static void CalGrade(int score)
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

        public static void CalLeapYear(int year)
        {
            Console.Write("Enter Year: ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a Leap year");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine(year + " is a leap year");
                }
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }

        public static void CalPrime(int number)
        {
            Console.Write("Enter your number for Prime: ");
            number = int.Parse(Console.ReadLine());

            if (number < 2)
            {
                Console.WriteLine(number + " is not a prime number.");
            }
            else if (number == 2)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine(number + " is not a prime number.");
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(number); i += 2)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(number + " is not a prime number.");
                        return;
                    }
                }
                Console.WriteLine(number + " is a prime number.");
            }
        }

        public static void CalAgeteenager(int age)
        {
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            if (age >= 15 && age <= 17)
            {
                Console.WriteLine("You are a Teenager");
            }
            else
            {
                Console.WriteLine("You are not a Teenager");
            }
        }

        public static void CalVowel(char letter)
        {

            Console.WriteLine("Enter a character:");
            letter = char.Parse(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
               letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine("The character is a vowel.");
            }
            else
            {
                Console.WriteLine("The character is a consonant.");
            }
        }

        public static void CalMonth(int monthnum)
        {
            Console.Write("Enter a month number: ");
            monthnum = int.Parse(Console.ReadLine());
            String monthname;

            switch (monthnum)
            {
                case 1:
                    monthname = "January";
                    break;
                case 2:
                    monthname = "February";
                    break;
                case 3:
                    monthname = "March";
                    break;
                case 4:
                    monthname = "April";
                    break;
                case 5:
                    monthname = "May";
                    break;
                case 6:
                    monthname = "June";
                    break;
                case 7:
                    monthname = "July";
                    break;
                case 8:
                    monthname = "August";
                    break;
                case 9:
                    monthname = "September";
                    break;
                case 10:
                    monthname = "October";
                    break;
                case 11:
                    monthname = "November";
                    break;
                case 12:
                    monthname = "December";
                    break;
                default:
                    monthname = "Invalid month number";
                    break;
            }
            Console.WriteLine(monthname);
        }
    }
}