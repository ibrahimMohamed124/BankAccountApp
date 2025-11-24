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

            if (BankAccounts.Count > 0 ) {
                var exists = BankAccounts.Any(b => b.Owner.Equals(OwnerText.Text.Trim(), StringComparison.OrdinalIgnoreCase));
                if (exists) {
                    MessageBox.Show("An account with this owner name already exists.");
                    return;
                }
            }
            BankAccount bankAccounts = new BankAccount(OwnerText.Text.Trim());
            BankAccounts.Add(bankAccounts);
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = BankAccounts;
        }
    }
}
