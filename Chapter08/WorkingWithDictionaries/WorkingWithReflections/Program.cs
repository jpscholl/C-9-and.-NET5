/*
//  Author: Jonathan Scholl
//  Date: 4/12/2022
//  Project: C#9 and .NET5 - Chapter08
//  
*/
using System;
using System.Reflection;
using System.Linq;
using System.Runtime.CompilerServices;
using Packt.Shared;

namespace WorkingWithReflections
{
    internal class Program
    {
        [Coder("Mark Price", "22 August 2019")]
        [Coder("Johnni Rasmussen", "13 September 2019")]
        public static void DoStuff()
        {

        }
        static void Main(string[] args)
        {
            //reading assembly metadata
            Console.WriteLine("Assembly metadata:");
            Assembly assembly = Assembly.GetEntryAssembly();
            Console.WriteLine($" Full name: {assembly.FullName}");
            Console.WriteLine($" Location: {assembly.Location}");
            var attributes = assembly.GetCustomAttributes();
            Console.WriteLine($" Attributes:");
            foreach (var attribute in attributes)
            {
                Console.WriteLine($" {attribute.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            Console.WriteLine($" Version: {version.InformationalVersion}");
            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            Console.WriteLine($" Company: {company.Company}");

            Console.WriteLine();
            Console.WriteLine($"* Types:");
            Type[] types = assembly.GetTypes();
            foreach(Type type in types)
            {
                Console.WriteLine();
                Console.WriteLine($"Type: {type.FullName}");
                MemberInfo[] members = type.GetMembers();
                foreach(MemberInfo member in members)
                {
                    Console.WriteLine($"{member.MemberType}: {member.Name} ({member.DeclaringType})");
                    var coders = member.GetCustomAttributes<CoderAttribute>()
                        .OrderByDescending(a => a.LastModified);
                    foreach(CoderAttribute coder in coders)
                    {
                        Console.WriteLine($"-> Modified by {coder.Coder} on {coder.LastModified.ToShortDateString()}");
                    }
                }
            }


        }
    }
}
