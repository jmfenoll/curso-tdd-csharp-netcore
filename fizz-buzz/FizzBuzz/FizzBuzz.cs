using System;
using System.Reflection.Metadata.Ecma335;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static string Translate(string input)
        {
            if (!IsNumber(input))
                throw new ArgumentException("Invalid input: Please enter a natural number between 1 and 100.");

            var intInput= int.Parse(input);

            if (!IsInsideTheLimits(intInput))
                throw new ArgumentException("Invalid input: Please enter a natural number between 1 and 100.");

            if (IsMultipleOf(intInput, 3) && IsMultipleOf(intInput, 5))
                return "FizzBuzz";

            if (IsMultipleOf(intInput, 3))
                return "Fizz";

            if (IsMultipleOf(intInput, 5))
                return "Buzz";

            return intInput.ToString();
        }


        private static bool IsMultipleOf(int intInput, int multiple)
        {
            return intInput % multiple == 0;
        }

        private static bool IsInsideTheLimits(int input)
        {
            return input >= 1 && input <= 100;
        }

        private static bool IsNumber(string input)
        {
            return int.TryParse(input, out int number);
        }
    }
}
