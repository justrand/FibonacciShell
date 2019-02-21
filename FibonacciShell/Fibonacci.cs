using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciShell
{
    class Fibonacci: Nthnacci
    {
              
        /// <summary>
        /// Fibonacci version of the nthnacci class. This basically uses hard code degree of 2 for the calculations
        /// Also provides a function to get the golden ratio
        /// </summary>
        /// <param name="limit"></param>
        public Fibonacci(int limit): base(limit, 2) {}

        /// <summary>
        /// Calculates the golden ratio for the series. Golden ratio is (a+b)/a which in Fibonacci series is adding the values of the current
        /// and previous elements in a list together and dividing them with the value of the current element
        /// </summary>
        /// <returns></returns>
        public List<double> GetGoldenRatio()
        {
            List<double> goldenRatio = new List<double>();
            for(int i = 0; i < Series.Count; i++)
            {
                if(i > 0)
                {
                    double ratio = (double)(Series[i] + Series[i - 1]) / Series[i];
                    goldenRatio.Add(ratio);
                }
                else
                {
                    goldenRatio.Add(0);
                }
            }
            return goldenRatio;
        }


    }
}
