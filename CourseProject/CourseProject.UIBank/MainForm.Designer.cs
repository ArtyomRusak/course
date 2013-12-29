namespace CourseProject.UIBank
{
    partial class MainForm
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
            this._btnAddAccount = new System.Windows.Forms.Button();
            this._btnAddDeposit = new System.Windows.Forms.Button();
            this._btnAddLoan = new System.Windows.Forms.Button();
            this._btnAddCustomer = new System.Windows.Forms.Button();
            this._lblAccounts = new System.Windows.Forms.Label();
            this._lblLoans = new System.Windows.Forms.Label();
            this._lblDeposits = new System.Windows.Forms.Label();
            this._lblCustomers = new System.Windows.Forms.Label();
            this._btnFindCustomer = new System.Windows.Forms.Button();
            this._dgvCustomers = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._tbxFindCustomer = new System.Windows.Forms.TextBox();
            this._cbxSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnAddAccount
            // 
            this._btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddAccount.Location = new System.Drawing.Point(772, 52);
            this._btnAddAccount.Name = "_btnAddAccount";
            this._btnAddAccount.Size = new System.Drawing.Size(161, 54);
            this._btnAddAccount.TabIndex = 0;
            this._btnAddAccount.Text = "Add account";
            this._btnAddAccount.UseVisualStyleBackColor = true;
            this._btnAddAccount.Click += new System.EventHandler(this._btnAddAccount_Click);
            // 
            // _btnAddDeposit
            // 
            this._btnAddDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddDeposit.Location = new System.Drawing.Point(772, 134);
            this._btnAddDeposit.Name = "_btnAddDeposit";
            this._btnAddDeposit.Size = new System.Drawing.Size(161, 54);
            this._btnAddDeposit.TabIndex = 1;
            this._btnAddDeposit.Text = "Add deposit";
            this._btnAddDeposit.UseVisualStyleBackColor = true;
            this._btnAddDeposit.Click += new System.EventHandler(this._btnAddDeposit_Click);
            // 
            // _btnAddLoan
            // 
            this._btnAddLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddLoan.Location = new System.Drawing.Point(772, 220);
            this._btnAddLoan.Name = "_btnAddLoan";
            this._btnAddLoan.Size = new System.Drawing.Size(161, 54);
            this._btnAddLoan.TabIndex = 2;
            this._btnAddLoan.Text = "Add loan";
            this._btnAddLoan.UseVisualStyleBackColor = true;
            this._btnAddLoan.Click += new System.EventHandler(this._btnAddLoan_Click);
            // 
            // _btnAddCustomer
            // 
            this._btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddCustomer.Location = new System.Drawing.Point(452, 56);
            this._btnAddCustomer.Name = "_btnAddCustomer";
            this._btnAddCustomer.Size = new System.Drawing.Size(161, 54);
            this._btnAddCustomer.TabIndex = 3;
            this._btnAddCustomer.Text = "Add customer";
            this._btnAddCustomer.UseVisualStyleBackColor = true;
            this._btnAddCustomer.Click += new System.EventHandler(this._btnAddCustomer_Click);
            // 
            // _lblAccounts
            // 
            this._lblAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblAccounts.Location = new System.Drawing.Point(51, 73);
            this._lblAccounts.Name = "_lblAccounts";
            this._lblAccounts.Size = new System.Drawing.Size(245, 31);
            this._lblAccounts.TabIndex = 4;
            this._lblAccounts.Text = "label1";
            // 
            // _lblLoans
            // 
            this._lblLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblLoans.Location = new System.Drawing.Point(51, 114);
            this._lblLoans.Name = "_lblLoans";
            this._lblLoans.Size = new System.Drawing.Size(215, 31);
            this._lblLoans.TabIndex = 5;
            this._lblLoans.Text = "label2";
            // 
            // _lblDeposits
            // 
            this._lblDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblDeposits.Location = new System.Drawing.Point(51, 155);
            this._lblDeposits.Name = "_lblDeposits";
            this._lblDeposits.Size = new System.Drawing.Size(199, 35);
            this._lblDeposits.TabIndex = 6;
            this._lblDeposits.Text = "label3";
            // 
            // _lblCustomers
            // 
            this._lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblCustomers.Location = new System.Drawing.Point(51, 27);
            this._lblCustomers.Name = "_lblCustomers";
            this._lblCustomers.Size = new System.Drawing.Size(199, 36);
            this._lblCustomers.TabIndex = 7;
            this._lblCustomers.Text = "label4";
            // 
            // _btnFindCustomer
            // 
            this._btnFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnFindCustomer.Location = new System.Drawing.Point(293, 332);
            this._btnFindCustomer.Name = "_btnFindCustomer";
            this._btnFindCustomer.Size = new System.Drawing.Size(135, 37);
            this._btnFindCustomer.TabIndex = 8;
            this._btnFindCustomer.Text = "Find";
            this._btnFindCustomer.UseVisualStyleBackColor = true;
            this._btnFindCustomer.Click += new System.EventHandler(this.@__findCustomer_Click);
            // 
            // _dgvCustomers
            // 
            this._dgvCustomers.AllowUserToAddRows = false;
            this._dgvCustomers.AllowUserToDeleteRows = false;
            this._dgvCustomers.AutoGenerateColumns = false;
            this._dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.passportDataDataGridViewTextBoxColumn});
            this._dgvCustomers.DataSource = this.customerBindingSource;
            this._dgvCustomers.Location = new System.Drawing.Point(145, 386);
            this._dgvCustomers.MultiSelect = false;
            this._dgvCustomers.Name = "_dgvCustomers";
            this._dgvCustomers.ReadOnly = true;
            this._dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvCustomers.Size = new System.Drawing.Size(732, 238);
            this._dgvCustomers.TabIndex = 9;
            this._dgvCustomers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this._customerView_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            this.patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            this.patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            this.patronymicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 50;
            // 
            // passportDataDataGridViewTextBoxColumn
            // 
            this.passportDataDataGridViewTextBoxColumn.DataPropertyName = "PassportData";
            this.passportDataDataGridViewTextBoxColumn.HeaderText = "PassportData";
            this.passportDataDataGridViewTextBoxColumn.Name = "passportDataDataGridViewTextBoxColumn";
            this.passportDataDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportDataDataGridViewTextBoxColumn.Width = 130;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CourseProject.Core.Entities.Customer);
            // 
            // _tbxFindCustomer
            // 
            this._tbxFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxFindCustomer.Location = new System.Drawing.Point(452, 341);
            this._tbxFindCustomer.Name = "_tbxFindCustomer";
            this._tbxFindCustomer.Size = new System.Drawing.Size(130, 22);
            this._tbxFindCustomer.TabIndex = 10;
            // 
            // _cbxSelect
            // 
            this._cbxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbxSelect.FormattingEnabled = true;
            this._cbxSelect.Items.AddRange(new object[] {
            "Surname",
            "PassportData"});
            this._cbxSelect.Location = new System.Drawing.Point(606, 341);
            this._cbxSelect.Name = "_cbxSelect";
            this._cbxSelect.Size = new System.Drawing.Size(147, 24);
            this._cbxSelect.TabIndex = 11;
            this._cbxSelect.SelectedIndexChanged += new System.EventHandler(this._cbxSelect_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this._btnFindCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 655);
            this.Controls.Add(this._cbxSelect);
            this.Controls.Add(this._tbxFindCustomer);
            this.Controls.Add(this._dgvCustomers);
            this.Controls.Add(this._btnFindCustomer);
            this.Controls.Add(this._lblCustomers);
            this.Controls.Add(this._lblDeposits);
            this.Controls.Add(this._lblLoans);
            this.Controls.Add(this._lblAccounts);
            this.Controls.Add(this._btnAddCustomer);
            this.Controls.Add(this._btnAddLoan);
            this.Controls.Add(this._btnAddDeposit);
            this.Controls.Add(this._btnAddAccount);
            this.Name = "MainForm";
            this.Text = "MainFrame";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAddAccount;
        private System.Windows.Forms.Button _btnAddDeposit;
        private System.Windows.Forms.Button _btnAddLoan;
        private System.Windows.Forms.Button _btnAddCustomer;
        private System.Windows.Forms.Label _lblAccounts;
        private System.Windows.Forms.Label _lblLoans;
        private System.Windows.Forms.Label _lblDeposits;
        private System.Windows.Forms.Label _lblCustomers;
        private System.Windows.Forms.Button _btnFindCustomer;
        private System.Windows.Forms.DataGridView _dgvCustomers;
        private System.Windows.Forms.TextBox _tbxFindCustomer;
        private System.Windows.Forms.ComboBox _cbxSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}

