using Shouldly;

namespace FizzBuzz.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class IntegerExtensionsTests
    {
        [Test]
        public void The_laws_of_mathematics_continue_uninterrupted()
        {
            3.IsDivisibleBy(2).ShouldBeFalse();
            4.IsDivisibleBy(2).ShouldBeTrue();
            4.IsDivisibleBy(4).ShouldBeTrue();
            0.IsDivisibleBy(5).ShouldBeTrue();
        }

        [Test]
        public void Dividing_by_zero_does_not_destroy_the_universe()
        {
            5.IsDivisibleBy(0).ShouldBeFalse();
        }
    }
}