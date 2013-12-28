namespace UIBank
{
    partial class ViewLoanForm
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
            this._dtmpDate = new System.Windows.Forms.DateTimePicker();
            this._tbxPercent = new System.Windows.Forms.TextBox();
            this._btnCalculate = new System.Windows.Forms.Button();
            this._tbxSummary = new System.Windows.Forms.TextBox();
            this._lblSummary = new System.Windows.Forms.Label();
            this._lblLoanId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _dtmpDate
            // 
            this._dtmpDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._dtmpDate.Location = new System.Drawing.Point(290, 69);
            this._dtmpDate.Name = "_dtmpDate";
            this._dtmpDate.Size = new System.Drawing.Size(200, 20);
            this._dtmpDate.TabIndex = 26;
            // 
            // _tbxPercent
            // 
            this._tbxPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxPercent.Location = new System.Drawing.Point(302, 195);
            this._tbxPercent.Name = "_tbxPercent";
            this._tbxPercent.ReadOnly = true;
            this._tbxPercent.Size = new System.Drawing.Size(158, 29);
            this._tbxPercent.TabIndex = 25;
            // 
            // _btnCalculate
            // 
            this._btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btnCalculate.Location = new System.Drawing.Point(315, 118);
            this._btnCalculate.Name = "_btnCalculate";
            this._btnCalculate.Size = new System.Drawing.Size(131, 41);
            this._btnCalculate.TabIndex = 24;
            this._btnCalculate.Text = "Calculate";
            this._btnCalculate.UseVisualStyleBackColor = true;
            this._btnCalculate.Click += new System.EventHandler(this._btnCalculate_Click);
            // 
            // _tbxSummary
            // 
            this._tbxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxSummary.Location = new System.Drawing.Point(41, 104);
            this._tbxSummary.Name = "_tbxSummary";
            this._tbxSummary.ReadOnly = true;
            this._tbxSummary.Size = new System.Drawing.Size(158, 29);
            this._tbxSummary.TabIndex = 22;
            // 
            // _lblSummary
            // 
            this._lblSummary.AutoSize = true;
            this._lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblSummary.Location = new System.Drawing.Point(77, 69);
            this._lblSummary.Name = "_lblSummary";
            this._lblSummary.Size = new System.Drawing.Size(76, 20);
            this._lblSummary.TabIndex = 23;
            this._lblSummary.Text = "Summary";
            // 
            // _lblLoanId
            // 
            this._lblLoanId.AutoSize = true;
            this._lblLoanId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblLoanId.Location = new System.Drawing.Point(12, 18);
            this._lblLoanId.Name = "_lblLoanId";
            this._lblLoanId.Size = new System.Drawing.Size(27, 24);
            this._lblLoanId.TabIndex = 21;
            this._lblLoanId.Text = "ID";
            // 
            // ViewLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 250);
            this.Controls.Add(this._dtmpDate);
            this.Controls.Add(this._tbxPercent);
            this.Controls.Add(this._btnCalculate);
            this.Controls.Add(this._tbxSummary);
            this.Controls.Add(this._lblSummary);
            this.Controls.Add(this._lblLoanId);
            this.Name = "ViewLoanForm";
            this.Text = "ViewLoanForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewLoanForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewLoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker _dtmpDate;
        private System.Windows.Forms.TextBox _tbxPercent;
        private System.Windows.Forms.Button _btnCalculate;
        private System.Windows.Forms.TextBox _tbxSummary;
        private System.Windows.Forms.Label _lblSummary;
        private System.Windows.Forms.Label _lblLoanId;
    }
}