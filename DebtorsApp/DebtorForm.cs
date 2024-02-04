using FieldsValidator;
using DebtorsDatabase;

namespace DebtorsApp
{
    public partial class DebtorForm : Form
    {
        private Debtor _debtor;
        private Form1 _mainForm;
        private TextBox _nameTextBox;
        private TextBox _surnameTextBox;
        private TextBox _debtTextBox;
        private TextBox _addressTextBox;

        public DebtorForm(Debtor debtor,Form1 form)
        {
            _debtor = debtor;
            InitializeComponent();
            _nameTextBox = InitTextBox(debtorNameLabel, "nameTextBox");
            _nameTextBox.TextChanged += nameTextBox_TextChanged;
            _surnameTextBox = InitTextBox(debtorSurnameLabel, "surnameTextBox");
            _surnameTextBox.TextChanged += surnameTextBox_TextChanged;
            _debtTextBox = InitTextBox(debtorDebtLabel, "debtTextBox");
            _debtTextBox.TextChanged += debtTextBox_TextChanged;
            _addressTextBox = InitTextBox(debtorAddressLabel, "addressTextBox");
            _addressTextBox.TextChanged += addressTextBox_TextChanged;
            _mainForm = form;


        }



        private void DebtorForm_Load(object sender, EventArgs e)
        {
            debtorSurnameLabel.Text = _debtor.Surname;
            debtorNameLabel.Text = _debtor.Name;
            debtorIdLabel.Text = _debtor.Id.ToString();
            debtorDebtLabel.Text = _debtor.Debt.ToString();
            debtorAddressLabel.Text = _debtor.Address;


        }
        private void surnameButton_Click(object sender, EventArgs e)
        {
            ChangeState(surnameButton, debtorSurnameLabel, _surnameTextBox);
        }

        private void debtButton_Click(object sender, EventArgs e)
        {
            ChangeState(debtButton, debtorDebtLabel, _debtTextBox);
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            ChangeState(addressButton, debtorAddressLabel, _addressTextBox);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            ChangeState(nameButton, debtorNameLabel, _nameTextBox);

        }
        private TextBox InitTextBox(Label attachedLabel, string textBoxName)
        {
            var textBox = new TextBox();
            textBox.Name = textBoxName;
            Controls.Add(textBox);
            textBox.Location = attachedLabel.Location;
            textBox.Text = "Change";
            textBox.Visible = false;
            return textBox;


        }
        private void ChangeState(Button button, Label label, TextBox textBox)
        {
            if (label.Visible)
            {
                textBox.Visible = true;
                label.Visible = false;
                button.Text = "Save";
                textBox.Text = label.Text;
            }
            else
            {

                textBox.Visible = false;
                label.Visible = true;
                button.Text = "Change";
                label.Text = textBox.Text;

            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var newDebtor = new Debtor()
            {
                Id = int.Parse(debtorIdLabel.Text),
                Name = debtorNameLabel.Text,
                Surname = debtorSurnameLabel.Text,
                Debt = double.Parse(debtorDebtLabel.Text.Replace('.', ',')),
                Address = debtorAddressLabel.Text

            };
            DebtorsDB.UpdateDebtor(newDebtor);
            _debtor.Name = newDebtor.Name;
            _debtor.Surname = newDebtor.Surname;
            _debtor.Debt = newDebtor.Debt;
            _debtor.Address = newDebtor.Address;
            _mainForm.RenderUpdatedDebtors();
            Close();
           
          
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsValidName(_nameTextBox.Text))
                ValidFieldDrawing(nameButton, _nameTextBox);
            else
                InvalidFieldDrawing(nameButton, _nameTextBox);
        }
        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsValidName(_surnameTextBox.Text))
                ValidFieldDrawing(surnameButton, _surnameTextBox);
            else
                InvalidFieldDrawing(surnameButton, _surnameTextBox);


        }
        private void debtTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsValidDebt(_debtTextBox.Text))
                ValidFieldDrawing(debtButton, _debtTextBox);
            else
                InvalidFieldDrawing(debtButton, _debtTextBox);

        }
        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validator.IsValidAddress(_addressTextBox.Text))
                ValidFieldDrawing(addressButton, _addressTextBox);
            else
                InvalidFieldDrawing(addressButton, _addressTextBox);
        }
        private void InvalidFieldDrawing(Button button, TextBox textBox)
        {
            button.Enabled = false;
            updateButton.Enabled = false;
            textBox.ForeColor = Color.White;
            textBox.BackColor = Color.Red;

        }
        private void ValidFieldDrawing(Button button, TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
            button.Enabled = true;
            updateButton.Enabled = true;

        }

        private void removeDebtorButton_Click(object sender, EventArgs e)
        {
            DebtorsDB.RemoveDebtor(_debtor);
            _mainForm.RemoveDebtorFromList(_debtor);
            _mainForm.RenderUpdatedDebtors();
            Close();
        }
    }
}
