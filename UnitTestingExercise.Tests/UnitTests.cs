using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 2, 3, 7)]
        [InlineData(-1, 3, 5, 7)]
        [InlineData(10, 50, 0, 60)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.AddTool(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(2, 0, 2)]
        [InlineData(-1, 10, -11)]
        [InlineData(60, 15, 45)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.SubtractTool(minuend, subtrhend);
            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(0, 10, 0)]
        [InlineData(-10, 5, -50)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.MultiplyTool(num1, num2);
            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(0, 25, 0)]
        [InlineData(-20, 4, -5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.DivideTool(num1, num2);
            //Assert
            Assert.Equal(actual, expected);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.SayHello();
            //Assert
            Assert.Equal("Hello", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.PlusMinus(2, 4, 1);
            //Assert
            Assert.Equal(5, actual);
        }
    }
}
