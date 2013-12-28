namespace UIBank
{
    partial class ViewCustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._lblFIO = new System.Windows.Forms.Label();
            this._lblBirthDate = new System.Windows.Forms.Label();
            this._lblAddress = new System.Windows.Forms.Label();
            this._lblPassportData = new System.Windows.Forms.Label();
            this._lblAccounts = new System.Windows.Forms.Label();
            this._lblLoans = new System.Windows.Forms.Label();
            this._dgvLoans = new System.Windows.Forms.DataGridView();
            this._lblDeposits = new System.Windows.Forms.Label();
            this._dgvDeposits = new System.Windows.Forms.DataGridView();
            this._dgvAccounts = new System.Windows.Forms.DataGridView();
            this._btnAddAccount = new System.Windows.Forms.Button();
            this._btnAddLoan = new System.Windows.Forms.Button();
            this._btnAddDeposit = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingSummaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionDepositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingSummaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionLoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._btnDeleteCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblFIO
            // 
            this._lblFIO.AutoSize = true;
            this._lblFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblFIO.Location = new System.Drawing.Point(54, 36);
            this._lblFIO.Name = "_lblFIO";
            this._lblFIO.Size = new System.Drawing.Size(36, 20);
            this._lblFIO.TabIndex = 0;
            this._lblFIO.Text = "FIO";
            // 
            // _lblBirthDate
            // 
            this._lblBirthDate.AutoSize = true;
            this._lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblBirthDate.Location = new System.Drawing.Point(54, 85);
            this._lblBirthDate.Name = "_lblBirthDate";
            this._lblBirthDate.Size = new System.Drawing.Size(77, 20);
            this._lblBirthDate.TabIndex = 1;
            this._lblBirthDate.Text = "BirthDate";
            // 
            // _lblAddress
            // 
            this._lblAddress.AutoSize = true;
            this._lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblAddress.Location = new System.Drawing.Point(54, 138);
            this._lblAddress.Name = "_lblAddress";
            this._lblAddress.Size = new System.Drawing.Size(68, 20);
            this._lblAddress.TabIndex = 2;
            this._lblAddress.Text = "Address";
            // 
            // _lblPassportData
            // 
            this._lblPassportData.AutoSize = true;
            this._lblPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblPassportData.Location = new System.Drawing.Point(54, 189);
            this._lblPassportData.Name = "_lblPassportData";
            this._lblPassportData.Size = new System.Drawing.Size(119, 20);
            this._lblPassportData.TabIndex = 3;
            this._lblPassportData.Text = "PassportData";
            // 
            // _lblAccounts
            // 
            this._lblAccounts.AutoSize = true;
            this._lblAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblAccounts.Location = new System.Drawing.Point(504, 13);
            this._lblAccounts.Name = "_lblAccounts";
            this._lblAccounts.Size = new System.Drawing.Size(76, 20);
            this._lblAccounts.TabIndex = 4;
            this._lblAccounts.Text = "Accounts";
            // 
            // _lblLoans
            // 
            this._lblLoans.AutoSize = true;
            this._lblLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblLoans.Location = new System.Drawing.Point(521, 216);
            this._lblLoans.Name = "_lblLoans";
            this._lblLoans.Size = new System.Drawing.Size(53, 20);
            this._lblLoans.TabIndex = 6;
            this._lblLoans.Text = "Loans";
            // 
            // _dgvLoans
            // 
            this._dgvLoans.AllowUserToAddRows = false;
            this._dgvLoans.AllowUserToDeleteRows = false;
            this._dgvLoans.AutoGenerateColumns = false;
            this._dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.openingSummaryDataGridViewTextBoxColumn,
            this.summaryDataGridViewTextBoxColumn1,
            this.createDateDataGridViewTextBoxColumn1,
            this.currencyDataGridViewTextBoxColumn1,
            this.optionLoanDataGridViewTextBoxColumn});
            this._dgvLoans.DataSource = this.loanBindingSource;
            this._dgvLoans.Location = new System.Drawing.Point(243, 258);
            this._dgvLoans.MultiSelect = false;
            this._dgvLoans.Name = "_dgvLoans";
            this._dgvLoans.ReadOnly = true;
            this._dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvLoans.Size = new System.Drawing.Size(564, 153);
            this._dgvLoans.TabIndex = 7;
            this._dgvLoans.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvLoans_CellDoubleClick);
            // 
            // _lblDeposits
            // 
            this._lblDeposits.AutoSize = true;
            this._lblDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblDeposits.Location = new System.Drawing.Point(508, 427);
            this._lblDeposits.Name = "_lblDeposits";
            this._lblDeposits.Size = new System.Drawing.Size(72, 20);
            this._lblDeposits.TabIndex = 8;
            this._lblDeposits.Text = "Deposits";
            // 
            // _dgvDeposits
            // 
            this._dgvDeposits.AllowUserToAddRows = false;
            this._dgvDeposits.AllowUserToDeleteRows = false;
            this._dgvDeposits.AutoGenerateColumns = false;
            this._dgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvDeposits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.openingSummaryDataGridViewTextBoxColumn1,
            this.summaryDataGridViewTextBoxColumn2,
            this.createDateDataGridViewTextBoxColumn2,
            this.currencyDataGridViewTextBoxColumn2,
            this.optionDepositDataGridViewTextBoxColumn});
            this._dgvDeposits.DataSource = this.depositBindingSource;
            this._dgvDeposits.Location = new System.Drawing.Point(243, 457);
            this._dgvDeposits.MultiSelect = false;
            this._dgvDeposits.Name = "_dgvDeposits";
            this._dgvDeposits.ReadOnly = true;
            this._dgvDeposits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvDeposits.Size = new System.Drawing.Size(564, 150);
            this._dgvDeposits.TabIndex = 9;
            this._dgvDeposits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvDeposits_CellDoubleClick);
            // 
            // _dgvAccounts
            // 
            this._dgvAccounts.AllowUserToAddRows = false;
            this._dgvAccounts.AllowUserToDeleteRows = false;
            this._dgvAccounts.AutoGenerateColumns = false;
            this._dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.summaryDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn});
            this._dgvAccounts.DataSource = this.accountBindingSource;
            this._dgvAccounts.Location = new System.Drawing.Point(344, 47);
            this._dgvAccounts.MultiSelect = false;
            this._dgvAccounts.Name = "_dgvAccounts";
            this._dgvAccounts.ReadOnly = true;
            this._dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvAccounts.Size = new System.Drawing.Size(403, 150);
            this._dgvAccounts.TabIndex = 10;
            this._dgvAccounts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dgvAccounts_CellDoubleClick);
            // 
            // _btnAddAccount
            // 
            this._btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddAccount.Location = new System.Drawing.Point(580, 0);
            this._btnAddAccount.Name = "_btnAddAccount";
            this._btnAddAccount.Size = new System.Drawing.Size(51, 37);
            this._btnAddAccount.TabIndex = 11;
            this._btnAddAccount.Text = "+";
            this._btnAddAccount.UseVisualStyleBackColor = true;
            this._btnAddAccount.Click += new System.EventHandler(this._btnAddAccount_Click);
            // 
            // _btnAddLoan
            // 
            this._btnAddLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddLoan.Location = new System.Drawing.Point(580, 203);
            this._btnAddLoan.Name = "_btnAddLoan";
            this._btnAddLoan.Size = new System.Drawing.Size(51, 37);
            this._btnAddLoan.TabIndex = 12;
            this._btnAddLoan.Text = "+";
            this._btnAddLoan.UseVisualStyleBackColor = true;
            this._btnAddLoan.Click += new System.EventHandler(this._btnAddLoan_Click);
            // 
            // _btnAddDeposit
            // 
            this._btnAddDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddDeposit.Location = new System.Drawing.Point(580, 414);
            this._btnAddDeposit.Name = "_btnAddDeposit";
            this._btnAddDeposit.Size = new System.Drawing.Size(51, 37);
            this._btnAddDeposit.TabIndex = 13;
            this._btnAddDeposit.Text = "+";
            this._btnAddDeposit.UseVisualStyleBackColor = true;
            this._btnAddDeposit.Click += new System.EventHandler(this._btnAddDeposit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            this.summaryDataGridViewTextBoxColumn.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            this.summaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(CourseProject.Core.Entities.Account);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // openingSummaryDataGridViewTextBoxColumn1
            // 
            this.openingSummaryDataGridViewTextBoxColumn1.DataPropertyName = "OpeningSummary";
            this.openingSummaryDataGridViewTextBoxColumn1.HeaderText = "OpeningSummary";
            this.openingSummaryDataGridViewTextBoxColumn1.Name = "openingSummaryDataGridViewTextBoxColumn1";
            this.openingSummaryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // summaryDataGridViewTextBoxColumn2
            // 
            this.summaryDataGridViewTextBoxColumn2.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn2.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn2.Name = "summaryDataGridViewTextBoxColumn2";
            this.summaryDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn2
            // 
            this.createDateDataGridViewTextBoxColumn2.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn2.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn2.Name = "createDateDataGridViewTextBoxColumn2";
            this.createDateDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // currencyDataGridViewTextBoxColumn2
            // 
            this.currencyDataGridViewTextBoxColumn2.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn2.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn2.Name = "currencyDataGridViewTextBoxColumn2";
            this.currencyDataGridViewTextBoxColumn2.ReadOnly = true;
            this.currencyDataGridViewTextBoxColumn2.Width = 70;
            // 
            // optionDepositDataGridViewTextBoxColumn
            // 
            this.optionDepositDataGridViewTextBoxColumn.DataPropertyName = "OptionDeposit";
            this.optionDepositDataGridViewTextBoxColumn.HeaderText = "OptionDeposit";
            this.optionDepositDataGridViewTextBoxColumn.Name = "optionDepositDataGridViewTextBoxColumn";
            this.optionDepositDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataSource = typeof(CourseProject.Core.Entities.Deposit);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // openingSummaryDataGridViewTextBoxColumn
            // 
            this.openingSummaryDataGridViewTextBoxColumn.DataPropertyName = "OpeningSummary";
            this.openingSummaryDataGridViewTextBoxColumn.HeaderText = "OpeningSummary";
            this.openingSummaryDataGridViewTextBoxColumn.Name = "openingSummaryDataGridViewTextBoxColumn";
            this.openingSummaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaryDataGridViewTextBoxColumn1
            // 
            this.summaryDataGridViewTextBoxColumn1.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn1.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn1.Name = "summaryDataGridViewTextBoxColumn1";
            this.summaryDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn1
            // 
            this.createDateDataGridViewTextBoxColumn1.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn1.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn1.Name = "createDateDataGridViewTextBoxColumn1";
            this.createDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // currencyDataGridViewTextBoxColumn1
            // 
            this.currencyDataGridViewTextBoxColumn1.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn1.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn1.Name = "currencyDataGridViewTextBoxColumn1";
            this.currencyDataGridViewTextBoxColumn1.ReadOnly = true;
            this.currencyDataGridViewTextBoxColumn1.Width = 70;
            // 
            // optionLoanDataGridViewTextBoxColumn
            // 
            this.optionLoanDataGridViewTextBoxColumn.DataPropertyName = "OptionLoan";
            this.optionLoanDataGridViewTextBoxColumn.HeaderText = "OptionLoan";
            this.optionLoanDataGridViewTextBoxColumn.Name = "optionLoanDataGridViewTextBoxColumn";
            this.optionLoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(CourseProject.Core.Entities.Loan);
            // 
            // _btnDeleteCustomer
            // 
            this._btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnDeleteCustomer.Location = new System.Drawing.Point(28, 554);
            this._btnDeleteCustomer.Name = "_btnDeleteCustomer";
            this._btnDeleteCustomer.Size = new System.Drawing.Size(145, 37);
            this._btnDeleteCustomer.TabIndex = 14;
            this._btnDeleteCustomer.Text = "Delete customer";
            this._btnDeleteCustomer.UseVisualStyleBackColor = true;
            this._btnDeleteCustomer.Click += new System.EventHandler(this._btnDeleteCustomer_Click);
            // 
            // ViewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 619);
            this.Controls.Add(this._btnDeleteCustomer);
            this.Controls.Add(this._btnAddDeposit);
            this.Controls.Add(this._btnAddLoan);
            this.Controls.Add(this._btnAddAccount);
            this.Controls.Add(this._dgvAccounts);
            this.Controls.Add(this._dgvDeposits);
            this.Controls.Add(this._lblDeposits);
            this.Controls.Add(this._dgvLoans);
            this.Controls.Add(this._lblLoans);
            this.Controls.Add(this._lblAccounts);
            this.Controls.Add(this._lblPassportData);
            this.Controls.Add(this._lblAddress);
            this.Controls.Add(this._lblBirthDate);
            this.Controls.Add(this._lblFIO);
            this.Name = "ViewCustomerForm";
            this.Text = "ViewCustomerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewCustomerForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblFIO;
        private System.Windows.Forms.Label _lblBirthDate;
        private System.Windows.Forms.Label _lblAddress;
        private System.Windows.Forms.Label _lblPassportData;
        private System.Windows.Forms.Label _lblAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label _lblLoans;
        private System.Windows.Forms.DataGridView _dgvLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label _lblDeposits;
        private System.Windows.Forms.DataGridView _dgvDeposits;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridView _dgvAccounts;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.BindingSource depositBindingSource;
        private System.Windows.Forms.Button _btnAddAccount;
        private System.Windows.Forms.Button _btnAddLoan;
        private System.Windows.Forms.Button _btnAddDeposit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingSummaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionLoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingSummaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionDepositDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button _btnDeleteCustomer;
    }
}