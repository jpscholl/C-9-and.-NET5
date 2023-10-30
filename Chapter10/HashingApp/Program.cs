using System;
using System.Security.Cryptography;
using Packt.Shared;

Console.WriteLine("Registering Alice with Pa$$w0rd.");
var alice = Protector.Register("Alice", "Pa$$w0rd");
Console.WriteLine($"Name:{alice.Name}");
Console.WriteLine($"Salt:{alice.Salt}");
Console.WriteLine("Password (salted and hashed): {0}", arg0:alice.SaltedHashedPassword);
Console.WriteLine();
Console.Write("Enter a new user to register:");
string username = Console.ReadLine();
Console.Write($"Enter a password for {username}:");
string password = Console.ReadLine();
var user = Protector.Register(username, password);
Console.WriteLine($"Name: {user.Name}");
Console.WriteLine($"Salt: {user.Salt}");
Console.WriteLine("Password(salted and hashed):{0}",
    arg0:user.SaltedHashedPassword);
Console.WriteLine();
bool correctPassword = false;
while (!correctPassword)
{
    Console.Write("Enter a username to log in: ");
    string loginUsername = Console.ReadLine();
    Console.Write("Enter a password to log in: ");
    string loginPassword = Console.ReadLine();
    correctPassword = Protector.CheckPassword(loginUsername, loginPassword);

    if ( correctPassword)
    {
        Console.WriteLine($"Correct! {loginUsername} has been logged in.");
    }
    else
    {
        Console.WriteLine("Invalid username or password. Try again.");
    }
}