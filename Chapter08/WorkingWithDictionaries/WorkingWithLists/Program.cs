/*
//  Author: Jonathan Scholl
//  Date: 4/12/2022
//  Project: C#9 and .NET5 - Chapter08
//  
*/
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace WorkingWithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            Console.WriteLine("Initial List:");
            foreach (var c in cities)
            {
                Console.WriteLine($" {c}");
            }
            Console.WriteLine($"The first city is {cities[0]}");
            Console.WriteLine($"The last city is {cities[cities.Count - 1]}.");
            cities.Insert(0, "Sydney");
            Console.WriteLine("After inserting Sydney at index 0");
            foreach(var c in cities)
            {
                Console.WriteLine($" {c}");
            }
            cities.RemoveAt(1);
            cities.Remove("Milan");
            Console.WriteLine("After removing two cities");
            foreach (var c in cities)
            {
                Console.WriteLine($" {c}");
            }

            //Using immutable collections
            var immutableCities = cities.ToImmutableArray();

            var newList = immutableCities.Add("Rio");
            Console.Write("Immutable list of cities: ");
            foreach (string city in immutableCities)
            {
                Console.Write($" {city}");
            }
            Console.WriteLine();
            Console.Write("New list of cities: ");
            foreach(string city in newList)
            {
                Console.Write($" {city}");
            }

        }
    }
}
