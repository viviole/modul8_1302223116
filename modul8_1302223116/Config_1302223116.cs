using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul8_1302223116
{
    internal class Config_1302223116
    {
        static String json = File.ReadAllText(@"./bank_transfer_config.json");
        public Config config = new Config();

        public void readJson()
        {
            config = JsonSerializer.Deserialize<Config>(json);
            Console.WriteLine(config.transfer.treshold);
            Console.WriteLine(config.transfer.high_fee);
            Console.WriteLine(config.transfer.low_fee);
        }
    }
}
