using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(2, 3, -5, 0)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            
            var calculator = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            var actual = calculator.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 5, 5)]//Add test data <-------
        [InlineData(5, 10, -5)]
        [InlineData(10, -5, 15)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange

            var calculator = new Calculator();

            //Act

            var actual = calculator.Subtract(minuend, subtrahend);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 2, 10)]//Add test data <-------
        [InlineData(-5, -2, 10)]
        [InlineData(5, -2, -10)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            var calculator = new Calculator();

            //Act

            var actual = calculator.Multiply(num1, num2);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 5)]//Add test data <-------
        [InlineData(2, 10, 0)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            var calculator = new Calculator();

            //Act

            var actual = calculator.Divide(num1, num2);

            //Assert

            Assert.Equal(expected, actual);
        }

    }
}
