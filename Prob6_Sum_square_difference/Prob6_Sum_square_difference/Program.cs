/*
Problem 6 

Sum square difference

The sum of the squares of the first ten natural numbers is,

12 + 22 + ... + 102 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Prob6_Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum {0} ", (sumOfSquares(100) - squareOfSum(100)));
            stopwatch.Stop();

            Console.WriteLine("The project runtime: {0} ms", stopwatch.ElapsedMilliseconds);


        }

        /*The formula for 1+2+3+....+n = n(n+1)/2
         * The formula for 1^2 +2^2 + 3^2 + ...... +n^2 = n(2n+1)(n+1)/ 6
         */
         


        public static long sumOfSquares(int n)
        {
            long sum = (n * (2 * n + 1) * (n + 1)) / 6;
            return sum;
        
        }

        public static long squareOfSum(int n)
        {
            long sum = (n * (n + 1)) / 2;
            return sum * sum;
 
        }
    }
}
