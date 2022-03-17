/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 Exercise4
//  
*/

Console.WriteLine($"Enter number between {byte.MinValue} - {byte.MaxValue}: ");
string a = Console.ReadLine();
Console.WriteLine($"Enter another number between {byte.MinValue} - {byte.MaxValue}: ");
string b = Console.ReadLine();

try
{
    byte byte1 = Byte.Parse(a);
    byte byte2 = Byte.Parse(b);
    Console.WriteLine($"{byte1} divided by {byte2} is {byte1/byte2}");
}
catch (OverflowException)
{
    Console.WriteLine("Number was too big or too small");
}
catch (FormatException)
{
    Console.WriteLine("Input number was not in correct format.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Can't divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}
