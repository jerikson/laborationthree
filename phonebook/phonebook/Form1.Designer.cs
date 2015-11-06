namespace phonebook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNewContact = new System.Windows.Forms.TextBox();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnRemoveContact = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.chklsSecret = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewContact
            // 
            this.txtNewContact.Location = new System.Drawing.Point(22, 17);
            this.txtNewContact.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNewContact.Multiline = true;
            this.txtNewContact.Name = "txtNewContact";
            this.txtNewContact.Size = new System.Drawing.Size(470, 32);
            this.txtNewContact.TabIndex = 0;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.Location = new System.Drawing.Point(22, 345);
            this.btnSaveContact.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(156, 42);
            this.btnSaveContact.TabIndex = 1;
            this.btnSaveContact.Text = "Save";
            this.btnSaveContact.UseVisualStyleBackColor = true;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 29;
            this.lstContacts.Location = new System.Drawing.Point(22, 70);
            this.lstContacts.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(464, 265);
            this.lstContacts.TabIndex = 2;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // btnRemoveContact
            // 
            this.btnRemoveContact.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemoveContact.Location = new System.Drawing.Point(184, 345);
            this.btnRemoveContact.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnRemoveContact.Name = "btnRemoveContact";
            this.btnRemoveContact.Size = new System.Drawing.Size(156, 42);
            this.btnRemoveContact.TabIndex = 3;
            this.btnRemoveContact.Text = "Remove";
            this.btnRemoveContact.UseVisualStyleBackColor = true;
            this.btnRemoveContact.Click += new System.EventHandler(this.btnRemoveContact_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Location = new System.Drawing.Point(529, 17);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(316, 43);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(529, 70);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(315, 42);
            this.txtLastName.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(529, 123);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(315, 42);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // chklsSecret
            // 
            this.chklsSecret.AutoSize = true;
            this.chklsSecret.Location = new System.Drawing.Point(350, 351);
            this.chklsSecret.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.chklsSecret.Name = "chklsSecret";
            this.chklsSecret.Size = new System.Drawing.Size(105, 33);
            this.chklsSecret.TabIndex = 7;
            this.chklsSecret.Text = "secret";
            this.chklsSecret.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Red;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.Location = new System.Drawing.Point(464, 355);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 22);
            this.lblError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSaveContact;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRemoveContact;
            this.ClientSize = new System.Drawing.Size(858, 404);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.chklsSecret);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnRemoveContact);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.txtNewContact);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 460);
            this.MinimumSize = new System.Drawing.Size(880, 460);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewContact;
        private System.Windows.Forms.Button btnSaveContact;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnRemoveContact;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.CheckBox chklsSecret;
        private System.Windows.Forms.Label lblError;
    }
}

