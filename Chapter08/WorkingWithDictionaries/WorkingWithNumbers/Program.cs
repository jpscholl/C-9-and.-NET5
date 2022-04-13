/*
//  Author: Jonathan Scholl
//  Date: 4/12/2022
//  Project: C#9 and .NET5 - Chapter08
//  
*/
using System;
using System.Numerics;

namespace WorkingWithNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //big integers
            var largest = ulong.MaxValue;
            Console.WriteLine($"{largest,40:N0}");
            var atomsInTheUniverse = BigInteger.Parse("123456789012345678901234567890");
            Console.WriteLine($"{atomsInTheUniverse, 40:N0}\n");

            //complex numbers
            var c1 = new Complex(4, 2);
            var c2 = new Complex(3, 7);
            var c3 = c1 + c2;
            Console.WriteLine($"{c1} added to {c2} is {c3}");

            //strings
        }
    }
}
