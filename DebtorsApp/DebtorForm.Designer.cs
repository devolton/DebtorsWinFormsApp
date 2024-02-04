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
            oneDebtorMainLabel = new Label();
            SuspendLayout();
            // 
            // nameFieldLabel
            // 
            nameFieldLabel.AutoSize = true;
            nameFieldLabel.Font = new Font("Georgia", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            nameFieldLabel.ForeColor = SystemColors.Window;
            nameFieldLabel.Location = new Point(12, 99);
            nameFieldLabel.Name = "nameFieldLabel";
            nameFieldLabel.Size = new Size(99, 32);
            nameFieldLabel.TabIndex = 0;
            nameFieldLabel.Text = "Name";
            // 
            // surnameFieldLabel
            // 
            surnameFieldLabel.AutoSize = true;
            surnameFieldLabel.BackColor = SystemColors.InfoText;
            surnameFieldLabel.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            surnameFieldLabel.ForeColor = SystemColors.Window;
            surnameFieldLabel.Location = new Point(177, 96);
            surnameFieldLabel.Name = "surnameFieldLabel";
            surnameFieldLabel.Size = new Size(156, 35);
            surnameFieldLabel.TabIndex = 1;
            surnameFieldLabel.Text = "Surname";
            // 
            // idFieldLabel
            // 
            idFieldLabel.AutoSize = true;
            idFieldLabel.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            idFieldLabel.ForeColor = SystemColors.Window;
            idFieldLabel.Location = new Point(395, 96);
            idFieldLabel.Name = "idFieldLabel";
            idFieldLabel.Size = new Size(53, 35);
            idFieldLabel.TabIndex = 2;
            idFieldLabel.Text = "ID";
            // 
            // debtFieldLabel
            // 
            debtFieldLabel.AutoSize = true;
            debtFieldLabel.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            debtFieldLabel.ForeColor = SystemColors.Window;
            debtFieldLabel.Location = new Point(547, 96);
            debtFieldLabel.Name = "debtFieldLabel";
            debtFieldLabel.Size = new Size(88, 35);
            debtFieldLabel.TabIndex = 3;
            debtFieldLabel.Text = "Debt";
            // 
            // addressFieldLabel
            // 
            addressFieldLabel.AutoSize = true;
            addressFieldLabel.Font = new Font("Georgia", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            addressFieldLabel.ForeColor = SystemColors.Window;
            addressFieldLabel.Location = new Point(711, 96);
            addressFieldLabel.Name = "addressFieldLabel";
            addressFieldLabel.Size = new Size(141, 35);
            addressFieldLabel.TabIndex = 4;
            addressFieldLabel.Text = "Address";
            // 
            // debtorNameLabel
            // 
            debtorNameLabel.AutoSize = true;
            debtorNameLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            debtorNameLabel.ForeColor = SystemColors.Window;
            debtorNameLabel.Location = new Point(24, 157);
            debtorNameLabel.Name = "debtorNameLabel";
            debtorNameLabel.Size = new Size(121, 24);
            debtorNameLabel.TabIndex = 5;
            debtorNameLabel.Text = "debtorName";
            // 
            // debtorSurnameLabel
            // 
            debtorSurnameLabel.AutoSize = true;
            debtorSurnameLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            debtorSurnameLabel.ForeColor = SystemColors.Window;
            debtorSurnameLabel.Location = new Point(190, 157);
            debtorSurnameLabel.Name = "debtorSurnameLabel";
            debtorSurnameLabel.Size = new Size(149, 24);
            debtorSurnameLabel.TabIndex = 6;
            debtorSurnameLabel.Text = "debtorSurname";
            // 
            // debtorIdLabel
            // 
            debtorIdLabel.AutoSize = true;
            debtorIdLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            debtorIdLabel.ForeColor = SystemColors.Window;
            debtorIdLabel.Location = new Point(405, 157);
            debtorIdLabel.Name = "debtorIdLabel";
            debtorIdLabel.Size = new Size(87, 24);
            debtorIdLabel.TabIndex = 7;
            debtorIdLabel.Text = "debtorId";
            // 
            // debtorDebtLabel
            // 
            debtorDebtLabel.AutoSize = true;
            debtorDebtLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            debtorDebtLabel.ForeColor = SystemColors.Window;
            debtorDebtLabel.Location = new Point(548, 157);
            debtorDebtLabel.Name = "debtorDebtLabel";
            debtorDebtLabel.Size = new Size(111, 24);
            debtorDebtLabel.TabIndex = 8;
            debtorDebtLabel.Text = "debtorDebt";
            // 
            // debtorAddressLabel
            // 
            debtorAddressLabel.AutoSize = true;
            debtorAddressLabel.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            debtorAddressLabel.ForeColor = SystemColors.Window;
            debtorAddressLabel.Location = new Point(720, 157);
            debtorAddressLabel.Name = "debtorAddressLabel";
            debtorAddressLabel.Size = new Size(139, 24);
            debtorAddressLabel.TabIndex = 9;
            debtorAddressLabel.Text = "debtorAddress";
            // 
            // nameButton
            // 
            nameButton.BackColor = Color.Orange;
            nameButton.FlatAppearance.BorderSize = 0;
            nameButton.FlatStyle = FlatStyle.Flat;
            nameButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nameButton.ForeColor = SystemColors.Window;
            nameButton.Location = new Point(12, 211);
            nameButton.Name = "nameButton";
            nameButton.Size = new Size(94, 29);
            nameButton.TabIndex = 10;
            nameButton.Text = "Change";
            nameButton.UseVisualStyleBackColor = false;
            nameButton.Click += nameButton_Click;
            // 
            // surnameButton
            // 
            surnameButton.BackColor = Color.Orange;
            surnameButton.FlatAppearance.BorderSize = 0;
            surnameButton.FlatStyle = FlatStyle.Flat;
            surnameButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            surnameButton.ForeColor = SystemColors.Window;
            surnameButton.Location = new Point(208, 211);
            surnameButton.Name = "surnameButton";
            surnameButton.Size = new Size(94, 29);
            surnameButton.TabIndex = 11;
            surnameButton.Text = "Change";
            surnameButton.UseVisualStyleBackColor = false;
            surnameButton.Click += surnameButton_Click;
            // 
            // debtButton
            // 
            debtButton.BackColor = Color.Orange;
            debtButton.FlatAppearance.BorderSize = 0;
            debtButton.FlatStyle = FlatStyle.Flat;
            debtButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            debtButton.ForeColor = SystemColors.Window;
            debtButton.Location = new Point(547, 211);
            debtButton.Name = "debtButton";
            debtButton.Size = new Size(94, 29);
            debtButton.TabIndex = 12;
            debtButton.Text = "Change";
            debtButton.UseVisualStyleBackColor = false;
            debtButton.Click += debtButton_Click;
            // 
            // addressButton
            // 
            addressButton.BackColor = Color.Orange;
            addressButton.FlatAppearance.BorderSize = 0;
            addressButton.FlatStyle = FlatStyle.Flat;
            addressButton.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addressButton.ForeColor = SystemColors.Window;
            addressButton.Location = new Point(733, 211);
            addressButton.Name = "addressButton";
            addressButton.Size = new Size(94, 29);
            addressButton.TabIndex = 13;
            addressButton.Text = "Change";
            addressButton.UseVisualStyleBackColor = false;
            addressButton.Click += addressButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.Lime;
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = SystemColors.Window;
            updateButton.Location = new Point(228, 302);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(391, 82);
            updateButton.TabIndex = 14;
            updateButton.Text = "Update...";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // removeDebtorButton
            // 
            removeDebtorButton.BackColor = Color.Red;
            removeDebtorButton.FlatAppearance.BorderSize = 0;
            removeDebtorButton.FlatStyle = FlatStyle.Flat;
            removeDebtorButton.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            removeDebtorButton.ForeColor = SystemColors.Window;
            removeDebtorButton.Location = new Point(755, 400);
            removeDebtorButton.Name = "removeDebtorButton";
            removeDebtorButton.Size = new Size(118, 38);
            removeDebtorButton.TabIndex = 15;
            removeDebtorButton.Text = "Remove";
            removeDebtorButton.UseVisualStyleBackColor = false;
            removeDebtorButton.Click += removeDebtorButton_Click;
            // 
            // oneDebtorMainLabel
            // 
            oneDebtorMainLabel.AutoSize = true;
            oneDebtorMainLabel.BackColor = SystemColors.MenuText;
            oneDebtorMainLabel.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point);
            oneDebtorMainLabel.ForeColor = SystemColors.Window;
            oneDebtorMainLabel.Location = new Point(228, 9);
            oneDebtorMainLabel.Name = "oneDebtorMainLabel";
            oneDebtorMainLabel.Size = new Size(391, 69);
            oneDebtorMainLabel.TabIndex = 16;
            oneDebtorMainLabel.Text = "Debtor Info";
            // 
            // DebtorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(885, 450);
            Controls.Add(oneDebtorMainLabel);
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
        private Label oneDebtorMainLabel;
    }
}