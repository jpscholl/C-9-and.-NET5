using System;
using Packt.Shared;

namespace SigningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text to sign:");
            string data = Console.ReadLine();
            var signature = Protector.GenerateSignature(data);
            Console.WriteLine($"Signature: {signature}");
            Console.WriteLine("Public key used to check signature:");
            Console.WriteLine(Protector.PublicKey);

            if (Protector.ValidateSignature(data, signature))
            {
                Console.WriteLine("Correct! Signature is valid.");
            }
            else
            {
                Console.WriteLine("Invalid signature");
            }
            //simulate a fake signature by replacing the first character with an X
            var fakeSignature = signature.Replace(signature[0], 'X');
            if(Protector.ValidateSignature(data, fakeSignature))
            {
                Console.WriteLine("Correct! Signature is valid.");
            }
            else
            {
                Console.WriteLine($"Invalid signature: {fakeSignature}");
            }
        }
    }
}