/*
 * This is problem 5 of project Euler
 * Smallest multiple
 * 
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. 
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Prob5_Smallest_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long number = 20;
            while (!evenlyDivisibleBy20(number))
            {
                number += 2;
            }

            if (evenlyDivisibleBy20(number))
            {
                Console.WriteLine("The smallest positive number that is evenly divisible by all of the numbers from 1 to 20: {0}", number);
            }

            stopwatch.Stop();
            Console.WriteLine("Project takes: {0} ms", stopwatch.ElapsedMilliseconds);
        }

        public static bool evenlyDivisibleBy20(long num)
        {
            for(int i = 2; i <= 20; i++)
            {
                if(num % i != 0)
                {
                    return false;
                }    
            }
            return true;
        }
    }
}
