using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.IO;


namespace Money_Simulator
{
    public class DataObject
    {
        public double JBalance { get; set; }
        public double JIncome { get; set; }
        public double JBoost { get; set; }
    }

    internal class DataHandler
    {
        private const string FileName = "savedata.sav";

        public double AddBalance(double amt)
        {
            var data = Load();
            data.JBalance = data.JBalance + amt;
            Save(data);

            return data.JBalance;
        }

        public double AddIncome(double amt, double boostAmt)
        {
            var data = Load();
            data.JIncome = data.JIncome + amt;
            data.JBoost = data.JBoost + boostAmt;
            Save(data);

            return data.JIncome * data.JBoost;
        }

        public double GetMultiplier(double amt)
        {
            var data = Load();
            return data.JBoost;
        }


        private DataObject Load()
        {
            string filePath = Path.Combine(
              AppDomain.CurrentDomain.BaseDirectory, FileName);

            using (StreamReader sr = new StreamReader(filePath))
            {
                string saveDataContent = sr.ReadToEnd();
                var saveDataJson = JsonConvert.DeserializeObject<DataObject>(saveDataContent);

                //Console.WriteLine($"ExeBalance was set to this value from reading savedata.json: {saveDataJson.JBalance}");

                return saveDataJson;
            }
        }

        private void Save(DataObject data)
        {
            var output = JsonConvert.SerializeObject(data);

            File.WriteAllText(FileName, output);
        }
    }
}