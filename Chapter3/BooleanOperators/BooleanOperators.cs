/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 BooleanOperators.cs
//  
*/

//Start DoStuff
static bool DoStuff()
{
    Console.WriteLine("I am doing some stuff.");
    return true;
}
//end DoStuff

//start Main method

//test variables
bool a = true;
bool b = false;

//comparing AND, OR, and XOR
Console.WriteLine($"AND | a        | b");
Console.WriteLine($"a   | {a & a,-5}    | {a & b,-5} ");
Console.WriteLine($"b   | {b & a,-5}    | {b & b,-5} ");
Console.WriteLine();
Console.WriteLine($"OR  | a        | b");
Console.WriteLine($"a   | {a | a,-5}    | {a | b,-5} ");
Console.WriteLine($"b   | {b | a,-5}    | {b | b,-5} ");
Console.WriteLine();
Console.WriteLine($"XOR | a        | b");
Console.WriteLine($"a   | {a ^ a,-5}    | {a ^ b,-5} ");
Console.WriteLine($"b   | {b ^ a,-5}    | {b ^ b,-5} ");

Console.WriteLine();
Console.WriteLine($"a & DoStuff() = {a & DoStuff()}");
Console.WriteLine($"b & DoStuff() = {b & DoStuff()}");

Console.WriteLine();
Console.WriteLine($"a && DoStuff() = {a && DoStuff()}");
Console.WriteLine($"b && DoStuff() = {b && DoStuff()}");
