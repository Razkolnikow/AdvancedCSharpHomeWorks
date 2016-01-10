using System;
using System.Collections.Generic;

namespace _05ReverseNumber
{
    class Program
    {
        static void Main()
        {
            double reversed = GetReversedNumber(123.45);
            Console.WriteLine(reversed);
        }

        static double GetReversedNumber(double number)
        {
            string digitContainer = number.ToString();
            List<char> digits = new List<char>();
            for (int i = 0; i < digitContainer.Length; i++)
            {
                digits.Add(digitContainer[i]);
            }

            digits.Reverse();
            digitContainer = string.Join("", digits);
            double result = double.Parse(digitContainer);
            return result;
        }
    }
}
