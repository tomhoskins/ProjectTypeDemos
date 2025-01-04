namespace WinFormMiniProjectTim
{
    partial class PersonEntryForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            firstNameText = new TextBox();
            lastNameLabel = new Label();
            lastNameText = new TextBox();
            isActive = new CheckBox();
            isActiveLabel = new Label();
            addressesList = new ListBox();
            addressesListLabel = new Label();
            addButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(22, 27);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(160, 41);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(208, 24);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(327, 47);
            firstNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(22, 80);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(157, 41);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(208, 77);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(327, 47);
            lastNameText.TabIndex = 2;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new Point(208, 147);
            isActive.Name = "isActive";
            isActive.Size = new Size(18, 17);
            isActive.TabIndex = 3;
            isActive.TabStop = false;
            isActive.UseVisualStyleBackColor = true;
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new Point(22, 131);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new Size(98, 41);
            isActiveLabel.TabIndex = 0;
            isActiveLabel.Text = "Active";
            // 
            // addressesList
            // 
            addressesList.FormattingEnabled = true;
            addressesList.Location = new Point(22, 233);
            addressesList.Name = "addressesList";
            addressesList.Size = new Size(513, 209);
            addressesList.TabIndex = 3;
            addressesList.TabStop = false;
            // 
            // addressesListLabel
            // 
            addressesListLabel.AutoSize = true;
            addressesListLabel.Location = new Point(22, 189);
            addressesListLabel.Name = "addressesListLabel";
            addressesListLabel.Size = new Size(154, 41);
            addressesListLabel.TabIndex = 0;
            addressesListLabel.Text = "Addresses";
            // 
            // addButton
            // 
            addButton.Location = new Point(412, 187);
            addButton.Name = "addButton";
            addButton.Size = new Size(109, 44);
            addButton.TabIndex = 4;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(174, 448);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(230, 49);
            saveButton.TabIndex = 5;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // PersonEntryForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 543);
            Controls.Add(saveButton);
            Controls.Add(addButton);
            Controls.Add(addressesList);
            Controls.Add(isActive);
            Controls.Add(lastNameText);
            Controls.Add(addressesListLabel);
            Controls.Add(isActiveLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameText);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "PersonEntryForm";
            Text = "Person Entry Form by Tom Hoskins";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private Label lastNameLabel;
        private TextBox lastNameText;
        private CheckBox isActive;
        private Label isActiveLabel;
        private ListBox addressesList;
        private Label addressesListLabel;
        private Button addButton;
        private Button saveButton;
    }
}
