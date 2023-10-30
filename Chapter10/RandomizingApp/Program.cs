using System;
using Packt.Shared;

namespace RandomizingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How big do you want the key (in bytes): ");
            string size = Console.ReadLine();
            byte[]key = Protector.GetRandomKeyOrIV(int.Parse(size));
            Console.WriteLine($"\nKey as byte array:");
            for (int i = 0; i < key.Length; i++)
            {
                Console.Write($"{key[i]:x2} ");
                if (((i + 1) % 16) == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}