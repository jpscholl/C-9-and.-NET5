using System;
using Packt.Shared;

namespace PeopleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person { Name = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };
            //calls instance method
            var baby1 = mary.ProcreateWith(harry);
            baby1.Name = "Gary";
            //call static method
            var baby2 = Person.Procreate(harry, jill);
            //call an operator
            var baby3 = harry * mary;
            Console.WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            Console.WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            Console.WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            Console.WriteLine(
                format: "{0}'s first child is name \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name);
            //testing local function
            Console.WriteLine($"5! is {Person.Factorial(5)}");

            //Events
            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            //Comparing objects when sorting
            Person[] people =
            {
                new Person {Name = "Simon"},
                new Person {Name = "Jenny"},
                new Person {Name = "Adam" },
                new Person {Name = "Richard"}
            };

            //IComparable
            Console.WriteLine("Initial list of people: ");
            foreach (var person in people)
            {
                Console.WriteLine($"    {person.Name}");
            }
            Console.WriteLine("Use Person's IComparable implementation to sort: ");
            Array.Sort(people);
            foreach (var person in people)
            {
                Console.WriteLine($"    {person.Name}");
            }

            //comparing objects using a separate class
            Console.WriteLine("Use PersonComparer's IComparer implementation to sort: ");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                Console.WriteLine($"    {person.Name}");
            }

            //generics
            var t1 = new Thing();
            t1.Data = "42";
            Console.WriteLine($"Thing with an integer: {t1.Process(42)}");
            var t2 = new Thing();
            t2.Data = "apple";
            Console.WriteLine($"Thing with a string: {t2.Process("apple")}");

            //working with generic types
            var gt1 = new GenericThing<int>();
            gt1.Data = 42;
            Console.WriteLine($"GenericThing with an integer: {gt1.Process(42)}");
            var gt2 = new GenericThing<string>();
            gt2.Data = "apple";
            Console.WriteLine($"GenericThing with a string: {gt2.Process("apple")}");

            //working with generic methods
            string number1 = "4";
            Console.WriteLine("{0} squared is {1}",
                arg0: number1,
                arg1: Squarer.Square<string>(number1));
            byte number2 = 3;
            Console.WriteLine("{0} squared is {1}",
                arg0: number2,
                arg1: Squarer.Square(number2));

            //managing memory w/ reference and value types
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            Console.WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            //Inheriting from classes
            Employee jon = new Employee
            {
                Name = "Jonathan Scholl",
                DateOfBirth = new DateTime(1988, 05, 02)
            };
            jon.WriteToConsole();
            jon.EmployeeCode = "JS6969";
            jon.HireDate = new DateTime(2022, 04, 04);
            Console.WriteLine($"{jon.Name} was hired on {jon.HireDate:MM/dd/yyyy}");

            Console.WriteLine(jon.ToString());

            //understanding polymorphism
            Employee aliceInEmployee = new Employee
            {
                Name = "Alice",
                EmployeeCode = "AA123"
            };
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            Console.WriteLine(aliceInEmployee.ToString());
            Console.WriteLine(aliceInPerson.ToString());

            if (aliceInPerson is Employee)
            {
                Console.WriteLine($"{nameof(aliceInPerson)} IS an Employee.");
                Employee explicitAlice = (Employee)aliceInPerson;
            }

            Employee aliceAsEmployee = aliceInPerson as Employee;
            if (aliceAsEmployee != null)
            {
                Console.WriteLine($"{nameof(aliceInPerson)} AS an Employee.");
                Employee explicitAlice = (Employee)aliceInPerson;
            }

            try
            {
                jon.TimeTravel(new DateTime(1999, 12, 31));
                jon.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //static method to reuse functionality
            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";
            Console.WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email1,
                arg1: email1.IsValidEmail());
            Console.WriteLine(
                "{0} is a valid e-mail address: {1}",
                arg0: email2,
                arg1: email2.IsValidEmail());


        }
        private static void Harry_Shout(object sender, EventArgs e)
        {
            var p = (Person)sender;
            Console.WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}