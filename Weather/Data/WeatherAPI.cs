using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Weather.Data
{
    public class WeatherAPI
    {
        private static string url = $"https://api.openweathermap.org/data/2.5/weather?q={q}&lang={lang}&appid={appid}&units={units}";
        private static string appid = "";
        private static string units = "metric";
        private static string lang = "ru";
        private static string q = "Volzhskiy";

        private WeatherData data {  get; set; }

        public void SetAppId(string Key)
        {
            appid = Key;
        }

        public WeatherData Fetch()
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
                MessageBox.Show(JsonConvert.SerializeObject(data));
            } catch (Exception e)
            {
                MessageBox.Show(e.Message, "Weather - Exception! Please send this to a developer");
                return null;
            }

            return data;
        }
    }
}