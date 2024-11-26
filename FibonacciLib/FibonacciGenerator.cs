using System;
using System.Collections.Generic;

namespace FibonacciLibrary
{
    public class FibonacciGenerator : IFibonacciGenerator
    {
        public List<long> Generate(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException(nameof(n), "Число n должно быть больше 0.");

            var fibonacciNumbers = new List<long>(n);
            if (n >= 1) fibonacciNumbers.Add(0);
            if (n >= 2) fibonacciNumbers.Add(1);

            for (int i = 2; i < n; i++)
            {
                long nextNumber = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
                fibonacciNumbers.Add(nextNumber);
            }

            return fibonacciNumbers;
        }
    }
}
