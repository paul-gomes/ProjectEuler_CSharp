using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;



//This is a project euler problem 4 Largest palindrome product

//A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

namespace Prob4_Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long largestPlaindrome = 0;
            for(int i = 999; i >99; i--)
            {
                for(int j = 999; j > 99; j--)
                {
                    if(isPalindrome(i*j) && (i*j) > largestPlaindrome)
                    {
                        largestPlaindrome = i * j;
                    }
                }
            }

            Console.WriteLine("The largest palindrome made from the product of two 3-digit numbers {0}", largestPlaindrome);


            stopwatch.Stop();

            Console.WriteLine("The project execution time: {0} ms" , stopwatch.ElapsedMilliseconds);

        }

        public static string reverse(long number)
        {
            string numString = number.ToString();
            var stringArray = numString.ToCharArray();
            Array.Reverse(stringArray);
            return new string(stringArray);

        }

        public static bool isPalindrome(long number)
        {
            if(number.ToString().Equals(reverse(number)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
