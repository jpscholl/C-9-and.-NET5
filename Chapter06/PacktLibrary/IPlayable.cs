using System;
namespace Packt.Shared
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop()
        {
            Console.WriteLine("Default implementation of Stop.");
        }
    }
}
