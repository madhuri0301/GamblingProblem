using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingProblem
{
    class Gambler
    {
        public const int stake = 1;
        public const int Stakes_Day = 100;
        public void Stake()
        {
            Console.WriteLine("Stake=" +stake);
            Console.WriteLine("New Stakes A Day=" + Stakes_Day);
        }
        public void WinOrLoose()
        {
            Random random = new Random();
            int bet = random.Next(0, 1);
            if (bet == 1)
            {
                Console.WriteLine("Gambler Win");
            }
            else
            {
                Console.WriteLine("Gambler Loose");
            }     
        }

    }
}
