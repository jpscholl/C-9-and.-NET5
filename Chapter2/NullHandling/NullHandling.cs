/*
//  Author: Jonathan Scholl
//  Date: 3/15/2022
//  Project: C#9 and .NET5- Chapter02 NullHandling.cs
//  
*/
#nullable enable

int thisCannotBeNull = 4;
//thisCannotBeNull = null;
int? thisCouldBeNull = null;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());
thisCouldBeNull = 7;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

var address = new Address();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;

class Address
{
    public string? Building;
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}
