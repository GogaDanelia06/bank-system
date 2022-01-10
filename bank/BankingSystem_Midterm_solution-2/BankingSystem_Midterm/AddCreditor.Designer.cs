namespace BankingSystem_Midterm
{
    partial class AddCreditor
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
            this.but_Save = new System.Windows.Forms.Button();
            this.txtBox_PersonalID = new System.Windows.Forms.TextBox();
            this.txtBox_LastName = new System.Windows.Forms.TextBox();
            this.txtBox_FirstName = new System.Windows.Forms.TextBox();
            this.txtBox_ID = new System.Windows.Forms.TextBox();
            this.loanAmount = new System.Windows.Forms.Label();
            this.personalID = new System.Windows.Forms.Label();
            this.loanGiven = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.loanRate = new System.Windows.Forms.Label();
            this.loanLeft = new System.Windows.Forms.Label();
            this.txtBox_LoanAmount = new System.Windows.Forms.TextBox();
            this.txtBox_LoanRate = new System.Windows.Forms.TextBox();
            this.txtBox_LoanLeft = new System.Windows.Forms.TextBox();
            this.dateTimePicker1_LoanGiven = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // but_Save
            // 
            this.but_Save.Location = new System.Drawing.Point(121, 368);
            this.but_Save.Margin = new System.Windows.Forms.Padding(4);
            this.but_Save.Name = "but_Save";
            this.but_Save.Size = new System.Drawing.Size(377, 28);
            this.but_Save.TabIndex = 31;
            this.but_Save.Text = "Save";
            this.but_Save.UseVisualStyleBackColor = true;
            this.but_Save.Click += new System.EventHandler(this.but_Save_Click);
            // 
            // txtBox_PersonalID
            // 
            this.txtBox_PersonalID.Location = new System.Drawing.Point(121, 137);
            this.txtBox_PersonalID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_PersonalID.Name = "txtBox_PersonalID";
            this.txtBox_PersonalID.Size = new System.Drawing.Size(377, 22);
            this.txtBox_PersonalID.TabIndex = 26;
            // 
            // txtBox_LastName
            // 
            this.txtBox_LastName.Location = new System.Drawing.Point(121, 91);
            this.txtBox_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_LastName.Name = "txtBox_LastName";
            this.txtBox_LastName.Size = new System.Drawing.Size(377, 22);
            this.txtBox_LastName.TabIndex = 27;
            // 
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Location = new System.Drawing.Point(121, 53);
            this.txtBox_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(377, 22);
            this.txtBox_FirstName.TabIndex = 28;
            // 
            // txtBox_ID
            // 
            this.txtBox_ID.Location = new System.Drawing.Point(121, 14);
            this.txtBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_ID.Name = "txtBox_ID";
            this.txtBox_ID.ReadOnly = true;
            this.txtBox_ID.Size = new System.Drawing.Size(377, 22);
            this.txtBox_ID.TabIndex = 25;
            // 
            // loanAmount
            // 
            this.loanAmount.AutoSize = true;
            this.loanAmount.Location = new System.Drawing.Point(25, 219);
            this.loanAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanAmount.Name = "loanAmount";
            this.loanAmount.Size = new System.Drawing.Size(96, 17);
            this.loanAmount.TabIndex = 20;
            this.loanAmount.Text = "Loan Amount:";
            // 
            // personalID
            // 
            this.personalID.AutoSize = true;
            this.personalID.Location = new System.Drawing.Point(25, 140);
            this.personalID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.personalID.Name = "personalID";
            this.personalID.Size = new System.Drawing.Size(85, 17);
            this.personalID.TabIndex = 21;
            this.personalID.Text = "Personal ID:";
            // 
            // loanGiven
            // 
            this.loanGiven.AutoSize = true;
            this.loanGiven.Location = new System.Drawing.Point(25, 181);
            this.loanGiven.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanGiven.Name = "loanGiven";
            this.loanGiven.Size = new System.Drawing.Size(85, 17);
            this.loanGiven.TabIndex = 22;
            this.loanGiven.Text = "Loan Given:";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(25, 94);
            this.lastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(80, 17);
            this.lastName.TabIndex = 23;
            this.lastName.Text = "Last Name:";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(25, 56);
            this.firstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(80, 17);
            this.firstName.TabIndex = 24;
            this.firstName.Text = "First Name:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(25, 17);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(25, 17);
            this.id.TabIndex = 19;
            this.id.Text = "ID:";
            // 
            // loanRate
            // 
            this.loanRate.AutoSize = true;
            this.loanRate.Location = new System.Drawing.Point(25, 254);
            this.loanRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanRate.Name = "loanRate";
            this.loanRate.Size = new System.Drawing.Size(78, 17);
            this.loanRate.TabIndex = 32;
            this.loanRate.Text = "Loan Rate:";
            // 
            // loanLeft
            // 
            this.loanLeft.AutoSize = true;
            this.loanLeft.Location = new System.Drawing.Point(25, 288);
            this.loanLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loanLeft.Name = "loanLeft";
            this.loanLeft.Size = new System.Drawing.Size(72, 17);
            this.loanLeft.TabIndex = 33;
            this.loanLeft.Text = "Loan Left:";
            // 
            // txtBox_LoanAmount
            // 
            this.txtBox_LoanAmount.Location = new System.Drawing.Point(121, 219);
            this.txtBox_LoanAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_LoanAmount.Name = "txtBox_LoanAmount";
            this.txtBox_LoanAmount.Size = new System.Drawing.Size(377, 22);
            this.txtBox_LoanAmount.TabIndex = 35;
            // 
            // txtBox_LoanRate
            // 
            this.txtBox_LoanRate.Location = new System.Drawing.Point(121, 254);
            this.txtBox_LoanRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_LoanRate.Name = "txtBox_LoanRate";
            this.txtBox_LoanRate.Size = new System.Drawing.Size(377, 22);
            this.txtBox_LoanRate.TabIndex = 36;
            // 
            // txtBox_LoanLeft
            // 
            this.txtBox_LoanLeft.Location = new System.Drawing.Point(121, 288);
            this.txtBox_LoanLeft.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_LoanLeft.Name = "txtBox_LoanLeft";
            this.txtBox_LoanLeft.Size = new System.Drawing.Size(377, 22);
            this.txtBox_LoanLeft.TabIndex = 37;
            // 
            // dateTimePicker1_LoanGiven
            // 
            this.dateTimePicker1_LoanGiven.Location = new System.Drawing.Point(121, 181);
            this.dateTimePicker1_LoanGiven.Name = "dateTimePicker1_LoanGiven";
            this.dateTimePicker1_LoanGiven.Size = new System.Drawing.Size(377, 22);
            this.dateTimePicker1_LoanGiven.TabIndex = 70;
            // 
            // AddCreditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.dateTimePicker1_LoanGiven);
            this.Controls.Add(this.txtBox_LoanLeft);
            this.Controls.Add(this.txtBox_LoanRate);
            this.Controls.Add(this.txtBox_LoanAmount);
            this.Controls.Add(this.loanLeft);
            this.Controls.Add(this.loanRate);
            this.Controls.Add(this.but_Save);
            this.Controls.Add(this.txtBox_PersonalID);
            this.Controls.Add(this.txtBox_LastName);
            this.Controls.Add(this.txtBox_FirstName);
            this.Controls.Add(this.txtBox_ID);
            this.Controls.Add(this.loanAmount);
            this.Controls.Add(this.personalID);
            this.Controls.Add(this.loanGiven);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.id);
            this.Name = "AddCreditor";
            this.Text = "Add Creditor";
            this.Load += new System.EventHandler(this.AddCreditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_Save;
        private System.Windows.Forms.TextBox txtBox_PersonalID;
        private System.Windows.Forms.TextBox txtBox_LastName;
        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.TextBox txtBox_ID;
        private System.Windows.Forms.Label loanAmount;
        private System.Windows.Forms.Label personalID;
        private System.Windows.Forms.Label loanGiven;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label loanRate;
        private System.Windows.Forms.Label loanLeft;
        private System.Windows.Forms.TextBox txtBox_LoanAmount;
        private System.Windows.Forms.TextBox txtBox_LoanRate;
        private System.Windows.Forms.TextBox txtBox_LoanLeft;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_LoanGiven;
    }
}