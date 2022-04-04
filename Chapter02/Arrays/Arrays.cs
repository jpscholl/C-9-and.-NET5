/*
//  Author: Jonathan Scholl
//  Date: 3/15/2022
//  Project: C#9 and .NET5- Chapter02 Arrays.cs
//  
*/

string[] names; //can reference any array of string
// allocating memory for four string in an array
names = new string[4];
//storing items at index positions
names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Jon";

//looping through the names
foreach (string name in names)
{
    Console.WriteLine(name);
}
