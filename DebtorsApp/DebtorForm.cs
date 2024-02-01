using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebtorsDatabase;

namespace DebtorsApp
{
    public partial class DebtorForm : Form
    {
        private Debtor _debtor;
        public DebtorForm(Debtor debtor)
        {
            _debtor = debtor;
            InitializeComponent();
          
        }

        private void DebtorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
