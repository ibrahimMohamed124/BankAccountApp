using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerText.Text))
            {
                MessageBox.Show("Enter a valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BankAccounts.Count > 0)
            {
                var exists = BankAccounts.Any(b => b.Owner.Equals(OwnerText.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                if (exists)
                {
                    DisplayErrorMessage("An account with this owner name already exists.");
                    return;
                }
            }
            BankAccount bankAccounts = new BankAccount(OwnerText.Text.Trim());
            BankAccounts.Add(bankAccounts);
            RefreshGrid();
            OwnerText.Clear();
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }

        private void DepositeBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedbankAccount = (BankAccount)BankAccountsGrid.SelectedRows[0].DataBoundItem;
                string message = selectedbankAccount.Deposit(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1 && AmountNum.Value > 0)
            {
                BankAccount selectedbankAccount = (BankAccount)BankAccountsGrid.SelectedRows[0].DataBoundItem;
                string message = selectedbankAccount.Withdraw(AmountNum.Value);
                RefreshGrid();
                AmountNum.Value = 0;
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void DisplayErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}