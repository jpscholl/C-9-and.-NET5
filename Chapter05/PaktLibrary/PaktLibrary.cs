using System;
using System.Collections.Generic;

namespace Pakt.Shared
{
    public partial class Person : object
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();

        //constants
        public const string Species = "Homo Sapien";

        //read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        
        //constructors
        public Person(string initialName, string homePlanet)
        {
            // set default values for fields
            // including read-only fields
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        //tuple methods
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        //passing params to methods
        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }
        //overloaded
        public string SayHello(string name)
        {
            return $"{Name} says 'Hello {name}!'";
        }

        //optional parameters
        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            return string.Format(
                format: "command is {0}, number is {1}, active is {2}.",
                arg0: command, arg1: number, arg2: active);
        }

        //passing params
        public void PassingParameters (int x, ref int y, out int z)
        {
            z = 99;
            x++;
            y++;
            z++;
        }
    }
}
