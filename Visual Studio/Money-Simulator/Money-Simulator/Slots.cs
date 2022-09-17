using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Simulator
{
    internal class Slots
    {

        private string GenerateNumbers()
        {
            int Num1 = 0;
            int Num2 = 0;
            int Num3 = 0;

            var random = new Random();


            Num1 = random.Next(1,8);
            Num2 = random.Next(1,8);
            Num3 = random.Next(1,8);

            return Num1.ToString() + Num2.ToString() + Num3.ToString();
        }


        public void GetNumbers()
        {
            
            var generatedNumbers = GenerateNumbers();
            Console.WriteLine(generatedNumbers);

            char generatedNumber1 = generatedNumbers[0];
            char generatedNumber2 = generatedNumbers[1];
            char generatedNumber3 = generatedNumbers[2];

            Console.WriteLine(generatedNumber1);
            Console.WriteLine(generatedNumber2);
            Console.WriteLine(generatedNumber3);
        }



        // Game Function (Request this)
        public void SlotGamble()
        {
            bool TwoEqual = false;
            bool ThreeEqual = false;
            bool TwoSeven = false;
            bool ThreeSeven = false;



        }
    }
}
