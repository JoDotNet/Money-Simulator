using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Simulator
{
    internal class Coinflip
    {

        private int GetRandomNumber()
        {
            int randomNumber;

            Random random = new Random();
            randomNumber = random.Next(1,3);

            return randomNumber;
        }
        public int CoinGamble()
        {
            
            return GetRandomNumber();
        }
    }
}
