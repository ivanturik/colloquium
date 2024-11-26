using System.Collections.Generic;
using FibonacciLibrary;
using Xunit;

namespace FibonacciTests
{
    public class FibonacciGeneratorTests
    {
        [Theory]
        [InlineData(1, new long[] { 0 })]
        [InlineData(2, new long[] { 0, 1 })]
        [InlineData(5, new long[] { 0, 1, 1, 2, 3 })]
        public void Generate_ValidInput_ReturnsCorrectSequence(int n, long[] expected)
        {
            var generator = new FibonacciGenerator();
            List<long> result = generator.Generate(n);
            Assert.Equal(expected, result.ToArray());
        }

        [Fact]
        public void Generate_NegativeOrZero_ThrowsArgumentOutOfRangeException()
        {
            var generator = new FibonacciGenerator();
            Assert.Throws<ArgumentOutOfRangeException>(() => generator.Generate(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => generator.Generate(-1));
        }
    }
}
