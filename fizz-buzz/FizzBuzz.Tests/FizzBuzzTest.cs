using System;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    /*
    Write a program that transform any natural number between 1 and 100 into:

    "Fizz" for multiples of three.
    "Buzz" for multiples of five.
    "FizzBuzz" for numbers which are multiples of both three and five.
    The number as a string in any other case.

    Note: The program should let the user know that it can't process any input that is not valid.
    
    ** Behavior: Convert any integer into string

    ** Small behaviors: 
        if the number is a multiple of 3, return "Fizz"
        if the number is a multiple of 5, return "Buzz"
        if the number is a multiple of both 3 and 5, return "FizzBuzz"
        if the number is not a multiple of 3 or 5, return the number as a string
        if the input is not a valid integer, return an error message indicating that the input is invalid
     
    Input: A string containing a natural number between 1 and 100
    Output: A string representing the FizzBuzz result or an error message

    Examples:
    "" -> "Invalid input: Please enter a natural number between 1 and 100."
    "pepe" -> "Invalid input: Please enter a natural number between 1 and 100."
    "0" -> "Invalid input: Please enter a natural number between 1 and 100."
    "101" -> "Invalid input: Please enter a natural number between 1 and 100."
    "1" -> "1"
    "2" -> "2"
    "3" -> "Fizz"
    "5" -> "Buzz"
    "15" -> "FizzBuzz"
    "100" -> "Buzz"
     */


    public class FizzBuzzTest
    {
        [Test]
        [TestCase("")]
        [TestCase("pepe")]
        public void Translate_NotANumber_ReturnsException(string input)
        {
            Assert.Catch<ArgumentException>(() => FizzBuzzGenerator.Translate(input));
        }

        [Test]
        [TestCase("0")]
        [TestCase("101")]
        public void Translate_MaxOrMinLimits_ReturnsException(string input)
        {
            Assert.Catch<ArgumentException>(() => FizzBuzzGenerator.Translate(input));
        }

        [Test]
        [TestCase("3")]
        public void Translate_MultipleOf3_ReturnsBuzz(string input)
        {
            Assert.That(FizzBuzzGenerator.Translate(input), Is.EqualTo("Fizz"));
        }

        [Test]
        [TestCase("5")]
        [TestCase("100")]
        public void Translate_MultipleOf5_ReturnsBuzz(string input)
        {
            Assert.That(FizzBuzzGenerator.Translate(input), Is.EqualTo("Buzz"));
        }

        [Test]
        [TestCase("15")]
        public void Translate_MultipleOf3And5_ReturnsFizzBuzz(string input)
        {
            Assert.That(FizzBuzzGenerator.Translate(input), Is.EqualTo("FizzBuzz"));
        }

        [Test]
        [TestCase("1")]
        [TestCase("2")]
        public void Translate_OtherCases_ReturnsNumberAsString(string input)
        {
            Assert.That(FizzBuzzGenerator.Translate(input), Is.EqualTo(input));
        }
    }
}
