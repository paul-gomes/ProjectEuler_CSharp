/*
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?
*/


/*
 *Prime number is any number that is only divisible by 1 and itself 
 * To find the prime factorization, we need to break the number to its prime factors
 * "Factors" are the numbers you multiply together to get another number
 * Can we divide 147 exactly by 2?
 * 147 ÷ 2 = 73½
 * No it can't. The answer should be a whole number, and 73½ is not.
 * Let's try the next prime number, 3:
 * 147 ÷ 3 = 49
 * That worked, now we try factoring 49, and find that 7 is the smallest prime number that works:
 * 49 ÷ 7 = 7
 * And that is as far as we need to go, because all the factors are prime numbers.
 * 147 = 3 × 7 × 7
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3_Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer to find the largest prime factor: ");
            long number = Convert.ToInt64(Console.ReadLine());
            List<long> primeFactorList = primeFactors(number);

            Console.WriteLine("Largest prime number: " + primeFactorList.Last());

        }

        public static List<long> primeFactors(long num)
        {
            List<long> factors = new List<long>();
            for(int i =2; i < num/i; i++)
            {
                while(num % i == 0)
                {
                    factors.Add(i);
                    num = num / i;
                }
            }

            if(num > 1)
            {
                factors.Add(num);
            }

            return factors;
        }
    }
}
