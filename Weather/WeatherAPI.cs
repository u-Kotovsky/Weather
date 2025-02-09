using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class WeatherAPI
    {
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={q}&lang={lang}&appid={appid}&units={units}";
        private static string appid = "";
        private static string units = "metric";
        private static string lang = "ru";
        private static string q = "Volzhskiy";
        public void SetAppId(string Key)
        {
            appid = Key;
        }
        public void Fetch()
        {
            //добавить метод получения данных
        }
    }
}
