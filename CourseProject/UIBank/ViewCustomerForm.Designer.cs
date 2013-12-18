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
            this._dgvAccounts = new System.Windows.Forms.DataGridView();
            this._lblLoans = new System.Windows.Forms.Label();
            this._dgvLoans = new System.Windows.Forms.DataGridView();
            this._lblDeposits = new System.Windows.Forms.Label();
            this._dgvDeposits = new System.Windows.Forms.DataGridView();
            this.summaryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionDepositDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summaryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionLoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
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
            this._lblAccounts.Location = new System.Drawing.Point(508, 9);
            this._lblAccounts.Name = "_lblAccounts";
            this._lblAccounts.Size = new System.Drawing.Size(76, 20);
            this._lblAccounts.TabIndex = 4;
            this._lblAccounts.Text = "Accounts";
            // 
            // _dgvAccounts
            // 
            this._dgvAccounts.AllowUserToAddRows = false;
            this._dgvAccounts.AllowUserToDeleteRows = false;
            this._dgvAccounts.AutoGenerateColumns = false;
            this._dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createDateDataGridViewTextBoxColumn,
            this.summaryDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn});
            this._dgvAccounts.DataSource = this.accountBindingSource;
            this._dgvAccounts.Location = new System.Drawing.Point(389, 47);
            this._dgvAccounts.Name = "_dgvAccounts";
            this._dgvAccounts.ReadOnly = true;
            this._dgvAccounts.Size = new System.Drawing.Size(310, 138);
            this._dgvAccounts.TabIndex = 5;
            // 
            // _lblLoans
            // 
            this._lblLoans.AutoSize = true;
            this._lblLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblLoans.Location = new System.Drawing.Point(521, 212);
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
            this.summaryDataGridViewTextBoxColumn1,
            this.createDateDataGridViewTextBoxColumn1,
            this.currencyDataGridViewTextBoxColumn1,
            this.optionLoanDataGridViewTextBoxColumn});
            this._dgvLoans.DataSource = this.loanBindingSource;
            this._dgvLoans.Location = new System.Drawing.Point(323, 235);
            this._dgvLoans.Name = "_dgvLoans";
            this._dgvLoans.ReadOnly = true;
            this._dgvLoans.Size = new System.Drawing.Size(452, 145);
            this._dgvLoans.TabIndex = 7;
            // 
            // _lblDeposits
            // 
            this._lblDeposits.AutoSize = true;
            this._lblDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblDeposits.Location = new System.Drawing.Point(512, 399);
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
            this.summaryDataGridViewTextBoxColumn2,
            this.createDateDataGridViewTextBoxColumn2,
            this.currencyDataGridViewTextBoxColumn2,
            this.optionDepositDataGridViewTextBoxColumn});
            this._dgvDeposits.DataSource = this.depositBindingSource;
            this._dgvDeposits.Location = new System.Drawing.Point(323, 434);
            this._dgvDeposits.Name = "_dgvDeposits";
            this._dgvDeposits.ReadOnly = true;
            this._dgvDeposits.Size = new System.Drawing.Size(452, 150);
            this._dgvDeposits.TabIndex = 9;
            // 
            // summaryDataGridViewTextBoxColumn2
            // 
            this.summaryDataGridViewTextBoxColumn2.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn2.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn2.Name = "summaryDataGridViewTextBoxColumn2";
            this.summaryDataGridViewTextBoxColumn2.ReadOnly = true;
            this.summaryDataGridViewTextBoxColumn2.Width = 80;
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
            // 
            // optionDepositDataGridViewTextBoxColumn
            // 
            this.optionDepositDataGridViewTextBoxColumn.DataPropertyName = "OptionDeposit";
            this.optionDepositDataGridViewTextBoxColumn.HeaderText = "OptionDeposit";
            this.optionDepositDataGridViewTextBoxColumn.Name = "optionDepositDataGridViewTextBoxColumn";
            this.optionDepositDataGridViewTextBoxColumn.ReadOnly = true;
            this.optionDepositDataGridViewTextBoxColumn.Width = 95;
            // 
            // depositBindingSource
            // 
            this.depositBindingSource.DataSource = typeof(CourseProject.Core.Entities.Deposit);
            // 
            // summaryDataGridViewTextBoxColumn1
            // 
            this.summaryDataGridViewTextBoxColumn1.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn1.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn1.Name = "summaryDataGridViewTextBoxColumn1";
            this.summaryDataGridViewTextBoxColumn1.ReadOnly = true;
            this.summaryDataGridViewTextBoxColumn1.Width = 80;
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
            // 
            // optionLoanDataGridViewTextBoxColumn
            // 
            this.optionLoanDataGridViewTextBoxColumn.DataPropertyName = "OptionLoan";
            this.optionLoanDataGridViewTextBoxColumn.HeaderText = "OptionLoan";
            this.optionLoanDataGridViewTextBoxColumn.Name = "optionLoanDataGridViewTextBoxColumn";
            this.optionLoanDataGridViewTextBoxColumn.ReadOnly = true;
            this.optionLoanDataGridViewTextBoxColumn.Width = 95;
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataSource = typeof(CourseProject.Core.Entities.Loan);
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            this.summaryDataGridViewTextBoxColumn.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            this.summaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.summaryDataGridViewTextBoxColumn.Width = 80;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyDataGridViewTextBoxColumn.Width = 60;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(CourseProject.Core.Entities.Account);
            // 
            // ViewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 596);
            this.Controls.Add(this._dgvDeposits);
            this.Controls.Add(this._lblDeposits);
            this.Controls.Add(this._dgvLoans);
            this.Controls.Add(this._lblLoans);
            this.Controls.Add(this._dgvAccounts);
            this.Controls.Add(this._lblAccounts);
            this.Controls.Add(this._lblPassportData);
            this.Controls.Add(this._lblAddress);
            this.Controls.Add(this._lblBirthDate);
            this.Controls.Add(this._lblFIO);
            this.Name = "ViewCustomerForm";
            this.Text = "ViewCustomerForm";
            this.Load += new System.EventHandler(this.ViewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._dgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblFIO;
        private System.Windows.Forms.Label _lblBirthDate;
        private System.Windows.Forms.Label _lblAddress;
        private System.Windows.Forms.Label _lblPassportData;
        private System.Windows.Forms.Label _lblAccounts;
        private System.Windows.Forms.DataGridView _dgvAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.Label _lblLoans;
        private System.Windows.Forms.DataGridView _dgvLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionLoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private System.Windows.Forms.Label _lblDeposits;
        private System.Windows.Forms.DataGridView _dgvDeposits;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionDepositDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource depositBindingSource;
    }
}