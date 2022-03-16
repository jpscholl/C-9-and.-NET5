//while statement
Console.WriteLine();
int x = 0;
while (x < 10)
{
    Console.WriteLine(x);
    x++;
}


//do while loop
string password = string.Empty;
int attemptCount = 0;
do 
{ 
    Console.Write("Enter your password: "); 
    password = Console.ReadLine();
    attemptCount++;
} while (password != "Pa$$w0rd" && attemptCount < 10); 

if (password == "Pa$$w0rd" && attemptCount < 10)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Too many attempts!");
}


//for statement
for (int n = 0; n <= 10; n++)
{
    Console.WriteLine(n);
}

//foreach statement
string[] names = { "Steve", "Snot", "Barry", "Toshi" };
foreach (string name in names)
{
    Console.WriteLine($"{name} has {name.Length} characters.");
}
