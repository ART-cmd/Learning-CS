using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS.if_statement
{
    public class ifstatements_2
    {
        public static void CalnumberPositive(int number)
        {
            Console.Write("Enter your number:");
            number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine(number + " is a Positive Number");
            }
            else if (number < 0)
            {
                Console.WriteLine(number + " is a Negative Number");
            }
            else 
            {
                Console.WriteLine(number + " is a Zero Number");
            }
        }

        public static void CheckValidPass(String password)
        {
            Console.Write("Enter your Password:");
            password = Console.ReadLine();

            bool isValid = true;
            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long.");
                isValid = false;
            }
            if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Password must contain at least one uppercase letter");
                isValid = false;
            }
            if (!password.Any(char.IsLower))
            {
                Console.WriteLine("Password must contain at least one lowercase letter");
                isValid = false;
            }
            if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Password must contain at least one number letter");
                isValid = false;
            }
            if (isValid)
            {
                Console.WriteLine("Password is Valid");
            }
        }
    }
}