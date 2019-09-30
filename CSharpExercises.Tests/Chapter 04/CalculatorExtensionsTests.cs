using Xunit;
using CSharpExercises.Classes.Chapter_04;

namespace CSharpExercises.Tests.Chapter_04
{
    public class CalculatorExtensionsTests
    {
        [Fact]
        public void CanCreateValuesDefaultInstance()
        {
            var values = new Values(10, 20);

            Assert.NotNull(values);
            Assert.Equal(10, values.value1);
            Assert.Equal(20, values.value2);
            Assert.Equal(default, values.result);
            Assert.Equal(default, values.@operator);
        }

        [Fact]
        public void CanCallAddExtensionMethod()
        {
            var values = new Values(10, 20);
            values.Add();
            var output = values.Output();

            Assert.NotNull(values);
            Assert.Equal(30, values.result);
            Assert.Equal("10 + 20 = 30", output);
        }

        [Fact]
        public void CanCallAddAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Add().Output();

            Assert.NotNull(values);
            Assert.Equal(30, values.result);
            Assert.Equal("10 + 20 = 30", output);
        }

        [Fact]
        public void CanCallSubtractAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Subtract().Output();

            Assert.NotNull(values);
            Assert.Equal(-10, values.result);
            Assert.Equal("10 - 20 = -10", output);
        }

        [Fact]
        public void CanCallDivideAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Divide().Output();

            Assert.NotNull(values);
            Assert.Equal(0.5, values.result);
            Assert.Equal("10 / 20 = 0.5", output);
        }

        [Fact]
        public void CanCallMultiplyAndOutputExtensionMethods()
        {
            var values = new Values(10, 20);
            var output = values.Multiply().Output();

            Assert.NotNull(values);
            Assert.Equal(200, values.result);
            Assert.Equal("10 x 20 = 200", output);
        }
    }
}
