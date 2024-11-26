using System;
using System.Collections.Generic;
using FibonacciLibrary;

namespace FibonacciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число n:");
                int n = int.Parse(Console.ReadLine());

                var generator = new FibonacciGenerator();
                var context = new FibonacciContext(generator);

                List<long> fibonacci = context.GenerateFibonacci(n);

                Console.WriteLine("Числа Фибоначчи:");
                Console.WriteLine(string.Join(" ", fibonacci));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное число.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
