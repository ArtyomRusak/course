namespace CourseProject.UIBank
{
    partial class AddDepositForm
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
      this._tbxPassportData = new System.Windows.Forms.TextBox();
      this._nudSummary = new System.Windows.Forms.NumericUpDown();
      this._lblPassportData = new System.Windows.Forms.Label();
      this._tbxSummary = new System.Windows.Forms.Label();
      this._lblOptionDeposit = new System.Windows.Forms.Label();
      this._cbxOptionDeposits = new System.Windows.Forms.ComboBox();
      this._cbxCurrencies = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this._btnCreateDeposit = new System.Windows.Forms.Button();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // _tbxPassportData
      // 
      this._tbxPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._tbxPassportData.Location = new System.Drawing.Point(56, 76);
      this._tbxPassportData.Name = "_tbxPassportData";
      this._tbxPassportData.Size = new System.Drawing.Size(130, 24);
      this._tbxPassportData.TabIndex = 1;
      this._tbxPassportData.Validating += new System.ComponentModel.CancelEventHandler(this._tbxPassportData_Validating);
      // 
      // _nudSummary
      // 
      this._nudSummary.DecimalPlaces = 2;
      this._nudSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._nudSummary.Location = new System.Drawing.Point(211, 76);
      this._nudSummary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
      this._nudSummary.Name = "_nudSummary";
      this._nudSummary.Size = new System.Drawing.Size(150, 24);
      this._nudSummary.TabIndex = 5;
      // 
      // _lblPassportData
      // 
      this._lblPassportData.AutoSize = true;
      this._lblPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._lblPassportData.Location = new System.Drawing.Point(68, 34);
      this._lblPassportData.Name = "_lblPassportData";
      this._lblPassportData.Size = new System.Drawing.Size(107, 20);
      this._lblPassportData.TabIndex = 6;
      this._lblPassportData.Text = "PassportData";
      // 
      // _tbxSummary
      // 
      this._tbxSummary.AutoSize = true;
      this._tbxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._tbxSummary.Location = new System.Drawing.Point(245, 34);
      this._tbxSummary.Name = "_tbxSummary";
      this._tbxSummary.Size = new System.Drawing.Size(76, 20);
      this._tbxSummary.TabIndex = 7;
      this._tbxSummary.Text = "Summary";
      // 
      // _lblOptionDeposit
      // 
      this._lblOptionDeposit.AutoSize = true;
      this._lblOptionDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._lblOptionDeposit.Location = new System.Drawing.Point(402, 34);
      this._lblOptionDeposit.Name = "_lblOptionDeposit";
      this._lblOptionDeposit.Size = new System.Drawing.Size(106, 20);
      this._lblOptionDeposit.TabIndex = 8;
      this._lblOptionDeposit.Text = "DepositName";
      // 
      // _cbxOptionDeposits
      // 
      this._cbxOptionDeposits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this._cbxOptionDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._cbxOptionDeposits.FormattingEnabled = true;
      this._cbxOptionDeposits.Location = new System.Drawing.Point(395, 76);
      this._cbxOptionDeposits.Name = "_cbxOptionDeposits";
      this._cbxOptionDeposits.Size = new System.Drawing.Size(124, 24);
      this._cbxOptionDeposits.TabIndex = 9;
      // 
      // _cbxCurrencies
      // 
      this._cbxCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this._cbxCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._cbxCurrencies.FormattingEnabled = true;
      this._cbxCurrencies.Location = new System.Drawing.Point(553, 76);
      this._cbxCurrencies.Name = "_cbxCurrencies";
      this._cbxCurrencies.Size = new System.Drawing.Size(124, 24);
      this._cbxCurrencies.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(560, 34);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 20);
      this.label1.TabIndex = 11;
      this.label1.Text = "Currency";
      // 
      // _btnCreateDeposit
      // 
      this._btnCreateDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._btnCreateDeposit.Location = new System.Drawing.Point(301, 132);
      this._btnCreateDeposit.Name = "_btnCreateDeposit";
      this._btnCreateDeposit.Size = new System.Drawing.Size(148, 47);
      this._btnCreateDeposit.TabIndex = 12;
      this._btnCreateDeposit.Text = "Create";
      this._btnCreateDeposit.UseVisualStyleBackColor = true;
      this._btnCreateDeposit.Click += new System.EventHandler(this._btnCreateDeposit_Click);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // AddDepositForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(724, 200);
      this.Controls.Add(this._btnCreateDeposit);
      this.Controls.Add(this.label1);
      this.Controls.Add(this._cbxCurrencies);
      this.Controls.Add(this._cbxOptionDeposits);
      this.Controls.Add(this._lblOptionDeposit);
      this.Controls.Add(this._tbxSummary);
      this.Controls.Add(this._lblPassportData);
      this.Controls.Add(this._nudSummary);
      this.Controls.Add(this._tbxPassportData);
      this.Name = "AddDepositForm";
      this.Text = "Adding deposit";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDepositForm_FormClosing);
      this.Load += new System.EventHandler(this.AddDepositForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _tbxPassportData;
        private System.Windows.Forms.NumericUpDown _nudSummary;
        private System.Windows.Forms.Label _lblPassportData;
        private System.Windows.Forms.Label _tbxSummary;
        private System.Windows.Forms.Label _lblOptionDeposit;
        private System.Windows.Forms.ComboBox _cbxOptionDeposits;
        private System.Windows.Forms.ComboBox _cbxCurrencies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnCreateDeposit;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}