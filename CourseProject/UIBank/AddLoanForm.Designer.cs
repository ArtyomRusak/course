namespace UIBank
{
    partial class AddLoanForm
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
            this._btnCreateDeposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._cbxCurrencies = new System.Windows.Forms.ComboBox();
            this._cbxOptionLoans = new System.Windows.Forms.ComboBox();
            this._lblOptionLoan = new System.Windows.Forms.Label();
            this._tbxSummary = new System.Windows.Forms.Label();
            this._lblPassportData = new System.Windows.Forms.Label();
            this._nudSummary = new System.Windows.Forms.NumericUpDown();
            this._tbxPassportData = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnCreateDeposit
            // 
            this._btnCreateDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnCreateDeposit.Location = new System.Drawing.Point(286, 119);
            this._btnCreateDeposit.Name = "_btnCreateDeposit";
            this._btnCreateDeposit.Size = new System.Drawing.Size(148, 47);
            this._btnCreateDeposit.TabIndex = 21;
            this._btnCreateDeposit.Text = "Create";
            this._btnCreateDeposit.UseVisualStyleBackColor = true;
            this._btnCreateDeposit.Click += new System.EventHandler(this._btnCreateDeposit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(562, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Currency";
            // 
            // _cbxCurrencies
            // 
            this._cbxCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbxCurrencies.FormattingEnabled = true;
            this._cbxCurrencies.Location = new System.Drawing.Point(538, 63);
            this._cbxCurrencies.Name = "_cbxCurrencies";
            this._cbxCurrencies.Size = new System.Drawing.Size(124, 24);
            this._cbxCurrencies.TabIndex = 19;
            // 
            // _cbxOptionLoans
            // 
            this._cbxOptionLoans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxOptionLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cbxOptionLoans.FormattingEnabled = true;
            this._cbxOptionLoans.Location = new System.Drawing.Point(380, 63);
            this._cbxOptionLoans.Name = "_cbxOptionLoans";
            this._cbxOptionLoans.Size = new System.Drawing.Size(124, 24);
            this._cbxOptionLoans.TabIndex = 18;
            // 
            // _lblOptionLoan
            // 
            this._lblOptionLoan.AutoSize = true;
            this._lblOptionLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblOptionLoan.Location = new System.Drawing.Point(397, 21);
            this._lblOptionLoan.Name = "_lblOptionLoan";
            this._lblOptionLoan.Size = new System.Drawing.Size(87, 20);
            this._lblOptionLoan.TabIndex = 17;
            this._lblOptionLoan.Text = "LoanName";
            // 
            // _tbxSummary
            // 
            this._tbxSummary.AutoSize = true;
            this._tbxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxSummary.Location = new System.Drawing.Point(230, 21);
            this._tbxSummary.Name = "_tbxSummary";
            this._tbxSummary.Size = new System.Drawing.Size(76, 20);
            this._tbxSummary.TabIndex = 16;
            this._tbxSummary.Text = "Summary";
            // 
            // _lblPassportData
            // 
            this._lblPassportData.AutoSize = true;
            this._lblPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblPassportData.Location = new System.Drawing.Point(53, 21);
            this._lblPassportData.Name = "_lblPassportData";
            this._lblPassportData.Size = new System.Drawing.Size(107, 20);
            this._lblPassportData.TabIndex = 15;
            this._lblPassportData.Text = "PassportData";
            // 
            // _nudSummary
            // 
            this._nudSummary.DecimalPlaces = 2;
            this._nudSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._nudSummary.Location = new System.Drawing.Point(196, 63);
            this._nudSummary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this._nudSummary.Name = "_nudSummary";
            this._nudSummary.Size = new System.Drawing.Size(150, 24);
            this._nudSummary.TabIndex = 14;
            // 
            // _tbxPassportData
            // 
            this._tbxPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxPassportData.Location = new System.Drawing.Point(41, 63);
            this._tbxPassportData.Name = "_tbxPassportData";
            this._tbxPassportData.Size = new System.Drawing.Size(130, 24);
            this._tbxPassportData.TabIndex = 13;
            // 
            // AddLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 187);
            this.Controls.Add(this._btnCreateDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cbxCurrencies);
            this.Controls.Add(this._cbxOptionLoans);
            this.Controls.Add(this._lblOptionLoan);
            this.Controls.Add(this._tbxSummary);
            this.Controls.Add(this._lblPassportData);
            this.Controls.Add(this._nudSummary);
            this.Controls.Add(this._tbxPassportData);
            this.Name = "AddLoanForm";
            this.Text = "AddLoanForm";
            this.Load += new System.EventHandler(this.AddLoanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnCreateDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cbxCurrencies;
        private System.Windows.Forms.ComboBox _cbxOptionLoans;
        private System.Windows.Forms.Label _lblOptionLoan;
        private System.Windows.Forms.Label _tbxSummary;
        private System.Windows.Forms.Label _lblPassportData;
        private System.Windows.Forms.NumericUpDown _nudSummary;
        private System.Windows.Forms.TextBox _tbxPassportData;
    }
}