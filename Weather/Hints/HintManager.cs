using System;
using System.Windows.Forms;
using Weather.Data;

namespace Weather.Hints
{
    internal class HintManager
    {
        public static HintData Data { get; private set; }
        public static HintData ChangedData { get; private set; }

        public const string HINTS_PATH = "Hints.xml";

        static HintManager()
        {
            ChangedData = new HintData();
            Load();
        }

        public static void DisplayHints()
        {
            string message = "";

            foreach (var hint in Data.hints)
            {
                float compareFrom = 0f;
                float compareTo = 0f;

                switch (hint.ComparableValue)
                {
                    case ValueType.TEMPERATURE:
                        compareFrom = WeatherAPI.GetData().main.temp;
                        compareTo = (int)hint.CompareToValue;
                        break;
                    case ValueType.WIND_SPEED:
                        compareFrom = WeatherAPI.GetData().wind.speed;
                        compareTo = (int)hint.CompareToValue;
                        break;
                }

                switch (hint.CompareType)
                {
                    case CompareType.IS_BIGGER:
                        if (compareFrom > compareTo)
                            message += $"\n{hint.Message}";
                        break;
                    case CompareType.IS_SMALLER:
                        if (compareFrom < compareTo)
                            message += $"\n{hint.Message}";
                        break;
                }
            }

            MessageBox.Show(message);
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
        private static HintData GetDataFromFile()
        {
            HintData data = new HintData();

            try
            {
                data = XmlUtility.ReadFromXmlFile<HintData>(HINTS_PATH);
            }
            catch (Exception e)
            {
                // empty
            }


            return data;
        }

        /// <summary>
        /// Writing data to a file
        /// </summary>
        private static void WriteDataToFile()
        {
            XmlUtility.WriteToXmlFile(HINTS_PATH, Data);
        }
    }
}
