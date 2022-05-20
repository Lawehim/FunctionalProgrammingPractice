using System;
using Workings;

namespace FunctionalProgrammingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var discount = ComputeExample.CalculateDiscount(100, 5);
            Console.WriteLine(discount);
        }
    }
}
