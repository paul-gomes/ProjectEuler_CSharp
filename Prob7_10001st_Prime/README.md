

This is problem 7 of Project Euler

10001st prime

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?



<b>Sieve Of Eratosthenes to generate prime numbers</b>
From: https://www.baeldung.com/java-generate-prime-numbers

There is an efficient method which could help us to generate prime numbers efficiently, and it’s called Sieve Of Eratosthenes. Its time efficiency is O(n logn).
But we can not use this method here as we dont have any upper bound.

Create a list of consecutive integers from 2 to n: (2, 3, 4, …, n)
Initially, let p be equal 2, the first prime number
Starting from p, count up in increments of p and mark each of these numbers greater than p itself in the list. These numbers will be 2p, 3p, 4p, etc.; note that some of them may have already been marked
Find the first number greater than p in the list that is not marked. If there was no such number, stop. Otherwise, let p now equal this number (which is the next prime), and repeat from step 3
At the end when the algorithm terminates, all the numbers in the list that are not marked are the prime numbers.