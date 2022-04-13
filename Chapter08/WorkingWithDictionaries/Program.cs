/*
//  Author: Jonathan Scholl
//  Date: 4/12/2022
//  Project: C#9 and .NET5 - Chapter08
//  
*/
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace WorkingWithDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "32-bit integer data type");
            keywords.Add("long", "64-bit integer data type");
            keywords.Add("float", "Single precision floating point number");
            Console.WriteLine("Keywords and their definitions");
            foreach (KeyValuePair<string, string> item in keywords)
            {
                Console.WriteLine($" {item.Key}: {item.Value}");
            }
            Console.WriteLine($"The definition of long is {keywords["long"]}");

        }
    }
}
