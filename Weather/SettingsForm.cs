using System;
using System.Windows.Forms;

namespace Weather
{
    public partial class SettingsForm : Form
    {
        private HintSettingsForm _hintSettings { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

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
    }
}