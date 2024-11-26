using System;
using System.Collections.Generic;

namespace FibonacciLibrary
{
    public class FibonacciContext
    {
        private readonly IFibonacciGenerator _generator;

        public FibonacciContext(IFibonacciGenerator generator)
        {
            if (generator == null)
                throw new ArgumentNullException(nameof(generator));
            _generator = generator;
        }

        public List<long> GenerateFibonacci(int n)
        {
            return _generator.Generate(n);
        }
    }
}
