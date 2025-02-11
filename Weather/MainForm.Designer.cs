namespace Weather
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRequestWeather = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRequestWeather
            // 
            this.buttonRequestWeather.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRequestWeather.BackColor = System.Drawing.Color.LightGray;
            this.buttonRequestWeather.Location = new System.Drawing.Point(50, 59);
            this.buttonRequestWeather.Name = "buttonRequestWeather";
            this.buttonRequestWeather.Size = new System.Drawing.Size(300, 62);
            this.buttonRequestWeather.TabIndex = 0;
            this.buttonRequestWeather.Text = "Показать Погоду";
            this.buttonRequestWeather.UseVisualStyleBackColor = false;
            this.buttonRequestWeather.Click += new System.EventHandler(this.buttonRequestWeather_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSettings.Location = new System.Drawing.Point(50, 162);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(300, 60);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonQuit.Location = new System.Drawing.Point(50, 279);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(300, 60);
            this.buttonQuit.TabIndex = 2;
            this.buttonQuit.Text = "Выход";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 384);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonRequestWeather);
            this.Name = "MainForm";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRequestWeather;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonQuit;
    }
}

