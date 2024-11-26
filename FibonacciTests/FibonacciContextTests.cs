using System.Collections.Generic;
using FibonacciLibrary;
using Xunit;

namespace FibonacciTests
{
    public class FibonacciContextTests
    {
        [Fact]
        public void GenerateFibonacci_ValidInput_UsesProvidedGenerator()
        {
            var generator = new FibonacciGenerator();
            var context = new FibonacciContext(generator);
            List<long> result = context.GenerateFibonacci(5);
            Assert.Equal(new long[] { 0, 1, 1, 2, 3 }, result.ToArray());
        }
    }
}
