using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
Find the sum of all the multiples of 3 or 5 below 1000.
 */

namespace Prob1_Multiples_of_3_and_5

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sum of all the multiples of 3 or 5 below 1000: " + multipleOf3Or5());
            
        }

        public static int multipleOf3Or5()
        {
            int number = 3;
            int sumOfAll = 0;

            while(number < 1000)
            {
                if((number % 3 == 0) || (number % 5 == 0))
                {
                    sumOfAll += number;
                }
                number++;
            }
            return sumOfAll;
        }
    }
}
