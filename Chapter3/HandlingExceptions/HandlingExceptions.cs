/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03
//  
*/

//Handling exceptions when converting types
Console.WriteLine("Before parsing");
Console.Write("What is your age? ");
string input = Console.ReadLine();
try
{
    int age = int.Parse(input);
    Console.WriteLine($"You are {age} years old.");
}
catch (OverflowException)
{
    Console.WriteLine("You age is a valid number format but it is either too big or small.");
}
catch (FormatException)
{
    Console.WriteLine("The age you entered is not a valid number format.");
}
catch(Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says {ex.Message}");
}
Console.WriteLine("After parsing");
