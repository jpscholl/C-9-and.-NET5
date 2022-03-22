/*
//  Author: Jonathan Scholl
//  Date: 3/22/2022
//  Project: C#9 and .NET5 - Chapter04 - TwoLetterRegionCode
//  
*/

//begin main
//RunCalculateTax();
//RunCardinalToOrdinal();
//RunFactorial();
//RunFibImperative();
RunFibFunctional();

static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;
    switch (twoLetterRegionCode)
    {
        case "CH": //Switzerland
            rate = 0.08M;
            break;
        case "DK": //Denmark
        case "NO": //Norway
            rate = 0.25M;
            break;
        case "GB": //United Kingdom
        case "FR": //France
            rate = 0.2M;
            break;
        case "HU": //Hungary
            rate = 0.27M;
            break;
        case "OR": //Oregon
        case "AK": //Alaska
        case "MT": //Montana
            rate = 0.0M;
            break;
        case "ND": //North Dakota
        case "WI": //Wisconsin
        case "ME": //Maryland
        case "VA": //Virginia
            rate = 0.05M;
            break;
        case "CA": //California
            rate = 0.0825M;
            break;
        default:
            rate = 0.06M;
            break;
    }
    return amount * rate;
}

/// <summary>
///  Pass a 32-bit integer and it will be converted into its ordinal equivalent
/// </summary>
/// <param name="number">Number is a caridnal value e.g. 1, 2, 3, and so on.</param>
/// <returns>Number as an ordinal value e.g 1st, 2nd, 3rd, and so on. </returns>


static void RunCalculateTax()
{
    Console.Write("Enter an amount: ");
    string amountInText = Console.ReadLine();
    Console.WriteLine("Enter a two-letter region code: ");
    string region = Console.ReadLine();
    if (decimal.TryParse(amountInText, out decimal amount))
    {
        decimal taxToPay = CalculateTax(amount, region);
        Console.WriteLine($"You must pay {taxToPay} in sales tax");
    }
    else
    {
        Console.WriteLine("You did not enter a valid amount.");
    }
}

//cardinality
static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}
static void RunCardinalToOrdinal()
{
    for (int number = 1; number <= 40; number++)
    {
        Console.Write($"{CardinalToOrdinal(number)} ");
    }
    Console.WriteLine();
}

//factorials
static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * Factorial(number - 1);
        }
    }
}
static void RunFactorial()
{
    for (int i = 1; i <= 15; i++)
    {
        try 
        { 
            Console.WriteLine($"{i}! = {Factorial(i):N0}"); 
        } 
        catch (OverflowException) 
        { 
            Console.WriteLine($"{i}! is too big for a 32-bit integer."); 
        }

    }
}
//imperitve function
static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}
static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        Console.WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(term:i):N0}.");
    }
}
//functional function
static int FibFunctional(int term) => term switch
{
    1 => 0,
    2 => 1,
    _ => FibFunctional(term - 1) + FibFunctional(term - 2)
};
static void RunFibFunctional()
{
    for (int i =1; i <= 30; i++)
    {
        Console.WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibFunctional(term:i):N0}");
    }
}
