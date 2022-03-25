using System;
using System.Collections.Generic;
namespace Pakt.Shared;

public class ThingsOfDefaults
{
    public int Population;
    public DateTime When;
    public string Name;
    public List<Person> People;
    public ThingsOfDefaults()
    {
        Population = default;
        When = default;
        Name = default;
        People = default;
    }
}
