namespace CourseProject.UIBank
{
    partial class AddAccountForm
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
      this._lblPassportData = new System.Windows.Forms.Label();
      this._tbxPassportData = new System.Windows.Forms.TextBox();
      this._lblSummary = new System.Windows.Forms.Label();
      this._nudSummary = new System.Windows.Forms.NumericUpDown();
      this._btnCreate = new System.Windows.Forms.Button();
      this._cbxCurrencies = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // _lblPassportData
      // 
      this._lblPassportData.AutoSize = true;
      this._lblPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._lblPassportData.Location = new System.Drawing.Point(51, 29);
      this._lblPassportData.Name = "_lblPassportData";
      this._lblPassportData.Size = new System.Drawing.Size(107, 20);
      this._lblPassportData.TabIndex = 0;
      this._lblPassportData.Text = "PassportData";
      // 
      // _tbxPassportData
      // 
      this._tbxPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._tbxPassportData.Location = new System.Drawing.Point(55, 68);
      this._tbxPassportData.Name = "_tbxPassportData";
      this._tbxPassportData.Size = new System.Drawing.Size(123, 24);
      this._tbxPassportData.TabIndex = 1;
      this._tbxPassportData.Validating += new System.ComponentModel.CancelEventHandler(this._tbxPassportData_Validating);
      // 
      // _lblSummary
      // 
      this._lblSummary.AutoSize = true;
      this._lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._lblSummary.Location = new System.Drawing.Point(236, 29);
      this._lblSummary.Name = "_lblSummary";
      this._lblSummary.Size = new System.Drawing.Size(76, 20);
      this._lblSummary.TabIndex = 2;
      this._lblSummary.Text = "Summary";
      // 
      // _nudSummary
      // 
      this._nudSummary.DecimalPlaces = 2;
      this._nudSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._nudSummary.Location = new System.Drawing.Point(204, 67);
      this._nudSummary.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
      this._nudSummary.Name = "_nudSummary";
      this._nudSummary.Size = new System.Drawing.Size(150, 24);
      this._nudSummary.TabIndex = 4;
      // 
      // _btnCreate
      // 
      this._btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._btnCreate.Location = new System.Drawing.Point(195, 145);
      this._btnCreate.Name = "_btnCreate";
      this._btnCreate.Size = new System.Drawing.Size(123, 40);
      this._btnCreate.TabIndex = 5;
      this._btnCreate.Text = "Create";
      this._btnCreate.UseVisualStyleBackColor = true;
      this._btnCreate.Click += new System.EventHandler(this._btnCreate_Click);
      // 
      // _cbxCurrencies
      // 
      this._cbxCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this._cbxCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this._cbxCurrencies.FormattingEnabled = true;
      this._cbxCurrencies.Location = new System.Drawing.Point(401, 67);
      this._cbxCurrencies.Name = "_cbxCurrencies";
      this._cbxCurrencies.Size = new System.Drawing.Size(90, 24);
      this._cbxCurrencies.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(415, 29);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 20);
      this.label1.TabIndex = 7;
      this.label1.Text = "Currency";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // AddAccountForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(535, 212);
      this.Controls.Add(this.label1);
      this.Controls.Add(this._cbxCurrencies);
      this.Controls.Add(this._btnCreate);
      this.Controls.Add(this._nudSummary);
      this.Controls.Add(this._lblSummary);
      this.Controls.Add(this._tbxPassportData);
      this.Controls.Add(this._lblPassportData);
      this.Name = "AddAccountForm";
      this.Text = "Adding account";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddAccountForm_FormClosing);
      this.Load += new System.EventHandler(this.AddAccountForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this._nudSummary)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblPassportData;
        private System.Windows.Forms.TextBox _tbxPassportData;
        private System.Windows.Forms.Label _lblSummary;
        private System.Windows.Forms.NumericUpDown _nudSummary;
        private System.Windows.Forms.Button _btnCreate;
        private System.Windows.Forms.ComboBox _cbxCurrencies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}