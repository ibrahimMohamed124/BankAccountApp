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
            acc = new Label();
            OwnerText = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositeBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // acc
            // 
            resources.ApplyResources(acc, "acc");
            acc.Name = "acc";
            // 
            // OwnerText
            // 
            resources.ApplyResources(OwnerText, "OwnerText");
            OwnerText.Name = "OwnerText";
            // 
            // AmountNum
            // 
            resources.ApplyResources(AmountNum, "AmountNum");
            AmountNum.Maximum = new decimal(new int[] { 1215752191, 23, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 1410065407, 2, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(BankAccountsGrid, "BankAccountsGrid");
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // DepositeBtn
            // 
            resources.ApplyResources(DepositeBtn, "DepositeBtn");
            DepositeBtn.Name = "DepositeBtn";
            DepositeBtn.UseVisualStyleBackColor = true;
            DepositeBtn.Click += DepositeBtn_Click;
            // 
            // WithdrawBtn
            // 
            resources.ApplyResources(WithdrawBtn, "WithdrawBtn");
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
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
            Controls.Add(AmountNum);
            Controls.Add(OwnerText);
            Controls.Add(acc);
            Controls.Add(label2);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label acc;
        private TextBox textBox1;
        private TextBox OwnerText;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositeBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
    }
}
