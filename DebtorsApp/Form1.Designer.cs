namespace DebtorsApp
{
    partial class Form1
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
            debtorsListBox = new ListBox();
            mainDebtorsLabel = new Label();
            SuspendLayout();
            // 
            // debtorsListBox
            // 
            debtorsListBox.BackColor = SystemColors.Window;
            debtorsListBox.BorderStyle = BorderStyle.FixedSingle;
            debtorsListBox.Font = new Font("Georgia", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            debtorsListBox.FormattingEnabled = true;
            debtorsListBox.ItemHeight = 27;
            debtorsListBox.Location = new Point(24, 92);
            debtorsListBox.Name = "debtorsListBox";
            debtorsListBox.Size = new Size(415, 299);
            debtorsListBox.TabIndex = 0;
            debtorsListBox.DoubleClick += debtorsListBox_DoubleClick;
            // 
            // mainDebtorsLabel
            // 
            mainDebtorsLabel.AutoSize = true;
            mainDebtorsLabel.BackColor = SystemColors.Desktop;
            mainDebtorsLabel.Font = new Font("Georgia", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            mainDebtorsLabel.ForeColor = SystemColors.Info;
            mainDebtorsLabel.Location = new Point(122, 9);
            mainDebtorsLabel.Name = "mainDebtorsLabel";
            mainDebtorsLabel.Size = new Size(216, 54);
            mainDebtorsLabel.TabIndex = 1;
            mainDebtorsLabel.Text = "Debtors";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(451, 450);
            Controls.Add(mainDebtorsLabel);
            Controls.Add(debtorsListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox debtorsListBox;
        private Label mainDebtorsLabel;
    }
}