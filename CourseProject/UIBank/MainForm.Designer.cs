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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._cbxSelect = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // 
            // _customerView
            // 
            this._customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._customerView.Location = new System.Drawing.Point(267, 384);
            this._customerView.Name = "_customerView";
            this._customerView.Size = new System.Drawing.Size(533, 238);
            this._customerView.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 332);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 37);
            this.textBox1.TabIndex = 10;
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
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CourseProject.Core.Entities.Customer);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 655);
            this.Controls.Add(this._cbxSelect);
            this.Controls.Add(this.textBox1);
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
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox _cbxSelect;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}

