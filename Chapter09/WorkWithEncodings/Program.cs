/*
//  Author: Jonathan Scholl
//  Date: 4/20/2022
//  Project: C#9 and .NET5 - Chapter09 - WorkWithEncodings
//  
*/
using System;
using System.Text;

namespace WorkWithEncodings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encodings");
            Console.WriteLine("[1] ASCII");
            Console.WriteLine("[2] UTF-7");
            Console.WriteLine("[3] UTF-8");
            Console.WriteLine("[4] UTF-16 (Unicode)");
            Console.WriteLine("[5] UTF-32");
            Console.WriteLine("[any other key] Default");

            // choose an encoding
            Console.Write("Press a number to choose an encoding: ");
            ConsoleKey number = Console.ReadKey(intercept: false).Key;
            Console.WriteLine();
            Console.WriteLine();

            Encoding encoder = number switch
            {
                ConsoleKey.D1 => Encoding.ASCII,
                ConsoleKey.D2 => Encoding.UTF7,
                ConsoleKey.D3 => Encoding.UTF8,
                ConsoleKey.D4 => Encoding.Unicode,
                ConsoleKey.D5 => Encoding.UTF32,
                _ => Encoding.Default
            };

            // define a string to encode
            string message = "abcdefghijklmnopqrstuvwxyz";

            // encode the string into a byte array 
            byte[] encoded = encoder.GetBytes(message);

            // check how many bytes the encoding needed 
            Console.WriteLine("{0} uses {1:N0} bytes.",
              encoder.GetType().Name, encoded.Length);

            // enumerate each byte 
            Console.WriteLine($"BYTE  HEX  CHAR");
            foreach (byte b in encoded)
            {
                Console.WriteLine($"{b,4} {b.ToString("X"),4} {(char)b,5}");
            }

            // decode the byte array back into a string and display it 
            string decoded = encoder.GetString(encoded);
            Console.WriteLine(decoded);
        }
    }
}
