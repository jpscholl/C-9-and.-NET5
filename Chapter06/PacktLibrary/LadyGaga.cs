using System;
namespace Packt.Shared
{
    public class Singer
    {
        public virtual void Sing()
        {
            Console.WriteLine("Singing...");
        }
    }
    public class LadyGaga : Singer
    {
        public sealed override void Sing()
        {
            Console.WriteLine("Singing with style...");
        }
    }
}