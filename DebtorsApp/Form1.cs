using DebtorsDatabase;
namespace DebtorsApp
{
    public partial class Form1 : Form
    {

        private List<Debtor> _debtors;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            _debtors = DebtorsDB.GetAllDebtors().ToList();
            RenderDebtors(_debtors);



        }
        public void RenderUpdatedDebtors()
        {
            debtorsListBox.Items.Clear();
            RenderDebtors(_debtors);
        }
        public void RemoveDebtorFromList(Debtor debtor)
        {
            if (_debtors.Any(oneDebtor => oneDebtor.Id == debtor.Id))
            {
                _debtors.Remove(debtor);
            }
        }

        private void RenderDebtors(IEnumerable<Debtor> debtors)
        {
            foreach (var debtor in debtors)
            {
                debtorsListBox.Items.Add(($"{debtor.Surname} {debtor.Name} - ({debtor.Debt} UAH)"));
            }
        }

        private void debtorsListBox_DoubleClick(object sender, EventArgs e)
        {
            int debtorId = debtorsListBox.SelectedIndex;
            var debtor = _debtors.ToList()[debtorId];
            var debtorForm = new DebtorForm(debtor, this);
            debtorForm.ShowDialog();

        }


    }
}