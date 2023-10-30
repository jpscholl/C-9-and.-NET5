using System;
using System.Security.Cryptography;
using Packt.Shared;

namespace EncryptionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message that you want to encrypt: ");
            string message = Console.ReadLine();
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            string cryptoText = Protector.Encrypt(message, password);
            Console.WriteLine($"Encrypted text: {cryptoText}");
            Console.Write("Enter the password:");
            string password2 = Console.ReadLine();
            try
            {
                string clearText = Protector.Decrypt(cryptoText, password2);
                Console.WriteLine($"Decrypted text:{clearText}");
            }
            catch (CryptographicException ex)
            {
                Console.WriteLine("{0}\nMore details: {1}",
                    arg0: "You entered the wrong password!",
                    arg1: ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Non-cryptogaphic exception:{0}, {1}",
                    arg0: ex.GetType().Name,
                    arg1: ex.Message);
            }
        }
    }
}