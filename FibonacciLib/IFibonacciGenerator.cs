using System.Collections.Generic;

namespace FibonacciLibrary
{
    public interface IFibonacciGenerator
    {
        List<long> Generate(int n);
    }
}
