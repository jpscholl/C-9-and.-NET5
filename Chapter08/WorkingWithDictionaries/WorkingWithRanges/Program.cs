/*
//  Author: Jonathan Scholl
//  Date: 4/12/2022
//  Project: C#9 and .NET5 - Chapter08
//  
*/
using System;

namespace WorkingWithRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Samantha Jones";
            int lengthOfFirst = name.IndexOf(' ');
            int lengthOfLast = name.Length - lengthOfFirst - 1;
            string firstName = name.Substring(0, lengthOfFirst);
            string lastName = name.Substring(name.Length - lengthOfLast);
            Console.WriteLine($"First name: {firstName} \nLast name: {lastName}\n");

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();
            var firstNameSpan = nameAsSpan[0..lengthOfFirst];
            var lastNameSpan = nameAsSpan[^lengthOfLast..^0];
            Console.WriteLine($"First name: {firstNameSpan.ToString()} \nLast name: {lastNameSpan.ToString()}");
        }
    }
}
