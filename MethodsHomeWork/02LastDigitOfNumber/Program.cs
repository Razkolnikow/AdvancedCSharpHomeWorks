using System;

namespace _02LastDigitOfNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetLastDigitOfNumberAsWord(512));
            Console.WriteLine(GetLastDigitOfNumberAsWord(1024));
            Console.WriteLine(GetLastDigitOfNumberAsWord(12309));
        }

        static string GetLastDigitOfNumberAsWord(int number)
        {
            string digitsOfNumber = number.ToString();
            char result = digitsOfNumber[digitsOfNumber.Length - 1];
            return GetDigitAsWord(result);
        }

        static string GetDigitAsWord(char digit)
        {
            switch (digit)
            {
                case '0':
                    return "zero";
                    break;
                case '1':
                    return "one";
                    break;
                case '2':
                    return "two";
                    break;
                case '3':
                    return "three";
                    break;
                case '4':
                    return "four";
                    break;
                case '5':
                    return "five";
                    break;
                case '6':
                    return "six";
                    break;
                case '7':
                    return "seven";
                    break;
                case '8':
                    return "eight";
                    break;
                case '9':
                    return "nine";
                    break;
                default: throw new ArgumentException("This is not a digit!");
            }
        }
    }
}
