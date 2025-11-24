namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount account = new BankAccount();
            account.Owner = "Ibrahim Mohamed";
            account.AccountNumber = Guid.NewGuid();
            account.Balance = 1000.50m;

            BankAccount account2 = new BankAccount();
            account2.Owner = "Elon Musk";
            account2.AccountNumber = Guid.NewGuid();
            account2.Balance = 1000000002322323.50m;

            BankAccount account3 = new BankAccount();
            account3.Owner = "Tim Cook";
            account3.AccountNumber = Guid.NewGuid();
            account3.Balance = 10003434343434.50m;

            List<BankAccount> bankAccounts = new List<BankAccount>();
            {
                bankAccounts.Add(account);
                bankAccounts.Add(account2);
                bankAccounts.Add(account3);
            }

            BankAccountsGrid.DataSource = bankAccounts;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
