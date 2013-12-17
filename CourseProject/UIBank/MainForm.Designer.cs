namespace UIBank
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
            _unitOfWork.Dispose();
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
            this.@__findCustomer = new System.Windows.Forms.Button();
            this._customerView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this._customerView)).BeginInit();
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
            this._btnAddAccount.Text = "Добавить счёт";
            this._btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // _btnAddDeposit
            // 
            this._btnAddDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddDeposit.Location = new System.Drawing.Point(772, 134);
            this._btnAddDeposit.Name = "_btnAddDeposit";
            this._btnAddDeposit.Size = new System.Drawing.Size(161, 54);
            this._btnAddDeposit.TabIndex = 1;
            this._btnAddDeposit.Text = "Добавить вклад";
            this._btnAddDeposit.UseVisualStyleBackColor = true;
            // 
            // _btnAddLoan
            // 
            this._btnAddLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddLoan.Location = new System.Drawing.Point(772, 220);
            this._btnAddLoan.Name = "_btnAddLoan";
            this._btnAddLoan.Size = new System.Drawing.Size(161, 54);
            this._btnAddLoan.TabIndex = 2;
            this._btnAddLoan.Text = "Сделать займ";
            this._btnAddLoan.UseVisualStyleBackColor = true;
            // 
            // _btnAddCustomer
            // 
            this._btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAddCustomer.Location = new System.Drawing.Point(421, 73);
            this._btnAddCustomer.Name = "_btnAddCustomer";
            this._btnAddCustomer.Size = new System.Drawing.Size(161, 54);
            this._btnAddCustomer.TabIndex = 3;
            this._btnAddCustomer.Text = "Добавить пользователя";
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
            // __findCustomer
            // 
            this.@__findCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.@__findCustomer.Location = new System.Drawing.Point(293, 332);
            this.@__findCustomer.Name = "__findCustomer";
            this.@__findCustomer.Size = new System.Drawing.Size(135, 37);
            this.@__findCustomer.TabIndex = 8;
            this.@__findCustomer.Text = "Найти";
            this.@__findCustomer.UseVisualStyleBackColor = true;
            this.@__findCustomer.Click += new System.EventHandler(this.@__findCustomer_Click);
            // 
            // _customerView
            // 
            this._customerView.AllowUserToAddRows = false;
            this._customerView.AllowUserToDeleteRows = false;
            this._customerView.AutoGenerateColumns = false;
            this._customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._customerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.patronymicDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.passportDataDataGridViewTextBoxColumn});
            this._customerView.DataSource = this.customerBindingSource;
            this._customerView.Location = new System.Drawing.Point(145, 386);
            this._customerView.MultiSelect = false;
            this._customerView.Name = "_customerView";
            this._customerView.ReadOnly = true;
            this._customerView.Size = new System.Drawing.Size(732, 238);
            this._customerView.TabIndex = 9;
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
            "Номер паспорта",
            "Фамилия"});
            this._cbxSelect.Location = new System.Drawing.Point(606, 341);
            this._cbxSelect.Name = "_cbxSelect";
            this._cbxSelect.Size = new System.Drawing.Size(147, 24);
            this._cbxSelect.TabIndex = 11;
            this._cbxSelect.SelectedIndexChanged += new System.EventHandler(this._cbxSelect_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.@__findCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 655);
            this.Controls.Add(this._cbxSelect);
            this.Controls.Add(this._tbxFindCustomer);
            this.Controls.Add(this._customerView);
            this.Controls.Add(this.@__findCustomer);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._customerView)).EndInit();
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
        private System.Windows.Forms.Button __findCustomer;
        private System.Windows.Forms.DataGridView _customerView;
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

