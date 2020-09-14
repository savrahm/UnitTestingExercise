using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(4,7,2,13)]
        [InlineData(-4,7,-2,1)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 5, 3)]
        [InlineData(10, 2, 8)]
        [InlineData(10, 15, -5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(7,-3,-21)]
        [InlineData(8,0,0)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(8,4,2)]
        [InlineData(100,10,10)]
        [InlineData(-20,-4,5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Hello()
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Hello();

            //Assert
            Assert.Equal(actual, "Hello");

        }

        [Fact]
        public void Dog()
        {
            //Arrange
            var expected = "woof";

            //Act
            var actual = UnitTestMethods.Dog();

            //Assert
            Assert.Equal(actual, expected);
        }
    }
}
