using System;

namespace GamblingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Gambling Problem");
            Gambler gambler = new Gambler();
            gambler.Stake();
        }
    }
}
