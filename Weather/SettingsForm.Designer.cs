namespace Weather
{
    partial class SettingsForm
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
            this.buttonConfigureHints = new System.Windows.Forms.Button();
            this.textBoxSecretKey = new System.Windows.Forms.TextBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfigureHints
            // 
            this.buttonConfigureHints.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfigureHints.Location = new System.Drawing.Point(26, 106);
            this.buttonConfigureHints.Name = "buttonConfigureHints";
            this.buttonConfigureHints.Size = new System.Drawing.Size(245, 40);
            this.buttonConfigureHints.TabIndex = 3;
            this.buttonConfigureHints.Text = "Configure hints";
            this.buttonConfigureHints.UseVisualStyleBackColor = true;
            this.buttonConfigureHints.Click += new System.EventHandler(this.buttonConfigureHints_Click);
            // 
            // textBoxSecretKey
            // 
            this.textBoxSecretKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSecretKey.Location = new System.Drawing.Point(27, 36);
            this.textBoxSecretKey.Name = "textBoxSecretKey";
            this.textBoxSecretKey.Size = new System.Drawing.Size(245, 20);
            this.textBoxSecretKey.TabIndex = 4;
            this.textBoxSecretKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSecretKey.TextChanged += new System.EventHandler(this.textBoxSecretKey_TextChanged);
            // 
            // languageComboBox
            // 
            this.languageComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Location = new System.Drawing.Point(27, 79);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(244, 21);
            this.languageComboBox.TabIndex = 5;
            this.languageComboBox.Text = "Русский";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.MaximumSize = new System.Drawing.Size(300, 100);
            this.label1.MinimumSize = new System.Drawing.Size(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Secret API Key";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxSecretKey);
            this.panel1.Controls.Add(this.languageComboBox);
            this.panel1.Controls.Add(this.buttonConfigureHints);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 218);
            this.panel1.TabIndex = 7;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(160, 168);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 40);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(27, 168);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 40);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 221);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(320, 260);
            this.Name = "SettingsForm";
            this.Text = "Weather - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonConfigureHints;
        private System.Windows.Forms.TextBox textBoxSecretKey;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
    }
}