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
            SuspendLayout();
            // 
            // debtorsListBox
            // 
            debtorsListBox.BackColor = Color.FromArgb(224, 224, 224);
            debtorsListBox.FormattingEnabled = true;
            debtorsListBox.ItemHeight = 20;
            debtorsListBox.Location = new Point(24, 12);
            debtorsListBox.Name = "debtorsListBox";
            debtorsListBox.Size = new Size(415, 404);
            debtorsListBox.TabIndex = 0;
            debtorsListBox.DoubleClick += debtorsListBox_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 450);
            Controls.Add(debtorsListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox debtorsListBox;
    }
}