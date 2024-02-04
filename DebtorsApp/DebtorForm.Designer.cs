namespace DebtorsApp
{
    partial class DebtorForm
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
            nameFieldLabel = new Label();
            surnameFieldLabel = new Label();
            idFieldLabel = new Label();
            debtFieldLabel = new Label();
            addressFieldLabel = new Label();
            debtorNameLabel = new Label();
            debtorSurnameLabel = new Label();
            debtorIdLabel = new Label();
            debtorDebtLabel = new Label();
            debtorAddressLabel = new Label();
            nameButton = new Button();
            surnameButton = new Button();
            debtButton = new Button();
            addressButton = new Button();
            updateButton = new Button();
            removeDebtorButton = new Button();
            SuspendLayout();
            // 
            // nameFieldLabel
            // 
            nameFieldLabel.AutoSize = true;
            nameFieldLabel.Location = new Point(18, 22);
            nameFieldLabel.Name = "nameFieldLabel";
            nameFieldLabel.Size = new Size(52, 20);
            nameFieldLabel.TabIndex = 0;
            nameFieldLabel.Text = "Name:";
            // 
            // surnameFieldLabel
            // 
            surnameFieldLabel.AutoSize = true;
            surnameFieldLabel.Location = new Point(18, 61);
            surnameFieldLabel.Name = "surnameFieldLabel";
            surnameFieldLabel.Size = new Size(70, 20);
            surnameFieldLabel.TabIndex = 1;
            surnameFieldLabel.Text = "Surname:";
            // 
            // idFieldLabel
            // 
            idFieldLabel.AutoSize = true;
            idFieldLabel.Location = new Point(18, 97);
            idFieldLabel.Name = "idFieldLabel";
            idFieldLabel.Size = new Size(27, 20);
            idFieldLabel.TabIndex = 2;
            idFieldLabel.Text = "ID:";
            // 
            // debtFieldLabel
            // 
            debtFieldLabel.AutoSize = true;
            debtFieldLabel.Location = new Point(18, 132);
            debtFieldLabel.Name = "debtFieldLabel";
            debtFieldLabel.Size = new Size(45, 20);
            debtFieldLabel.TabIndex = 3;
            debtFieldLabel.Text = "Debt:";
            // 
            // addressFieldLabel
            // 
            addressFieldLabel.AutoSize = true;
            addressFieldLabel.Location = new Point(18, 167);
            addressFieldLabel.Name = "addressFieldLabel";
            addressFieldLabel.Size = new Size(65, 20);
            addressFieldLabel.TabIndex = 4;
            addressFieldLabel.Text = "Address:";
            // 
            // debtorNameLabel
            // 
            debtorNameLabel.AutoSize = true;
            debtorNameLabel.Location = new Point(152, 25);
            debtorNameLabel.Name = "debtorNameLabel";
            debtorNameLabel.Size = new Size(94, 20);
            debtorNameLabel.TabIndex = 5;
            debtorNameLabel.Text = "debtorName";
            // 
            // debtorSurnameLabel
            // 
            debtorSurnameLabel.AutoSize = true;
            debtorSurnameLabel.Location = new Point(152, 61);
            debtorSurnameLabel.Name = "debtorSurnameLabel";
            debtorSurnameLabel.Size = new Size(112, 20);
            debtorSurnameLabel.TabIndex = 6;
            debtorSurnameLabel.Text = "debtorSurname";
            // 
            // debtorIdLabel
            // 
            debtorIdLabel.AutoSize = true;
            debtorIdLabel.Location = new Point(152, 97);
            debtorIdLabel.Name = "debtorIdLabel";
            debtorIdLabel.Size = new Size(67, 20);
            debtorIdLabel.TabIndex = 7;
            debtorIdLabel.Text = "debtorId";
            // 
            // debtorDebtLabel
            // 
            debtorDebtLabel.AutoSize = true;
            debtorDebtLabel.Location = new Point(152, 132);
            debtorDebtLabel.Name = "debtorDebtLabel";
            debtorDebtLabel.Size = new Size(87, 20);
            debtorDebtLabel.TabIndex = 8;
            debtorDebtLabel.Text = "debtorDebt";
            // 
            // debtorAddressLabel
            // 
            debtorAddressLabel.AutoSize = true;
            debtorAddressLabel.Location = new Point(152, 167);
            debtorAddressLabel.Name = "debtorAddressLabel";
            debtorAddressLabel.Size = new Size(107, 20);
            debtorAddressLabel.TabIndex = 9;
            debtorAddressLabel.Text = "debtorAddress";
            // 
            // nameButton
            // 
            nameButton.Location = new Point(307, 16);
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(94, 29);
            nameButton.TabIndex = 10;
            nameButton.Text = "Change";
            nameButton.UseVisualStyleBackColor = true;
            nameButton.Click += nameButton_Click;
            // 
            // surnameButton
            // 
            surnameButton.Location = new Point(307, 57);
            surnameButton.Name = "surnameButton";
            surnameButton.Size = new Size(94, 29);
            surnameButton.TabIndex = 11;
            surnameButton.Text = "Change";
            surnameButton.UseVisualStyleBackColor = true;
            surnameButton.Click += surnameButton_Click;
            // 
            // debtButton
            // 
            debtButton.Location = new Point(307, 128);
            debtButton.Name = "debtButton";
            debtButton.Size = new Size(94, 29);
            debtButton.TabIndex = 12;
            debtButton.Text = "Change";
            debtButton.UseVisualStyleBackColor = true;
            debtButton.Click += debtButton_Click;
            // 
            // addressButton
            // 
            addressButton.Location = new Point(307, 167);
            addressButton.Name = "addressButton";
            addressButton.Size = new Size(94, 29);
            addressButton.TabIndex = 13;
            addressButton.Text = "Change";
            addressButton.UseVisualStyleBackColor = true;
            addressButton.Click += addressButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(125, 248);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(161, 82);
            updateButton.TabIndex = 14;
            updateButton.Text = "Update...";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // removeDebtorButton
            // 
            removeDebtorButton.Location = new Point(337, 409);
            removeDebtorButton.Name = "removeDebtorButton";
            removeDebtorButton.Size = new Size(94, 29);
            removeDebtorButton.TabIndex = 15;
            removeDebtorButton.Text = "Remove";
            removeDebtorButton.UseVisualStyleBackColor = true;
            removeDebtorButton.Click += removeDebtorButton_Click;
            // 
            // DebtorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 450);
            Controls.Add(removeDebtorButton);
            Controls.Add(updateButton);
            Controls.Add(addressButton);
            Controls.Add(debtButton);
            Controls.Add(surnameButton);
            Controls.Add(nameButton);
            Controls.Add(debtorAddressLabel);
            Controls.Add(debtorDebtLabel);
            Controls.Add(debtorIdLabel);
            Controls.Add(debtorSurnameLabel);
            Controls.Add(debtorNameLabel);
            Controls.Add(addressFieldLabel);
            Controls.Add(debtFieldLabel);
            Controls.Add(idFieldLabel);
            Controls.Add(surnameFieldLabel);
            Controls.Add(nameFieldLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "DebtorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DebtorForm";
            Load += DebtorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameFieldLabel;
        private Label surnameFieldLabel;
        private Label idFieldLabel;
        private Label debtFieldLabel;
        private Label addressFieldLabel;
        private Label debtorNameLabel;
        private Label debtorSurnameLabel;
        private Label debtorIdLabel;
        private Label debtorDebtLabel;
        private Label debtorAddressLabel;
        private Button nameButton;
        private Button surnameButton;
        private Button debtButton;
        private Button addressButton;
        private Button updateButton;
        private Button removeDebtorButton;
    }
}