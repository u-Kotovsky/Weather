using System;
using System.Windows.Forms;

namespace Weather
{
    public partial class SettingsForm : Form
    {
        private HintSettingsForm _hintSettings { get; set; }
        private static SettingsForm _instance { get; set; }

        public SettingsForm()
        {
            if (_instance != null)
                throw new Exception("Multiple SettingsForm instances!!");
            _instance = this;
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            RefreshComponents(SettingsManager.Data);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // todo: ВЫПАДАЮЩИЙ СПИСОК (ЯЗЫКИ)
        }


        /// <summary>
        /// Configure hints WinForms Event Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfigureHints_Click(object sender, EventArgs e)
        {
            // buttonConfigureHints

            // do not duplicate
            if (_hintSettings != null && _hintSettings.Visible)
            {
                _hintSettings.Hide();
                return;
            }

            if (_hintSettings == null)
                _hintSettings = new HintSettingsForm();

            _hintSettings.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SettingsManager.Save();

            // todo: save data
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SettingsManager.Cancel();
            // clear changed data
            Close();
        }

        private void textBoxSecretKey_TextChanged(object sender, EventArgs e)
        {
            SettingsManager.SetKey(textBoxSecretKey.Text);
        }

        public static void RefreshComponents(SettingsData data)
        {
            if (_instance == null)
                return;
            
            if (data == null)
                return;
            
            try
            {
                _instance.textBoxSecretKey.Text = data.secretKey;
                _instance.languageComboBox.SelectedText = data.language;
            }
            catch (Exception ex)
            {

            }
        }
    }
}