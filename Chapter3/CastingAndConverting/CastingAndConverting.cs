/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5- Chapter03 CastingConverting
//  
*/

//implicit casting
int a = 10;
double b = a;
Console.WriteLine(b);

//explicit casting
double c = 9.8;
int d = (int)c;
Console.WriteLine(d);

//difference in values
long e = 10;
int f = (int)e;
Console.WriteLine($"e is {e:N0} and f is {f:N0}");
e = 5_000_000_000;
f = (int)e;
Console.WriteLine($"e is {e:N0} and f is {f:N0}");

//Conversion
double g = 9.8;
int h = Convert.ToInt32(g);
Console.WriteLine($"g is {g} and h is {h}");

//rounding numbers
double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double n in doubles)
{
    Console.WriteLine($"ToInt({n}) is {Convert.ToInt32(n)}");
}

//different rounding
Console.WriteLine();
foreach (double n in doubles)
{
    Console.WriteLine($"Math.Round({n}) is {Math.Round(n, MidpointRounding.AwayFromZero)}");
}

//convert anything to string
Console.WriteLine();
int number = 12;
Console.WriteLine(number.ToString());
bool boolean = true;
Console.WriteLine(boolean.ToString());
DateTime now = DateTime.Now;
Console.WriteLine(now.ToString());
object me = new object();
Console.WriteLine(me.ToString());

//convert binary object to string
Console.WriteLine();
// allocate array of 128 bytes
byte[] binaryObject = new byte[128];
// populate array with random bytes
(new Random()).NextBytes(binaryObject);
Console.WriteLine("Binary Object as bytes:");
for (int index = 0; index < binaryObject.Length; index++)
{
    Console.Write($"{binaryObject[index]:X} ");
}
Console.WriteLine();

// convert to Base64 string and output as text
string encoded = Convert.ToBase64String(binaryObject);
Console.WriteLine($"Binary Object as Base64: {encoded}");
Console.WriteLine();

//parsing from string to numbers
int age = int.Parse(" 27"); 
DateTime birthday = DateTime.Parse(" 4 July 1980"); 
Console.WriteLine($" I was born {age} years ago."); 
Console.WriteLine($" My birthday is {birthday}."); 
Console.WriteLine($" My birthday is {birthday:D}.");

//TryParse
Console.Write("How many eggs are there? ");
int count;
string input = Console.ReadLine();
if (int.TryParse(input, out count))
{
    Console.WriteLine($"There are {count} eggs.");
}
else
{
    Console.WriteLine($"I could not parse the input.");
}
