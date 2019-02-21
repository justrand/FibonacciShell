using System;
using System.Collections.Generic;

namespace FibonacciShell
{

    /// <summary>
    /// Static class for printing UI
    /// </summary>
    static class UI
    {
        /// <summary>
        /// Separator type for pretty printing list
        /// </summary>
        public enum SeparatorType
        {
            Space = 1,
            TwoSpaces,
            LineBreak,
            Tab
        }

        /// <summary>
        /// Private handler for getting a string that matches the separator
        /// </summary>
        /// <param name="separatorType">Separator enumeration</param>
        /// <returns></returns>
        private static string GetSeparator(SeparatorType separatorType)
        {
            switch(separatorType)
            {
                case SeparatorType.Space:
                    return new string(" ");
                case SeparatorType.TwoSpaces:
                    return new string("  ");
                case SeparatorType.LineBreak:
                    return new string("\n");
                case SeparatorType.Tab:
                    return new string("\t");
                default: return new string("  ");
            }
        }

        /// <summary>
        /// Method to print a list of numbers. Would work for strings too but not for objects
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="printThis"></param>
        /// <param name="separatorType"></param>
        private static void PrettyPrintNumber<T>(List<T> printThis, SeparatorType separatorType = SeparatorType.TwoSpaces)
        {
            printThis.ForEach(i => Console.Write("{0}{1}", i, GetSeparator(separatorType)));
            Console.Write('\n');
        }

        /// <summary>
        /// Pretty prints a list of integers
        /// </summary>
        /// <param name="printThis">List to print</param>
        /// <param name="separatorType">Separator character to use</param>
        public static void PrettyPrint(List<int> printThis, SeparatorType separatorType = SeparatorType.TwoSpaces)
        {
            PrettyPrintNumber<int>(printThis, separatorType);
        }

        /// <summary>
        /// Pretty prints a list of doubles
        /// </summary>
        /// <param name="printThis">List to print</param>
        /// <param name="separatorType">Separator character to use</param>
        public static void PrettyPrint(List<double> printThis, SeparatorType separatorType = SeparatorType.TwoSpaces)
        {
            PrettyPrintNumber<double>(printThis, separatorType);
        }

        /// <summary>
        /// Prints a title element with linebreaks
        /// </summary>
        /// <param name="title">Title</param>
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
            UI.PrettyPrint(fib.GetGoldenRatio(), UI.SeparatorType.Tab);

            Nthnacci nth = new Nthnacci(20, 3);
            UI.PrintTitle("Tribonacci Series");
            UI.PrettyPrint(nth.Series);
            
        }
    }
}
