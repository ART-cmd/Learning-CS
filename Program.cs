using static CS.if_statement.ifstatements;
using static CS.if_statement.ifstatements_2;
using static CS.condition.conditions;
using static CS.array.arrays;
using static CS.looping.loopings;

namespace learning_cs
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            byte: an 8-bit unsigned integer, such as 0 to 255
            sbyte: an 8-bit signed integer, such as -128 to 127
            short : a 16-bit signed integer, such as -32,768 to 32,767
            ushort : a 16-bit unsigned integer, such as 0 to 65,535
            int : a 32-bit unsigned integer, such as 0 to 4,294,967,295
            ulong : a 64-bit unsigned integer, such as 0 to 18,446,744,073,709,551,615

            int (integer): a whole number, such as -2, 0, or 100
            long (long integer): a larger whole number, such as -2,147,483,648 to 2,147,483,647
            float (single-precision floating-point): a number with a decimal point, such as -3.14 or 0.01
            double (double-precision floating-point): a larger number with a decimal point, such as -3.14 or 0.01
            decimal: a precise decimal number with a larger range and precision than a float or double
            */

            // IF-STATEMENT //

            OddEvenNumber(0);
            CelToFah(0);
            CalGrade(0);
            CalLeapYear(0);
            CalPrime(0);
            CalAgeteenager(0);
            CalVowel('_');
            CalMonth(0);
            CalnumberPositive(0);
            CheckValidPass("");

            // IF-STATEMENT //


            // loop //

            LoopOnetoTen();
            CalFactorial(0);
            MultiplyTable(0);
            Findsum(0);

            // loop //

        }
    }
}