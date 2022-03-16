/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 SelectionStatements
//  
*/

using System.IO;

//simple if/else
if (args.Length == 0)
{
    Console.WriteLine("There are no arguments.");
}
else
{
    Console.WriteLine("There is at least one argument.");
}

//using is
object o = 3;
int j = 4;

if (o is int i)
{
    Console.WriteLine($"{i} x {j} = {i * j}");
}
else
{
    Console.WriteLine("o is not an int so it cannot multiply!");
}

A_label:
var number = (new Random()).Next(1,7);
Console.WriteLine($"My random number is {number}");
switch (number)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        goto case 1;
    case 3:
        Console.WriteLine("Three");
        goto case 2;
    case 4:
        Console.WriteLine("Four");
        goto case 3;
    case 5:
        Console.WriteLine("Five");
        goto case 4;
    default: 
        Console.WriteLine("Default");
        break;
}

//path to program?
string path = @"C:\Users\AeonNova\source\repos\C# Projects\C# 9 and .NET 5\Chapter03";
Console.Write("Press R for readonly or W for write: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();
Stream s = null;
if (key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
}

//classic switch
string message = string.Empty; 
switch (s)
{
    case FileStream writeableFile when s.CanWrite: 
        message = "The stream is a file that I can write to."; 
        break;
    case FileStream readOnlyFile: 
        message = "The stream is a read-only file."; 
        break;
    case MemoryStream ms: 
        message = "The stream is a memory address."; 
        break;
    default: 
        // always evaluated last despite its current position
        message = "The stream is some other type."; 
        break; 
    case null: 
        message = "The stream is null."; 
        break; 
} 
Console.WriteLine(message);

//simplified switch after .NET8
message = s switch
{
    FileStream writeableFile when s.CanWrite
        => "The stream is a file that I can write to.",
    FileStream readOnlyFile
        => "The stream is a read-only file.",
    MemoryStream ms
        => "The stream is a memory address.",
    null
        => "The stream is null.",
    _
        => "The stream is some other type."

};
Console.WriteLine(message);
