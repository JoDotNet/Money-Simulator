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

        private string RiggedNumbers()
        {
            return "777";
        }

        private string GetNumbers()
        {
            
            var generatedNumbers = GenerateNumbers();
            //Console.WriteLine(generatedNumbers);

            return generatedNumbers;
            //Console.WriteLine(generatedNumber1);
            //Console.WriteLine(generatedNumber2);
            //Console.WriteLine(generatedNumber3);
        }



        // Game Function (Request this)
        public string SlotGamble(bool rigged)
        {
            var getnumbers = "";

            if (rigged == false) getnumbers = GetNumbers();
            else getnumbers = RiggedNumbers();

            string twoEqual = "0";
            string threeEqual = "0";
            //bool TwoSeven = false;
            //bool ThreeSeven = false;

            char generatedNumber1 = getnumbers[0];
            char generatedNumber2 = getnumbers[1];
            char generatedNumber3 = getnumbers[2];

            //Console.WriteLine(generatedNumber1);
            //Console.WriteLine(generatedNumber2);
            //Console.WriteLine(generatedNumber3);

            //Console.WriteLine(getnumbers);

            List<char> Numbers = new List<char>();
            Numbers.Add(generatedNumber1);
            Numbers.Add(generatedNumber2);
            Numbers.Add(generatedNumber3);

            List<char> noDupes = Numbers.Distinct().ToList();

            if (noDupes.Count == 2)
            {
                twoEqual = "2";
            }
            else if (noDupes.Count == 3)
            {
                twoEqual = "0";
                threeEqual = "0";
            }
            else if (noDupes.Count == 1)
            {
                threeEqual = "3";
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (twoEqual == "2")
            {
                return twoEqual + getnumbers;
            }
            else if (threeEqual == "3")
            {
                return threeEqual + getnumbers;
            }
            else return "0" + getnumbers;
        }
    }
}
