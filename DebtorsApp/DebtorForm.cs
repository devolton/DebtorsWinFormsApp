using FieldsValidator;
using DebtorsDatabase;

namespace DebtorsApp
{
    public partial class DebtorForm : Form
    {
        private Debtor _debtor;
        private TextBox _nameTextBox;
        private TextBox _surnameTextBox;
        private TextBox _debtTextBox;
        private TextBox _addressTextBox;

        public DebtorForm(Debtor debtor)
        {
            _debtor = debtor;
            InitializeComponent();
            _nameTextBox = InitTextBox(debtorNameLabel, "nameTextBox");
            _surnameTextBox = InitTextBox(debtorSurnameLabel, "surnameTextBox");
            _debtTextBox = InitTextBox(debtorDebtLabel, "debtTextBox");
            _addressTextBox = InitTextBox(debtorAddressLabel, "addressTextBox");


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
            DebtorsDB.UpdateDebtor(new Debtor()
            {
                Id = int.Parse(debtorIdLabel.Text),
                Name = debtorNameLabel.Text,
                Surname = debtorSurnameLabel.Text,
                Debt = double.Parse(debtorDebtLabel.Text),
                Address = debtorAddressLabel.Text

            });
        }
    }
}
