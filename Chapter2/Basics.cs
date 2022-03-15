using System.Reflection;
// start main method

// declare some unused variables using types in additional assemblies
System.Data.DataSet ds;
System.Net.Http.HttpClient client;

// loop through the assemblies that this app references
foreach (var r in Assembly.GetEntryAssembly().GetReferencedAssemblies())
{
    // load the assembly so we can read its details
    var a = Assembly.Load(new AssemblyName(r.FullName));
    // declare a variable to count the number of methods
    int methodCount = 0;
    // loop through all the types in the assembly
    foreach (var t in a.DefinedTypes)
    {
        //add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    // output the count of types and their methods
    Console.WriteLine($"{a.DefinedTypes.Count()} types with {methodCount} methods in {r.Name} assembly.");
}
