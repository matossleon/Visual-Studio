using System;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan a = new TimeSpan();
            for (int i = 0; i < 11; i++)
            {
                Console.Write("#" + (i + 1) + ": ");
                a.Add(TimeSpan.ParseExact(Console.ReadLine(), "H:mm", null));
            }

        }
    }
}
