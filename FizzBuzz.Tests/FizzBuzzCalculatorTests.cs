using System.Collections.Generic;
using NUnit.Framework;
using Shouldly;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzCalculatorTests
    {
        [Test]
        public void FizzBuzzCalculator_builds_message_and_returns_results()
        {
            // Arrange
            var specifications = new Dictionary<int, string>()
            {
                {3, "fizz"},
                {5, "buzz"},
                {6, "burp"},
                {7, "fart"},
                {9, "beep"},
            };

            var sut = new FizzBuzzCalculator();

            // Act
            var result = sut.Calculate(1, 25, specifications);

            // Assert
            result[3].ShouldBe("fizz");
            result[15].ShouldBe("fizzbuzz");
        }
    }
}