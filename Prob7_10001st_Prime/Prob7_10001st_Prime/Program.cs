/*
 * 
This is problem 7 of Project Euler

10001st prime

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Prob7_10001st_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("The 10001st prime: {0}", primeNumbers());
            stopwatch.Stop();
            Console.WriteLine("The project takes: {0} ms.", stopwatch.ElapsedMilliseconds);
        }

        public static long primeNumbers()
        {
            long prime10001st = 2;
            long primeCount = 1;
            long number = 3;

            while(primeCount < 10001)
            {
                if (isPrime(number))
                {
                    prime10001st = number;
                    primeCount += 1;
                }
                number += 2;
            }
            return prime10001st;
        }

        public static bool isPrime(long number)
        {
            for(int i = 2; i*i <= number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
