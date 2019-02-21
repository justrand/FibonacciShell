using System;
using System.Collections.Generic;

namespace FibonacciShell
{

    /// <summary>
    /// Static class for printing UI
    /// </summary>
    static class UI
    {
        public static void PrettyPrint(List<int> printThis)
        {
            printThis.ForEach(i => Console.Write("{0}  ", i));
            Console.Write('\n');
        }

        public static void PrettyPrint(List<double> printThis)
        {
            printThis.ForEach(i => Console.Write("{0}\n", i));
            Console.Write('\n');
        }
        public static void PrintTitle(string title)
        {
            Console.Write("\n=== " + title+" ===\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci(20);
            UI.PrintTitle("Fibonacci Series");
            UI.PrettyPrint(fib.Series);
            UI.PrintTitle("Golden Ratio with formula");
            Console.WriteLine((1 + Math.Sqrt(5)) / 2);
            UI.PrintTitle("Golden Ratio from series");
            UI.PrettyPrint(fib.GetGoldenRatio());

            Nthnacci nth = new Nthnacci(20, 3);
            UI.PrintTitle("Tribonacci Series");
            UI.PrettyPrint(nth.Series);
            
        }
    }
}
