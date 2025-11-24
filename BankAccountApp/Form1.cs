namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BankAccount account = new BankAccount("Ibrahim Mohamed", Guid.NewGuid(), 1000.50m);
            BankAccount account2 = new BankAccount("Elon Musk", Guid.NewGuid(), 1000000002322323.50m);
            BankAccount account3 = new BankAccount("Tim Cook", Guid.NewGuid(), 10003434343434.50m);
      
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
