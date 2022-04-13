/*
//  Author: Jonathan Scholl
//  Date: 4/12/2022
//  Project: C#9 and .NET5 - Chapter08
//  
*/
using System;

namespace WorkingWithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //length of string
            string city = "Atlanta";
            Console.WriteLine($"{city} is {city.Length} characters long.");
            Console.WriteLine();

            //chars of string
            Console.WriteLine($"First char is {city[0]} and third is {city[2]}.");
            Console.WriteLine();

            //splitting a string
            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (string c in citiesArray)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();

            //getting part of a string
            string fullName = "Max Fried";
            int indexOfTheSpace = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, indexOfTheSpace);
            string lastName = fullName.Substring(indexOfTheSpace + 1);
            Console.WriteLine($"{lastName}, {firstName}");
            Console.WriteLine();

            //optional exercise
            Console.Write("Optional exercise: ");
            string fullName2 = $"{lastName}, {firstName}";
            Console.WriteLine(fullName2);
            int indexOfTheSpace2 = fullName2.IndexOf(',');
            string lastName2 = fullName2.Substring(0, indexOfTheSpace2);
            string firstName2 = fullName2.Substring(indexOfTheSpace2 + 2);
            Console.WriteLine($"{firstName2} {lastName2}");
            Console.WriteLine();

            //Checking a string for content
            string company = "Microsoft";
            bool startsWithM = company.StartsWith("M");
            bool containsN = company.Contains("N");
            Console.WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");
            Console.WriteLine();


            //joining, formatting, and other string members
            string recombined = string.Join(" => ", citiesArray);
            Console.WriteLine(recombined);
            Console.WriteLine();

            string fruit = "Apples";
            decimal price = 0.39M;
            DateTime when = DateTime.Now;
            Console.WriteLine($"{fruit} cost {price:C} on {when:dddd}s.");
            Console.WriteLine(string.Format("{0} cost {1:C} on {2:dddd}s.",
                fruit, price, when));
            Console.WriteLine();



        }
    }
}
