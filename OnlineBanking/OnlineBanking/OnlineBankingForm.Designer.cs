namespace OnlineBanking
{
    partial class OnlineBankingForm
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
            this.cboxUserType = new System.Windows.Forms.ComboBox();
            this.btnShowPanelOpen = new System.Windows.Forms.Button();
            this.btnShowPanelDeposit = new System.Windows.Forms.Button();
            this.btnShowPanelWithdraw = new System.Windows.Forms.Button();
            this.btnShowPanelBalance = new System.Windows.Forms.Button();
            this.btnShowPanelTransactions = new System.Windows.Forms.Button();
            this.lblClientList = new System.Windows.Forms.Label();
            this.lboxClients = new System.Windows.Forms.ListBox();
            this.lblAccountList = new System.Windows.Forms.Label();
            this.lboxAccounts = new System.Windows.Forms.ListBox();
            this.pnlOpenAccount = new System.Windows.Forms.Panel();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.lblUserType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxUserType
            // 
            this.cboxUserType.FormattingEnabled = true;
            this.cboxUserType.Location = new System.Drawing.Point(413, 41);
            this.cboxUserType.Name = "cboxUserType";
            this.cboxUserType.Size = new System.Drawing.Size(128, 21);
            this.cboxUserType.TabIndex = 0;
            // 
            // btnShowPanelOpen
            // 
            this.btnShowPanelOpen.Location = new System.Drawing.Point(50, 88);
            this.btnShowPanelOpen.Name = "btnShowPanelOpen";
            this.btnShowPanelOpen.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelOpen.TabIndex = 1;
            this.btnShowPanelOpen.Text = "Open Account";
            this.btnShowPanelOpen.UseVisualStyleBackColor = true;
            // 
            // btnShowPanelDeposit
            // 
            this.btnShowPanelDeposit.Location = new System.Drawing.Point(50, 150);
            this.btnShowPanelDeposit.Name = "btnShowPanelDeposit";
            this.btnShowPanelDeposit.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelDeposit.TabIndex = 2;
            this.btnShowPanelDeposit.Text = "Deposit";
            this.btnShowPanelDeposit.UseVisualStyleBackColor = true;
            // 
            // btnShowPanelWithdraw
            // 
            this.btnShowPanelWithdraw.Location = new System.Drawing.Point(50, 212);
            this.btnShowPanelWithdraw.Name = "btnShowPanelWithdraw";
            this.btnShowPanelWithdraw.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelWithdraw.TabIndex = 3;
            this.btnShowPanelWithdraw.Text = "Withdraw";
            this.btnShowPanelWithdraw.UseVisualStyleBackColor = true;
            // 
            // btnShowPanelBalance
            // 
            this.btnShowPanelBalance.Location = new System.Drawing.Point(50, 274);
            this.btnShowPanelBalance.Name = "btnShowPanelBalance";
            this.btnShowPanelBalance.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelBalance.TabIndex = 4;
            this.btnShowPanelBalance.Text = "Balance";
            this.btnShowPanelBalance.UseVisualStyleBackColor = true;
            // 
            // btnShowPanelTransactions
            // 
            this.btnShowPanelTransactions.Location = new System.Drawing.Point(50, 336);
            this.btnShowPanelTransactions.Name = "btnShowPanelTransactions";
            this.btnShowPanelTransactions.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelTransactions.TabIndex = 5;
            this.btnShowPanelTransactions.Text = "Transactions";
            this.btnShowPanelTransactions.UseVisualStyleBackColor = true;
            // 
            // lblClientList
            // 
            this.lblClientList.AutoSize = true;
            this.lblClientList.Location = new System.Drawing.Point(849, 114);
            this.lblClientList.Name = "lblClientList";
            this.lblClientList.Size = new System.Drawing.Size(52, 13);
            this.lblClientList.TabIndex = 6;
            this.lblClientList.Text = "Client List";
            // 
            // lboxClients
            // 
            this.lboxClients.FormattingEnabled = true;
            this.lboxClients.Location = new System.Drawing.Point(852, 130);
            this.lboxClients.Name = "lboxClients";
            this.lboxClients.Size = new System.Drawing.Size(120, 95);
            this.lboxClients.TabIndex = 7;
            // 
            // lblAccountList
            // 
            this.lblAccountList.AutoSize = true;
            this.lblAccountList.Location = new System.Drawing.Point(849, 238);
            this.lblAccountList.Name = "lblAccountList";
            this.lblAccountList.Size = new System.Drawing.Size(66, 13);
            this.lblAccountList.TabIndex = 8;
            this.lblAccountList.Text = "Account List";
            // 
            // lboxAccounts
            // 
            this.lboxAccounts.FormattingEnabled = true;
            this.lboxAccounts.Location = new System.Drawing.Point(852, 254);
            this.lboxAccounts.Name = "lboxAccounts";
            this.lboxAccounts.Size = new System.Drawing.Size(120, 95);
            this.lboxAccounts.TabIndex = 9;
            // 
            // pnlOpenAccount
            // 
            this.pnlOpenAccount.Location = new System.Drawing.Point(233, 88);
            this.pnlOpenAccount.Name = "pnlOpenAccount";
            this.pnlOpenAccount.Size = new System.Drawing.Size(610, 304);
            this.pnlOpenAccount.TabIndex = 10;
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Location = new System.Drawing.Point(50, 398);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(610, 304);
            this.pnlDeposit.TabIndex = 11;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Location = new System.Drawing.Point(666, 398);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(610, 304);
            this.pnlWithdraw.TabIndex = 12;
            // 
            // pnlBalance
            // 
            this.pnlBalance.Location = new System.Drawing.Point(50, 708);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(610, 304);
            this.pnlBalance.TabIndex = 13;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Location = new System.Drawing.Point(666, 708);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(610, 304);
            this.pnlTransactions.TabIndex = 14;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(410, 25);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(89, 13);
            this.lblUserType.TabIndex = 15;
            this.lblUserType.Text = "Choose user type";
            // 
            // OnlineBankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 1040);
            this.Controls.Add(this.pnlWithdraw);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlBalance);
            this.Controls.Add(this.pnlDeposit);
            this.Controls.Add(this.pnlOpenAccount);
            this.Controls.Add(this.lboxAccounts);
            this.Controls.Add(this.lblAccountList);
            this.Controls.Add(this.lboxClients);
            this.Controls.Add(this.lblClientList);
            this.Controls.Add(this.btnShowPanelTransactions);
            this.Controls.Add(this.btnShowPanelBalance);
            this.Controls.Add(this.btnShowPanelWithdraw);
            this.Controls.Add(this.btnShowPanelDeposit);
            this.Controls.Add(this.btnShowPanelOpen);
            this.Controls.Add(this.cboxUserType);
            this.Name = "OnlineBankingForm";
            this.Text = "Online Banking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxUserType;
        private System.Windows.Forms.Button btnShowPanelOpen;
        private System.Windows.Forms.Button btnShowPanelDeposit;
        private System.Windows.Forms.Button btnShowPanelWithdraw;
        private System.Windows.Forms.Button btnShowPanelBalance;
        private System.Windows.Forms.Button btnShowPanelTransactions;
        private System.Windows.Forms.Label lblClientList;
        private System.Windows.Forms.ListBox lboxClients;
        private System.Windows.Forms.Label lblAccountList;
        private System.Windows.Forms.ListBox lboxAccounts;
        private System.Windows.Forms.Panel pnlOpenAccount;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label lblUserType;
    }
}

