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
            this.pnlOpen = new System.Windows.Forms.Panel();
            this.lblOpenBalance = new System.Windows.Forms.Label();
            this.tboxOpenBalance = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.tboxDepositAmount = new System.Windows.Forms.TextBox();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblWithdrawAmount = new System.Windows.Forms.Label();
            this.tboxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.pnlBalance = new System.Windows.Forms.Panel();
            this.lblBalanceNum = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.lboxTransactions = new System.Windows.Forms.ListBox();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.pnlOpen.SuspendLayout();
            this.pnlDeposit.SuspendLayout();
            this.pnlWithdraw.SuspendLayout();
            this.pnlBalance.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxUserType
            // 
            this.cboxUserType.FormattingEnabled = true;
            this.cboxUserType.Location = new System.Drawing.Point(413, 41);
            this.cboxUserType.Name = "cboxUserType";
            this.cboxUserType.Size = new System.Drawing.Size(128, 21);
            this.cboxUserType.TabIndex = 0;
            this.cboxUserType.SelectedIndexChanged += new System.EventHandler(this.cboxUserType_SelectedIndexChanged);
            // 
            // btnShowPanelOpen
            // 
            this.btnShowPanelOpen.Location = new System.Drawing.Point(50, 88);
            this.btnShowPanelOpen.Name = "btnShowPanelOpen";
            this.btnShowPanelOpen.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelOpen.TabIndex = 1;
            this.btnShowPanelOpen.Text = "Open Account";
            this.btnShowPanelOpen.UseVisualStyleBackColor = true;
            this.btnShowPanelOpen.Click += new System.EventHandler(this.btnShowPanelOpen_Click);
            // 
            // btnShowPanelDeposit
            // 
            this.btnShowPanelDeposit.Location = new System.Drawing.Point(50, 150);
            this.btnShowPanelDeposit.Name = "btnShowPanelDeposit";
            this.btnShowPanelDeposit.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelDeposit.TabIndex = 2;
            this.btnShowPanelDeposit.Text = "Deposit";
            this.btnShowPanelDeposit.UseVisualStyleBackColor = true;
            this.btnShowPanelDeposit.Click += new System.EventHandler(this.btnShowPanelDeposit_Click);
            // 
            // btnShowPanelWithdraw
            // 
            this.btnShowPanelWithdraw.Location = new System.Drawing.Point(50, 212);
            this.btnShowPanelWithdraw.Name = "btnShowPanelWithdraw";
            this.btnShowPanelWithdraw.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelWithdraw.TabIndex = 3;
            this.btnShowPanelWithdraw.Text = "Withdraw";
            this.btnShowPanelWithdraw.UseVisualStyleBackColor = true;
            this.btnShowPanelWithdraw.Click += new System.EventHandler(this.btnShowPanelWithdraw_Click);
            // 
            // btnShowPanelBalance
            // 
            this.btnShowPanelBalance.Location = new System.Drawing.Point(50, 274);
            this.btnShowPanelBalance.Name = "btnShowPanelBalance";
            this.btnShowPanelBalance.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelBalance.TabIndex = 4;
            this.btnShowPanelBalance.Text = "Balance";
            this.btnShowPanelBalance.UseVisualStyleBackColor = true;
            this.btnShowPanelBalance.Click += new System.EventHandler(this.btnShowPanelBalance_Click);
            // 
            // btnShowPanelTransactions
            // 
            this.btnShowPanelTransactions.Location = new System.Drawing.Point(50, 336);
            this.btnShowPanelTransactions.Name = "btnShowPanelTransactions";
            this.btnShowPanelTransactions.Size = new System.Drawing.Size(177, 56);
            this.btnShowPanelTransactions.TabIndex = 5;
            this.btnShowPanelTransactions.Text = "Transactions";
            this.btnShowPanelTransactions.UseVisualStyleBackColor = true;
            this.btnShowPanelTransactions.Click += new System.EventHandler(this.btnShowPanelTransactions_Click);
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
            this.lboxClients.SelectedIndexChanged += new System.EventHandler(this.lboxClients_SelectedIndexChanged);
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
            this.lboxAccounts.SelectedIndexChanged += new System.EventHandler(this.lboxAccounts_SelectedIndexChanged);
            // 
            // pnlOpen
            // 
            this.pnlOpen.Controls.Add(this.lblOpenBalance);
            this.pnlOpen.Controls.Add(this.tboxOpenBalance);
            this.pnlOpen.Controls.Add(this.btnOpen);
            this.pnlOpen.Location = new System.Drawing.Point(233, 88);
            this.pnlOpen.Name = "pnlOpen";
            this.pnlOpen.Size = new System.Drawing.Size(610, 304);
            this.pnlOpen.TabIndex = 10;
            // 
            // lblOpenBalance
            // 
            this.lblOpenBalance.AutoSize = true;
            this.lblOpenBalance.Location = new System.Drawing.Point(211, 107);
            this.lblOpenBalance.Name = "lblOpenBalance";
            this.lblOpenBalance.Size = new System.Drawing.Size(46, 13);
            this.lblOpenBalance.TabIndex = 2;
            this.lblOpenBalance.Text = "Balance";
            // 
            // tboxOpenBalance
            // 
            this.tboxOpenBalance.Location = new System.Drawing.Point(281, 104);
            this.tboxOpenBalance.Name = "tboxOpenBalance";
            this.tboxOpenBalance.Size = new System.Drawing.Size(100, 20);
            this.tboxOpenBalance.TabIndex = 1;
            this.tboxOpenBalance.Text = "1000";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(214, 166);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(167, 44);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Account";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Controls.Add(this.lblDeposit);
            this.pnlDeposit.Controls.Add(this.btnDeposit);
            this.pnlDeposit.Controls.Add(this.lblDepositAmount);
            this.pnlDeposit.Controls.Add(this.tboxDepositAmount);
            this.pnlDeposit.Location = new System.Drawing.Point(50, 398);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(610, 304);
            this.pnlDeposit.TabIndex = 11;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(245, 49);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(86, 26);
            this.lblDeposit.TabIndex = 3;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(212, 150);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(160, 48);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(209, 115);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(43, 13);
            this.lblDepositAmount.TabIndex = 1;
            this.lblDepositAmount.Text = "Amount";
            // 
            // tboxDepositAmount
            // 
            this.tboxDepositAmount.Location = new System.Drawing.Point(272, 112);
            this.tboxDepositAmount.Name = "tboxDepositAmount";
            this.tboxDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.tboxDepositAmount.TabIndex = 0;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Controls.Add(this.lblWithdraw);
            this.pnlWithdraw.Controls.Add(this.btnWithdraw);
            this.pnlWithdraw.Controls.Add(this.lblWithdrawAmount);
            this.pnlWithdraw.Controls.Add(this.tboxWithdrawAmount);
            this.pnlWithdraw.Location = new System.Drawing.Point(666, 398);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(610, 304);
            this.pnlWithdraw.TabIndex = 12;
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.Location = new System.Drawing.Point(245, 49);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(103, 26);
            this.lblWithdraw.TabIndex = 4;
            this.lblWithdraw.Text = "Withdraw";
            this.lblWithdraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(220, 150);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(160, 48);
            this.btnWithdraw.TabIndex = 5;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblWithdrawAmount
            // 
            this.lblWithdrawAmount.AutoSize = true;
            this.lblWithdrawAmount.Location = new System.Drawing.Point(217, 115);
            this.lblWithdrawAmount.Name = "lblWithdrawAmount";
            this.lblWithdrawAmount.Size = new System.Drawing.Size(43, 13);
            this.lblWithdrawAmount.TabIndex = 4;
            this.lblWithdrawAmount.Text = "Amount";
            // 
            // tboxWithdrawAmount
            // 
            this.tboxWithdrawAmount.Location = new System.Drawing.Point(280, 112);
            this.tboxWithdrawAmount.Name = "tboxWithdrawAmount";
            this.tboxWithdrawAmount.Size = new System.Drawing.Size(100, 20);
            this.tboxWithdrawAmount.TabIndex = 3;
            // 
            // pnlBalance
            // 
            this.pnlBalance.Controls.Add(this.lblBalanceNum);
            this.pnlBalance.Controls.Add(this.lblBalance);
            this.pnlBalance.Location = new System.Drawing.Point(50, 708);
            this.pnlBalance.Name = "pnlBalance";
            this.pnlBalance.Size = new System.Drawing.Size(610, 304);
            this.pnlBalance.TabIndex = 13;
            // 
            // lblBalanceNum
            // 
            this.lblBalanceNum.AutoSize = true;
            this.lblBalanceNum.Location = new System.Drawing.Point(259, 86);
            this.lblBalanceNum.Name = "lblBalanceNum";
            this.lblBalanceNum.Size = new System.Drawing.Size(54, 13);
            this.lblBalanceNum.TabIndex = 8;
            this.lblBalanceNum.Text = "balance $";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(245, 34);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(91, 26);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Balance";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.lboxTransactions);
            this.pnlTransactions.Controls.Add(this.lblTransactions);
            this.pnlTransactions.Location = new System.Drawing.Point(666, 708);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(610, 304);
            this.pnlTransactions.TabIndex = 14;
            // 
            // lboxTransactions
            // 
            this.lboxTransactions.FormattingEnabled = true;
            this.lboxTransactions.Location = new System.Drawing.Point(32, 86);
            this.lboxTransactions.Name = "lboxTransactions";
            this.lboxTransactions.Size = new System.Drawing.Size(549, 173);
            this.lboxTransactions.TabIndex = 7;
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.Location = new System.Drawing.Point(234, 34);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(135, 26);
            this.lblTransactions.TabIndex = 6;
            this.lblTransactions.Text = "Transactions";
            this.lblTransactions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.Controls.Add(this.pnlOpen);
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
            this.pnlOpen.ResumeLayout(false);
            this.pnlOpen.PerformLayout();
            this.pnlDeposit.ResumeLayout(false);
            this.pnlDeposit.PerformLayout();
            this.pnlWithdraw.ResumeLayout(false);
            this.pnlWithdraw.PerformLayout();
            this.pnlBalance.ResumeLayout(false);
            this.pnlBalance.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
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
        private System.Windows.Forms.Panel pnlOpen;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Panel pnlBalance;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblOpenBalance;
        private System.Windows.Forms.TextBox tboxOpenBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.TextBox tboxDepositAmount;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblWithdrawAmount;
        private System.Windows.Forms.TextBox tboxWithdrawAmount;
        private System.Windows.Forms.Label lblBalanceNum;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.ListBox lboxTransactions;
        private System.Windows.Forms.Label lblTransactions;
    }
}

