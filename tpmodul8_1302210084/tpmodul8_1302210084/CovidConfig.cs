using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul8_1302210084
{
    class CovidConfig
    {

        public string satuan_suhu { get; set; }
        public int batas_hari_demam { get; set; }
        public string pesan_ditolak { get; set; }
        public string pesan_diterima { get; set; }

        public static CovidConfig LoadConfig()
        {
            CovidConfig config;
            string configJson = File.ReadAllText(@"C:\Users\surya\Documents\KPL Praktikum\tpmodul8_1302210084\tpmodul8_1302210084\tpmodul8_1302210084\covid_config.json");
            config = JsonConvert.DeserializeObject<CovidConfig>(configJson);
            return config;
        }

        public static void UbahSatuan()
        {
            CovidConfig config = LoadConfig();
            if (config.satuan_suhu == "celcius")
            {
                config.satuan_suhu = "fahrenheit";
            }
            else
            {
                config.satuan_suhu = "celcius";
            }
        }
    }
}
