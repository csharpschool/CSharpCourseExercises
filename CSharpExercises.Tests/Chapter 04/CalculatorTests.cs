using Xunit;
using CSharpExercises.Classes.Chapter_04;

namespace CSharpExercises.Tests.Chapter_04
{
    public class CalculatorTests
    {
        [Fact]
        public void CanCreateCalculatorDefaultInstance()
        {
            var calc = new Calculator();

            Assert.NotNull(calc);
        }

        [Fact]
        public void CanCallAddMethod()
        {
            var calc = new Calculator();

            var result = calc.Add(10, 20);

            Assert.NotNull(calc);
            Assert.Equal(30, result);
        }

        [Fact]
        public void CanCallAddMethodWithOutParameter()
        {
            var calc = new Calculator();

            var result = calc.Add(10, 20, out string output);

            Assert.NotNull(calc);
            Assert.Equal(30, result);
            Assert.Equal("10 + 20 = 30", output);
        }

        [Fact]
        public void CanCallSubtractMethod()
        {
            var calc = new Calculator();

            var result = calc.Subtract(10, 20);

            Assert.NotNull(calc);
            Assert.Equal(-10, result);
        }

        [Fact]
        public void CanCallSubtractMethodWithOutParameter()
        {
            var calc = new Calculator();

            var result = calc.Subtract(10, 20, out string output);

            Assert.NotNull(calc);
            Assert.Equal(-10, result);
            Assert.Equal("10 - 20 = -10", output);
        }

        [Fact]
        public void CanCallDivideMethod()
        {
            var calc = new Calculator();

            var result = calc.Divide(10, 20);

            Assert.NotNull(calc);
            Assert.Equal(0.5, result);
        }

        [Fact]
        public void CanCallDivideMethodWithOutParameter()
        {
            var calc = new Calculator();

            var result = calc.Divide(10, 20, out string output);

            Assert.NotNull(calc);
            Assert.Equal(0.5, result);
            Assert.Equal("10 / 20 = 0.5", output);
        }

        [Fact]
        public void DivideMethodCanHandleDivideByZero()
        {
            var calc = new Calculator();
            var result = calc.Divide(10, 0);

            Assert.NotNull(calc);
            Assert.True(double.IsInfinity(result));
        }

        [Fact]
        public void CanCallMultiplyMethod()
        {
            var calc = new Calculator();

            var result = calc.Multiply(10, 20);

            Assert.NotNull(calc);
            Assert.Equal(200, result);
        }

        [Fact]
        public void CanCallMultiplyMethodWithOutParameter()
        {
            var calc = new Calculator();

            var result = calc.Multiply(10, 20, out string output);

            Assert.NotNull(calc);
            Assert.Equal(200, result);
            Assert.Equal("10 x 20 = 200", output);
        }

    }
}
