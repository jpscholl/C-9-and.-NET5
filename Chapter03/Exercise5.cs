/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 Exercise 5
//  
*/

using System;
using static System.Console;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("int x = 3;");
            WriteLine("int y = 2 + ++x;");

            int x = 3;
            int y = 2 + ++x;
            WriteLine($"x = {x} and y = {y}");
            WriteLine();

            WriteLine("x = 3 << 2;");
            WriteLine("y = 10 >> 1;");

            x = 3 << 2;
            y = 10 >> 1; ;
            WriteLine($"x = {x} and y = {y}");
            WriteLine();

            WriteLine("x = 10 & 8;");
            WriteLine("y = 10 | 7;");

            x = 10 & 8;
            y = 10 | 7;
            WriteLine($"x = {x} and y = {y}");
            WriteLine();
        }
    }
}
