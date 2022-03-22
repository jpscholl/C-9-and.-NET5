/*
//  Author: Jonathan Scholl
//  Date: 3/22/2022
//  Project: C#9 and .NET5 - Chapter04 - Debugging
//  
*/

static double Add (double a, double b)
{
    return a + b; // deliberate bug
}

//begin main

//variables
double a = 4.5;
double b = 2.5;
//calculation
double answer = Add(a, b);
//output
Console.WriteLine($"{a} + {b} = {answer}");
Console.ReadLine();
//end main
