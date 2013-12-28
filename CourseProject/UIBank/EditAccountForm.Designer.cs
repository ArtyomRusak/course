namespace UIBank
{
    partial class EditAccountForm
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
            this._lblAccountId = new System.Windows.Forms.Label();
            this._dgvAccounts = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._tbxSummary = new System.Windows.Forms.TextBox();
            this._lblSummary = new System.Windows.Forms.Label();
            this._nudSummary = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this._btnTransact = new System.Windows.Forms.Button();
            this._nudSummaryTransact = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this._cbxSelect = new System.Windows.Forms.ComboBox();
            this._tbxFindAccount = new System.Windows.Forms.TextBox();
            this._btnFindAccounts = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnLower = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnAnnul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._dgvAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSummaryTransact)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblAccountId
            // 
            this._lblAccountId.AutoSize = true;
            this._lblAccountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblAccountId.Location = new System.Drawing.Point(187, 9);
            this._lblAccountId.Name = "_lblAccountId";
            this._lblAccountId.Size = new System.Drawing.Size(27, 24);
            this._lblAccountId.TabIndex = 5;
            this._lblAccountId.Text = "ID";
            // 
            // _dgvAccounts
            // 
            this._dgvAccounts.AllowUserToAddRows = false;
            this._dgvAccounts.AllowUserToDeleteRows = false;
            this._dgvAccounts.AutoGenerateColumns = false;
            this._dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dgvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.summaryDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn});
            this._dgvAccounts.DataSource = this.accountBindingSource;
            this._dgvAccounts.Location = new System.Drawing.Point(73, 62);
            this._dgvAccounts.Name = "_dgvAccounts";
            this._dgvAccounts.ReadOnly = true;
            this._dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dgvAccounts.Size = new System.Drawing.Size(348, 204);
            this._dgvAccounts.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // summaryDataGridViewTextBoxColumn
            // 
            this.summaryDataGridViewTextBoxColumn.DataPropertyName = "Summary";
            this.summaryDataGridViewTextBoxColumn.HeaderText = "Summary";
            this.summaryDataGridViewTextBoxColumn.Name = "summaryDataGridViewTextBoxColumn";
            this.summaryDataGridViewTextBoxColumn.ReadOnly = true;
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
            // _tbxSummary
            // 
            this._tbxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxSummary.Location = new System.Drawing.Point(70, 48);
            this._tbxSummary.Name = "_tbxSummary";
            this._tbxSummary.ReadOnly = true;
            this._tbxSummary.Size = new System.Drawing.Size(158, 29);
            this._tbxSummary.TabIndex = 7;
            // 
            // _lblSummary
            // 
            this._lblSummary.AutoSize = true;
            this._lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblSummary.Location = new System.Drawing.Point(112, 10);
            this._lblSummary.Name = "_lblSummary";
            this._lblSummary.Size = new System.Drawing.Size(76, 20);
            this._lblSummary.TabIndex = 8;
            this._lblSummary.Text = "Summary";
            // 
            // _nudSummary
            // 
            this._nudSummary.DecimalPlaces = 2;
            this._nudSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._nudSummary.Location = new System.Drawing.Point(70, 108);
            this._nudSummary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this._nudSummary.Name = "_nudSummary";
            this._nudSummary.Size = new System.Drawing.Size(158, 24);
            this._nudSummary.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this._btnTransact);
            this.panel1.Controls.Add(this._nudSummaryTransact);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this._cbxSelect);
            this.panel1.Controls.Add(this._tbxFindAccount);
            this.panel1.Controls.Add(this._btnFindAccounts);
            this.panel1.Controls.Add(this._dgvAccounts);
            this.panel1.Location = new System.Drawing.Point(375, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 386);
            this.panel1.TabIndex = 16;
            // 
            // _btnTransact
            // 
            this._btnTransact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnTransact.Location = new System.Drawing.Point(290, 293);
            this._btnTransact.Name = "_btnTransact";
            this._btnTransact.Size = new System.Drawing.Size(131, 41);
            this._btnTransact.TabIndex = 20;
            this._btnTransact.Text = "Transact";
            this._btnTransact.UseVisualStyleBackColor = true;
            this._btnTransact.Click += new System.EventHandler(this._btnTransact_Click);
            // 
            // _nudSummaryTransact
            // 
            this._nudSummaryTransact.DecimalPlaces = 2;
            this._nudSummaryTransact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._nudSummaryTransact.Location = new System.Drawing.Point(39, 302);
            this._nudSummaryTransact.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this._nudSummaryTransact.Name = "_nudSummaryTransact";
            this._nudSummaryTransact.Size = new System.Drawing.Size(158, 24);
            this._nudSummaryTransact.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cash to transact";
            // 
            // _cbxSelect
            // 
            this._cbxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbxSelect.FormattingEnabled = true;
            this._cbxSelect.Items.AddRange(new object[] {
            "PassportData",
            "AccountId",
            "Surname"});
            this._cbxSelect.Location = new System.Drawing.Point(316, 15);
            this._cbxSelect.Name = "_cbxSelect";
            this._cbxSelect.Size = new System.Drawing.Size(147, 24);
            this._cbxSelect.TabIndex = 14;
            // 
            // _tbxFindAccount
            // 
            this._tbxFindAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxFindAccount.Location = new System.Drawing.Point(162, 15);
            this._tbxFindAccount.Name = "_tbxFindAccount";
            this._tbxFindAccount.Size = new System.Drawing.Size(130, 24);
            this._tbxFindAccount.TabIndex = 13;
            // 
            // _btnFindAccounts
            // 
            this._btnFindAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnFindAccounts.Location = new System.Drawing.Point(4, 6);
            this._btnFindAccounts.Name = "_btnFindAccounts";
            this._btnFindAccounts.Size = new System.Drawing.Size(135, 37);
            this._btnFindAccounts.TabIndex = 12;
            this._btnFindAccounts.Text = "Найти";
            this._btnFindAccounts.UseVisualStyleBackColor = true;
            this._btnFindAccounts.Click += new System.EventHandler(this._btnFindAccounts_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAdd.Location = new System.Drawing.Point(80, 161);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(131, 41);
            this._btnAdd.TabIndex = 17;
            this._btnAdd.Text = "Add cash";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnLower
            // 
            this._btnLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnLower.Location = new System.Drawing.Point(80, 224);
            this._btnLower.Name = "_btnLower";
            this._btnLower.Size = new System.Drawing.Size(131, 42);
            this._btnLower.TabIndex = 18;
            this._btnLower.Text = "Low cash";
            this._btnLower.UseVisualStyleBackColor = true;
            this._btnLower.Click += new System.EventHandler(this._btnLower_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this._btnAnnul);
            this.panel2.Controls.Add(this._btnAdd);
            this.panel2.Controls.Add(this._btnLower);
            this.panel2.Controls.Add(this._tbxSummary);
            this.panel2.Controls.Add(this._lblSummary);
            this.panel2.Controls.Add(this._nudSummary);
            this.panel2.Location = new System.Drawing.Point(26, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 386);
            this.panel2.TabIndex = 19;
            // 
            // _btnAnnul
            // 
            this._btnAnnul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnAnnul.Location = new System.Drawing.Point(80, 292);
            this._btnAnnul.Name = "_btnAnnul";
            this._btnAnnul.Size = new System.Drawing.Size(131, 42);
            this._btnAnnul.TabIndex = 19;
            this._btnAnnul.Text = "Annul account";
            this._btnAnnul.UseVisualStyleBackColor = true;
            this._btnAnnul.Click += new System.EventHandler(this._btnAnnul_Click);
            // 
            // EditAccountForm
            // 
            this.AcceptButton = this._btnFindAccounts;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._lblAccountId);
            this.Name = "EditAccountForm";
            this.Text = "EditAccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditAccountForm_FormClosing);
            this.Load += new System.EventHandler(this.EditAccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dgvAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSummaryTransact)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblAccountId;
        private System.Windows.Forms.DataGridView _dgvAccounts;
        private System.Windows.Forms.TextBox _tbxSummary;
        private System.Windows.Forms.Label _lblSummary;
        private System.Windows.Forms.NumericUpDown _nudSummary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnLower;
        private System.Windows.Forms.ComboBox _cbxSelect;
        private System.Windows.Forms.TextBox _tbxFindAccount;
        private System.Windows.Forms.Button _btnFindAccounts;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.Button _btnTransact;
        private System.Windows.Forms.NumericUpDown _nudSummaryTransact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _btnAnnul;
    }
}