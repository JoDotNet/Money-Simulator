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

        private int Rigged(string coinflipname)
        {
            int returnvalue = 0;

            if (coinflipname == "Heads")
            {
                returnvalue = 1;
            }
            else
            {
                returnvalue = 2;
            }


            return returnvalue;
        }
        public int CoinGamble(bool rigged, string coinflipname)
        {
            if (rigged == true)
            {
                return Rigged(coinflipname);
            }
            else
            {
                return GetRandomNumber();
            }
        }
    }
}
