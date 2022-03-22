/*
//  Author: Jonathan Scholl
//  Date: 3/16/2022
//  Project: C#9 and .NET5 - Chapter04 WritingFunctions
//  
*/

// start timetable method
static void TimesTable(byte num)
{
    Console.WriteLine($"This is the {num} times table:");
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine($"{num} x {i} = {i * num}");
    }
    Console.WriteLine();
}
// end timetable method
// start RunTimesTable
static void RunTimesTable()
{
    bool isNumber;
    do
    {
        Console.Write("Enter a number between 0 and 255: ");
        isNumber = byte.TryParse(Console.ReadLine(), out byte num);
        if (isNumber)
        {
            TimesTable(num);
        }
        else
        {
            Console.WriteLine("You did not enter a valid number!");
        }
    } 
    while (isNumber);
}
// end RunTimesTable
RunTimesTable();
