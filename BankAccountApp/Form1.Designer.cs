namespace BankAccountApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label1 = new Label();
            OwnerText = new TextBox();
            AccountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositeBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AccountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // OwnerText
            // 
            resources.ApplyResources(OwnerText, "OwnerText");
            OwnerText.Name = "OwnerText";
            // 
            // AccountNum
            // 
            resources.ApplyResources(AccountNum, "AccountNum");
            AccountNum.Name = "AccountNum";
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(BankAccountsGrid, "BankAccountsGrid");
            BankAccountsGrid.Name = "BankAccountsGrid";
            // 
            // DepositeBtn
            // 
            resources.ApplyResources(DepositeBtn, "DepositeBtn");
            DepositeBtn.Name = "DepositeBtn";
            DepositeBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawBtn
            // 
            resources.ApplyResources(WithdrawBtn, "WithdrawBtn");
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            resources.ApplyResources(CreateAccountBtn, "CreateAccountBtn");
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositeBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AccountNum);
            Controls.Add(OwnerText);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AccountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox OwnerText;
        private NumericUpDown AccountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositeBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
    }
}
