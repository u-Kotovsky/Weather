using System;
using System.Windows.Forms;
using Weather.Data;

namespace Weather
{
    public class SettingsManager
    {
        public static SettingsData Data { get; private set; }
        public static SettingsData ChangedData { get; private set; }

        private const string SETTINGS_PATH = "Settings.xml";

        static SettingsManager()
        {
            ChangedData = new SettingsData();
            Load();
        }

        public static void Load()
        {
            Data = GetDataFromFile();
        }

        /// <summary>
        /// Saving changed values
        /// </summary>
        public static void Save()
        {
            Data = ChangedData;
            SetKey(Data.secretKey);
            SetLanguage(Data.language);
            SettingsForm.RefreshComponents(Data);
            WeatherAPI.SetAppId(Data.secretKey);
            WriteDataToFile();
        }

        /// <summary>
        /// Cancelling saving data (using old data.)
        /// </summary>
        public static void Cancel()
        {
            try
            {
                Data = GetDataFromFile();
            }
            catch (Exception e)
            {
            }
            finally
            {
                ChangedData = Data;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static SettingsData GetDataFromFile()
        {
            SettingsData data = new SettingsData();

            try
            {
                data = XmlUtility.ReadFromXmlFile<SettingsData>(SETTINGS_PATH);
            }
            catch (Exception e)
            {
                // empty
            }

            SetKey(data.secretKey);
            SetLanguage(data.language);

            SettingsForm.RefreshComponents(data);

            WeatherAPI.SetAppId(data.secretKey);

            return data;
        }

        /// <summary>
        /// Writing data to a file
        /// </summary>
        private static void WriteDataToFile()
        {
            XmlUtility.WriteToXmlFile(SETTINGS_PATH, Data);
        }

        public static void SetKey(string key)
        {
            ChangedData.secretKey = key;
        }

        public static void SetLanguage(string language)
        {
            ChangedData.language = language;
        }
    }
}
