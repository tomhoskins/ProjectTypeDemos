namespace WinFormMiniProjectTim
{
    partial class AddressEntry
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
            cityText = new TextBox();
            cityLabel = new Label();
            streetText = new TextBox();
            streetLabel = new Label();
            zipCodeText = new TextBox();
            zipCodeLabel = new Label();
            stateText = new TextBox();
            stateLabel = new Label();
            addressEntryLabel = new Label();
            saveButton = new Button();
            SuspendLayout();
            // 
            // cityText
            // 
            cityText.Location = new Point(225, 125);
            cityText.Name = "cityText";
            cityText.Size = new Size(327, 47);
            cityText.TabIndex = 6;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(150, 128);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(69, 41);
            cityLabel.TabIndex = 3;
            cityLabel.Text = "City";
            // 
            // streetText
            // 
            streetText.Location = new Point(225, 72);
            streetText.Name = "streetText";
            streetText.Size = new Size(327, 47);
            streetText.TabIndex = 5;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(9, 75);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(210, 41);
            streetLabel.TabIndex = 4;
            streetLabel.Text = "Street Address";
            // 
            // zipCodeText
            // 
            zipCodeText.Location = new Point(225, 232);
            zipCodeText.Name = "zipCodeText";
            zipCodeText.Size = new Size(327, 47);
            zipCodeText.TabIndex = 10;
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(80, 235);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(139, 41);
            zipCodeLabel.TabIndex = 7;
            zipCodeLabel.Text = "Zip Code";
            // 
            // stateText
            // 
            stateText.Location = new Point(225, 179);
            stateText.Name = "stateText";
            stateText.Size = new Size(327, 47);
            stateText.TabIndex = 9;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(135, 182);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(84, 41);
            stateLabel.TabIndex = 8;
            stateLabel.Text = "State";
            // 
            // addressEntryLabel
            // 
            addressEntryLabel.AutoSize = true;
            addressEntryLabel.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressEntryLabel.Location = new Point(135, 9);
            addressEntryLabel.Name = "addressEntryLabel";
            addressEntryLabel.Size = new Size(313, 60);
            addressEntryLabel.TabIndex = 11;
            addressEntryLabel.Text = "Address Entry";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(225, 296);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(182, 56);
            saveButton.TabIndex = 12;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // AddressEntry
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 381);
            Controls.Add(saveButton);
            Controls.Add(addressEntryLabel);
            Controls.Add(zipCodeText);
            Controls.Add(zipCodeLabel);
            Controls.Add(stateText);
            Controls.Add(stateLabel);
            Controls.Add(cityText);
            Controls.Add(cityLabel);
            Controls.Add(streetText);
            Controls.Add(streetLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "AddressEntry";
            Text = "Address Entry Form by Tom Hoskins";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cityText;
        private Label cityLabel;
        private TextBox streetText;
        private Label streetLabel;
        private TextBox zipCodeText;
        private Label zipCodeLabel;
        private TextBox stateText;
        private Label stateLabel;
        private Label addressEntryLabel;
        private Button saveButton;
    }
}