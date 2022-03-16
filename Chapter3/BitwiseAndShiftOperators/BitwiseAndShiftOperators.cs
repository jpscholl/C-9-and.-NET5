/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 BitwiseAndShiftOperators
//  
*/

int a = 10;
int b = 6;
Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"a & b = {a & b}");
Console.WriteLine($"a | b = {a | b}");
Console.WriteLine($"a ^ b = {a ^ b}");

// 0101 0000 left-shift a by three bit columns
Console.WriteLine($"a << 3 = {a << 3}");
// multiply by 8
Console.WriteLine($"a * 8 = {a * 8}");
// 0000 0011 right-shift by 1 bit column
Console.WriteLine($"b >> 1 = {b >> 1}");
