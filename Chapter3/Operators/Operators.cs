/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 Operators.cs
//  
*/

int a = 3;
int b = a++;
Console.WriteLine($"a is {a}, b is {b}.");

int c = 3;
int d = ++c;
Console.WriteLine($"c is {c}, d is {d}.");

int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");

double g = 11.0;
Console.WriteLine($"g is {g:N1}, f is {f}");
Console.WriteLine($"g / f = {g / f}");
