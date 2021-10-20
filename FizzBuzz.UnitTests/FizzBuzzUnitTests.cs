using System;
using Xunit;
using FizzBuzz.Domain;

namespace FizzBuzz.UnitTests
{
    public class FizzBuzzUnitTests
    {
        private readonly FizzBuzzCalculator sut;

        public FizzBuzzUnitTests()
        {
            sut = new FizzBuzzCalculator();
        }

        [Fact]
        public void FizzBuzz_OfThree_ReturnsFizz()
        {
            //Arranjar
            var expected = "Fizz";

            //Acionar
            var actual = sut.GetFizzBuzz(3);

            //Averiguar
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzz_OfFive_ReturnsBuzz()
        {
            //Arranjar
            var expected = "Buzz";

            //Acionar
            var actual = sut.GetFizzBuzz(5);

            //Averiguar
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzz_OfFiveAndThree_ReturnsFizzBuzz()
        {
            //Arranjar
            var expected = "FizzBuzz";

            //Acionar
            var actual = sut.GetFizzBuzz(30);

            //Averiguar
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FizzBuzz_OfNumber_ReturnsNumber()
        {
            //Arranjar
            var expected = "2";

            //Acionar
            var actual = sut.GetFizzBuzz(2);

            //Averiguar
            Assert.Equal(expected, actual);
        }
    }
}