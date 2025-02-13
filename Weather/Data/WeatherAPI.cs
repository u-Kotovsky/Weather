using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather.Data
{
    public class WeatherAPI
    {
        private const string BASE_URL = "https://api.openweathermap.org/data/2.5/weather?q={0}&lang={1}&appid={2}&units={3}";
        private static string url = $"https://api.openweathermap.org/data/2.5/weather?q={q}&lang={lang}&appid={appid}&units={units}";
        private static string appid = "";
        private static string units = "metric";
        private static string lang = "ru";
        private static string q = "Volzhskiy";

        private static WeatherData data { get; set; }

        public static WeatherData GetData()
        {
            if (data == null) 
                Fetch(SettingsManager.Data);

            return data;
        }

        public static void SetAppId(string Key)
        {
            appid = Key;
            UpdateURL();
        }

        public static void UpdateURL()
        {
            url = BASE_URL
                .Replace("{0}", q)
                .Replace("{1}", lang)
                .Replace("{2}", appid)
                .Replace("{3}", units);
        }

        public static WeatherData Fetch(SettingsData settingsData)
        {
            var webRequest = WebRequest.Create(url) as HttpWebRequest;
            if (webRequest == null)
                throw new Exception("Failed to create web request.");

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            try
            {
                var s = webRequest.GetResponse().GetResponseStream();
                var sr = new StreamReader(s);
                var dataAsJson = sr.ReadToEnd();
                data = JsonConvert.DeserializeObject<WeatherData>(dataAsJson);
                //MessageBox.Show(JsonConvert.SerializeObject(data));
                //MessageBox.Show($"Сейчас в {data.name} что-то там");
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Weather - Exception! Please send this to a developer");
                return null;
            }

            return data;
        }
    }
}