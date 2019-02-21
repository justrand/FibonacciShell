using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciShell
{
    /// <summary>
    /// Nth degree Nacci function. Calculates series to length limit with degree degree
    /// Fibonacci series has degree of 2 meaning it calculates the previous 2 values together for current number
    /// </summary>
    class Nthnacci
    {
        private int Limit;
        private int NthDegree;
        public List<int> Series { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="limit">The length of the series</param>
        /// <param name="degree">How many previous series values are calculated together to form the value in current series.</param>
        public Nthnacci(int limit, int degree)
        {
            Limit = limit;
            NthDegree = degree;
            Series = new List<int>();
            CalculateSeries();
        }

        /// <summary>
        /// Calculates the series
        /// </summary>
        public void CalculateSeries()
        {
            for(var i = 0; i < Limit; i++)
            {
                if(i < NthDegree-1)
                {
                    Series.Add(0);
                }
                else if(i == NthDegree-1)
                {
                    Series.Add(1);
                }
                else
                {
                    int number = 0;
                    for(var j = i-1; j >= (i - NthDegree); j--)
                    {
                        number += Series[j];
                    }
                    Series.Add(number);
                }
            }
        }




    }
}
