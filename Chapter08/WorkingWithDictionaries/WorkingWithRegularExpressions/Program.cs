/*
//  Author: Jonathan Scholl
//  Date: 4/12/2022
//  Project: C#9 and .NET5 - Chapter08
//  
*/
using System;
using System.Text.RegularExpressions;

namespace WorkingWithRegularExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your age: ");
            //string input = Console.ReadLine();
            //var ageChecker = new Regex(@"^\d+$");
            //if (ageChecker.IsMatch(input))
            //{
            //    Console.WriteLine("Thank you!");
            //}
            //else
            //{
            //    Console.WriteLine($"This is not a valid age: {input}");
            //}
            //Console.WriteLine();

            //splitting a complex comma-separated string
            string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
            string[] filmsDumb = films.Split(',');
            Console.WriteLine("Dumb attempt at splitting:");
            foreach (string film in filmsDumb)
            {
                Console.WriteLine(film);
            }

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            MatchCollection filmsSmart = csv.Matches(films);
            Console.WriteLine("Smart attempt at splitting:");
            foreach (Match film in filmsSmart)
            {
                Console.WriteLine(film.Groups[2].Value);
            }
        }
    }
}
