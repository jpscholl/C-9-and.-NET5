using System;
namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("The dvd player is pausing.");
        }
        public void Play()
        {
            Console.WriteLine("The dvd player is playing.");

        }
    }
}
