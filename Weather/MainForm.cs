using System;
using System.Windows.Forms;
using Weather.Data;
using Weather.Hints;

namespace Weather
{
    public partial class MainForm : Form
    {
        private SettingsForm _settigns;
        public static WeatherAPI API { get; private set; }


        public MainForm()
        {
            InitializeComponent();
            API = new WeatherAPI();
            HintManager.Load();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //if (!File.Exists(HintManager.HINTS_PATH))
            //{
            //}
        }

        /// <summary>
        /// WinForms Event Click on Request Weather
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRequestWeather_Click(object sender, EventArgs e)
        {
            WeatherAPI.Fetch(SettingsManager.Data);
            HintManager.DisplayHints();
        }

        /// <summary>
        /// WinForms Event Click on Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            // Do not create another instance of form.
            if (_settigns != null && _settigns.Visible)
            {
                _settigns.Hide();
                return;
            }

            if (_settigns == null) 
                _settigns = new SettingsForm();

            _settigns.ShowDialog();
        }

        /// <summary>
        /// WinForms Event Click on Quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            if (_settigns != null)
            {
                // todo ask for unsaved changes.
                _settigns.Close();
            }

            Close();
        }
    }
}
