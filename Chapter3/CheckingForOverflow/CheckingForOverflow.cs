/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 CheckingForOverflow.cs
//  
*/

try
{
    checked
    {
        int x = int.MaxValue - 1;
        Console.WriteLine($"Initial value: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
        x++;
        Console.WriteLine($"After incrementing: {x}");
    } 
}
catch (OverflowException)
{
    Console.WriteLine("The code overflowed but I caught the exception.");
}

//unchecked
unchecked
{
    int y = int.MaxValue + 1;
    Console.WriteLine($"Initial value: {y}");
    y--;
    Console.WriteLine($"After decrementing: {y}");
    y--;
    Console.WriteLine($"After decrementing: {y}");

}
