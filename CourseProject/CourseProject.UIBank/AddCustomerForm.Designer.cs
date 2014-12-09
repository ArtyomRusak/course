namespace CourseProject.UIBank
{
    partial class AddCustomerForm
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
            this._lblName = new System.Windows.Forms.Label();
            this._lblSurname = new System.Windows.Forms.Label();
            this._lblPatronymic = new System.Windows.Forms.Label();
            this._tbxName = new System.Windows.Forms.TextBox();
            this._tbxSurname = new System.Windows.Forms.TextBox();
            this._tbxPatronymic = new System.Windows.Forms.TextBox();
            this._lblBirthDate = new System.Windows.Forms.Label();
            this._lblAddress = new System.Windows.Forms.Label();
            this._tbxAddress = new System.Windows.Forms.TextBox();
            this._dtmpBirthDate = new System.Windows.Forms.DateTimePicker();
            this._lblPassportData = new System.Windows.Forms.Label();
            this._tbxPassportData = new System.Windows.Forms.TextBox();
            this._btnAddCustomer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblName.Location = new System.Drawing.Point(49, 43);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(45, 16);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "Name";
            // 
            // _lblSurname
            // 
            this._lblSurname.AutoSize = true;
            this._lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblSurname.Location = new System.Drawing.Point(49, 92);
            this._lblSurname.Name = "_lblSurname";
            this._lblSurname.Size = new System.Drawing.Size(62, 16);
            this._lblSurname.TabIndex = 1;
            this._lblSurname.Text = "Surname";
            // 
            // _lblPatronymic
            // 
            this._lblPatronymic.AutoSize = true;
            this._lblPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblPatronymic.Location = new System.Drawing.Point(49, 141);
            this._lblPatronymic.Name = "_lblPatronymic";
            this._lblPatronymic.Size = new System.Drawing.Size(75, 16);
            this._lblPatronymic.TabIndex = 2;
            this._lblPatronymic.Text = "Patronymic";
            // 
            // _tbxName
            // 
            this._tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxName.Location = new System.Drawing.Point(163, 43);
            this._tbxName.Name = "_tbxName";
            this._tbxName.Size = new System.Drawing.Size(125, 22);
            this._tbxName.TabIndex = 3;
            this._tbxName.Validating += new System.ComponentModel.CancelEventHandler(this._tbxName_Validating);
            // 
            // _tbxSurname
            // 
            this._tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxSurname.Location = new System.Drawing.Point(163, 92);
            this._tbxSurname.Name = "_tbxSurname";
            this._tbxSurname.Size = new System.Drawing.Size(125, 22);
            this._tbxSurname.TabIndex = 4;
            this._tbxSurname.Validating += new System.ComponentModel.CancelEventHandler(this._tbxSurname_Validating);
            // 
            // _tbxPatronymic
            // 
            this._tbxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxPatronymic.Location = new System.Drawing.Point(163, 141);
            this._tbxPatronymic.Name = "_tbxPatronymic";
            this._tbxPatronymic.Size = new System.Drawing.Size(125, 22);
            this._tbxPatronymic.TabIndex = 5;
            this._tbxPatronymic.Validating += new System.ComponentModel.CancelEventHandler(this._tbxPatronymic_Validating);
            // 
            // _lblBirthDate
            // 
            this._lblBirthDate.AutoSize = true;
            this._lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblBirthDate.Location = new System.Drawing.Point(382, 43);
            this._lblBirthDate.Name = "_lblBirthDate";
            this._lblBirthDate.Size = new System.Drawing.Size(63, 16);
            this._lblBirthDate.TabIndex = 6;
            this._lblBirthDate.Text = "BirthDate";
            // 
            // _lblAddress
            // 
            this._lblAddress.AutoSize = true;
            this._lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblAddress.Location = new System.Drawing.Point(382, 116);
            this._lblAddress.Name = "_lblAddress";
            this._lblAddress.Size = new System.Drawing.Size(59, 16);
            this._lblAddress.TabIndex = 8;
            this._lblAddress.Text = "Address";
            // 
            // _tbxAddress
            // 
            this._tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxAddress.Location = new System.Drawing.Point(481, 94);
            this._tbxAddress.Multiline = true;
            this._tbxAddress.Name = "_tbxAddress";
            this._tbxAddress.Size = new System.Drawing.Size(196, 69);
            this._tbxAddress.TabIndex = 9;
            this._tbxAddress.Validating += new System.ComponentModel.CancelEventHandler(this._tbxAddress_Validating);
            // 
            // _dtmpBirthDate
            // 
            this._dtmpBirthDate.Location = new System.Drawing.Point(481, 42);
            this._dtmpBirthDate.Name = "_dtmpBirthDate";
            this._dtmpBirthDate.Size = new System.Drawing.Size(200, 20);
            this._dtmpBirthDate.TabIndex = 11;
            this._dtmpBirthDate.Validating += new System.ComponentModel.CancelEventHandler(this._dtmpBirthDate_Validating);
            // 
            // _lblPassportData
            // 
            this._lblPassportData.AutoSize = true;
            this._lblPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lblPassportData.Location = new System.Drawing.Point(49, 208);
            this._lblPassportData.Name = "_lblPassportData";
            this._lblPassportData.Size = new System.Drawing.Size(91, 16);
            this._lblPassportData.TabIndex = 12;
            this._lblPassportData.Text = "PassportData";
            // 
            // _tbxPassportData
            // 
            this._tbxPassportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._tbxPassportData.Location = new System.Drawing.Point(163, 202);
            this._tbxPassportData.Name = "_tbxPassportData";
            this._tbxPassportData.Size = new System.Drawing.Size(125, 22);
            this._tbxPassportData.TabIndex = 13;
            this._tbxPassportData.Validating += new System.ComponentModel.CancelEventHandler(this._tbxPassportData_Validating);
            // 
            // _btnAddCustomer
            // 
            this._btnAddCustomer.Location = new System.Drawing.Point(313, 241);
            this._btnAddCustomer.Name = "_btnAddCustomer";
            this._btnAddCustomer.Size = new System.Drawing.Size(159, 49);
            this._btnAddCustomer.TabIndex = 14;
            this._btnAddCustomer.Text = "Add customer";
            this._btnAddCustomer.UseVisualStyleBackColor = true;
            this._btnAddCustomer.Click += new System.EventHandler(this._btnAddCustomer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 302);
            this.Controls.Add(this._btnAddCustomer);
            this.Controls.Add(this._tbxPassportData);
            this.Controls.Add(this._lblPassportData);
            this.Controls.Add(this._dtmpBirthDate);
            this.Controls.Add(this._tbxAddress);
            this.Controls.Add(this._lblAddress);
            this.Controls.Add(this._lblBirthDate);
            this.Controls.Add(this._tbxPatronymic);
            this.Controls.Add(this._tbxSurname);
            this.Controls.Add(this._tbxName);
            this.Controls.Add(this._lblPatronymic);
            this.Controls.Add(this._lblSurname);
            this.Controls.Add(this._lblName);
            this.Name = "AddCustomerForm";
            this.Text = "Adding customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCustomerForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Label _lblSurname;
        private System.Windows.Forms.Label _lblPatronymic;
        private System.Windows.Forms.TextBox _tbxName;
        private System.Windows.Forms.TextBox _tbxSurname;
        private System.Windows.Forms.TextBox _tbxPatronymic;
        private System.Windows.Forms.Label _lblBirthDate;
        private System.Windows.Forms.Label _lblAddress;
        private System.Windows.Forms.TextBox _tbxAddress;
        private System.Windows.Forms.DateTimePicker _dtmpBirthDate;
        private System.Windows.Forms.Label _lblPassportData;
        private System.Windows.Forms.TextBox _tbxPassportData;
        private System.Windows.Forms.Button _btnAddCustomer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}