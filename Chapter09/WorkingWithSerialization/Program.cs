﻿/*
//  Author: Jonathan Scholl
//  Date: 4/20/2022
//  Project: C#9 and .NET5 - Chapter09 - WorkingWithSerialization
//  
*/
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;
using NuJson = System.Text.Json.JsonSerializer;
using Packt.Shared;
using static System.Console;
using static System.Environment;
using static System.IO.Path;

namespace WorkingWithSerialization
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // create an object graph
            var people = new List<Person>
        {
                new Person(30000M) { FirstName = "Alice", LastName = "Smith", DateOfBirth = new DateTime(1974, 3, 14) },
                new Person(40000M) { FirstName = "Bob", LastName = "Jones", DateOfBirth = new DateTime(1969, 11, 23) },
                new Person(20000M) { FirstName = "Charlie", LastName = "Cox", DateOfBirth = new DateTime(1984, 5, 4),
                    Children = new HashSet<Person>
                    {
                        new Person(0M) { FirstName = "Sally", LastName = "Cox", DateOfBirth = new DateTime(2000, 7, 12)} 
                    } 
                }
            };
            // create an object that will format a List of Persons as XML
            var xs = new XmlSerializer(typeof(List<Person>));
            //create a file to write to
            string path = Combine(CurrentDirectory, "people.xml");
            using (FileStream stream = File.Create(path))
            {
                // serialize the object graph to the stream
                xs.Serialize(stream, people);
            }
            WriteLine("Written {0:N0} bytes of XML to {1}",
                arg0: new FileInfo(path).Length,
                arg1: path);
            WriteLine();
            // display the seriablized object graph
            WriteLine(File.ReadAllText(path));

            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                // deserializes and cast the object graph into a list of Person
                var loadedPeople =  (List<Person>)xs.Deserialize(xmlLoad);
                foreach(var item in loadedPeople)
                {
                    WriteLine($"{item.LastName} has {item.Children.Count} children");
                }
            }

            //creat a file to write to
            string jsonPath = Combine(CurrentDirectory, "people.json");
            using (StreamWriter jsonStream = File.CreateText(jsonPath))
            {
                // create an object that will format as JSON
                var jss = new Newtonsoft.Json.JsonSerializer();
                // serialize the object graphic into a string
                jss.Serialize(jsonStream, people);
            }
            WriteLine();
            WriteLine("Written {0:N0} bytes of JSON to: {1}",
                arg0: new FileInfo(jsonPath).Length,
                arg1:jsonPath);
            WriteLine(File.ReadAllText(jsonPath));

            using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
            {
                // deserializat object graphi into a List of Person
                var loadedPeople = (List<Person>)
                    await NuJson.DeserializeAsync(
                        utf8Json: jsonLoad,
                        returnType: typeof(List<Person>));
                foreach (var item in loadedPeople)
                {
                    WriteLine("{0} has {1} children",
                        arg0: item.LastName,
                        arg1: item.Children?.Count ?? 0);
                }
            }
        }
    }
}
