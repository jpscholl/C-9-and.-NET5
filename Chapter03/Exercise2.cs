/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 exercise 2
//  
*/

int max = 500;

if (max < byte.MaxValue)
{
    for (byte i = 0; i < max; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("It will overflow");
}