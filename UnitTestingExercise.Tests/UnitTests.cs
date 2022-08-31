using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator calc = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int actual = calc.Add(num1, num2, num3);    

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,3,2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int actual = calculator.Subtract(5, 3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,2,6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Multiply(3, 2);
            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(6,2,3)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actual = calc.Divide(6,2);

            //Assert
            Assert.Equal(actual, expected);

        }

    }
}
