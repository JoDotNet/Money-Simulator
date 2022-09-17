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
        public int JBalance { get; set; }
    }

    internal class DataHandler
    {
        private const string FileName = "savedata.json";

        public int AddBalance(int amt)
        {
            var data = Load();
            data.JBalance = data.JBalance + amt;
            Save(data);

            return data.JBalance;
        }

        private DataObject Load()
        {
            string filePath = Path.Combine(
              AppDomain.CurrentDomain.BaseDirectory, FileName);

            using (StreamReader sr = new StreamReader(filePath))
            {
                string saveDataContent = sr.ReadToEnd();
                var saveDataJson = JsonConvert.DeserializeObject<DataObject>(saveDataContent);

                Console.WriteLine($"ExeBalance was set to this value from reading savedata.json: {saveDataJson.JBalance}");

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