/*
//  Author: Jonathan Scholl
//  Date: 3/15/2022
//  Project: C#9 and .NET5- Chapter02 Variables.cs
//  
*/
using System.IO;
using System.Xml;

//using objects
object height = 1.88;   //storing double in object
object name = "Amir";   //storing string in object
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length;  //gives compile error
int length2 = ((string)name).Length; //tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");

//using dynamic types
// storing a string in a dynamic object
dynamic anotherName = "Jonathan";
// this compiles but throws an exception at runtime
// if you later store a data type that does not hae a property named Length
int length = anotherName.Length;
Console.WriteLine($"{anotherName} is {length} characters.");

//variables
int population = 66_000_000;
double weight = 1.88;
decimal price = 4.99M;
string fruit = "Apples";
char letter = 'Z';
bool happy = true;

// good use of var beacuse it avoids the repeated type as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();
XmlDocument xml3 = new();

//bad use because we cant tell the type
//var file1 = File.CreateText(@"C:\something.txt");
//StreamWriter file2 = File.CreateText(@"C:\something.txt");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) =  {default(string)}");
