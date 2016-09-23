using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using onlineBankingLibrary;

namespace OnlineBanking
{

    public partial class OnlineBankingForm : Form
    {

        List<Client> clients;

        public OnlineBankingForm()
        {
            InitializeComponent();

            // Initalize clients
            clients = new List<Client>();

            // Add default clients
            clients.Add(new Client() { firstName = "Kalle", lastName = "Anka" });
            clients.Add(new Client() { firstName = "Musse", lastName = "Pigg" });
            clients.Add(new Client() { firstName = "Janne", lastName = "Långben" });

            // Add accounts to each client and add the clients to the client listbox
            for (int clientIndex = 0; clientIndex < clients.Count; clientIndex++)
            {
                Client client = clients[clientIndex];

                // Create accounts
                for (int i = 0; i < (clientIndex + 1); i++)
                {
                    client.accounts.Add(new Account() { accountNr = (i + 1) });
                }

                // Add client to listbox
                lboxClients.Items.Add(client);
            }

            // Set listbox display members
            lboxClients.DisplayMember = "fullName";
            lboxAccounts.DisplayMember = "information";
            lboxTransactions.DisplayMember = "information";

            // Add user type combo box alternatives
            cboxUserType.Items.Add("Staff");    // usertypeID = 0
            cboxUserType.Items.Add("Client");   // usertypeID = 1

            // Hide panels
            hideAllPanels();

            // Disable buttons
            disableMenuButtons();

            // Set panel position
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    control.Left = 233;
                    control.Top = 88;
                }
            }

            // Set form size
            this.Width = 1024;
            this.Height = 512;
        }

        // Controller functions

        /// <summary>
        /// Hide all panels belonging to the form
        /// </summary>
        private void hideAllPanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    control.Visible = false;
                }
            }
        }
        /// <summary>
        /// Shows the accounts of the selected client in the account listbox
        /// </summary>
        private void showClientAccounts()
        {
            // Must have selected a client
            if (lboxClients.SelectedItem == null)
            {
                return;
            }

            // Clear account listbox
            lboxAccounts.Items.Clear();
            
            // Add the clients accounts to account listbox
            foreach (Account account in ((Client)lboxClients.SelectedItem).accounts)
            {
                lboxAccounts.Items.Add(account);
            }
        }
        /// <summary>
        /// Shows the transactions of the selected account in the transaction listbox
        /// </summary>
        private void showAccountTransactions()
        {
            // Must have selected an account
            if (lboxAccounts.SelectedItem == null)
            {
                return;
            }

            // Clear listbox
            lboxTransactions.Items.Clear();

            // Add account transactions to listbox
            foreach (Transaction transaction in ((Account)lboxAccounts.SelectedItem).transactions)
            {
                lboxTransactions.Items.Add(transaction);
            }
        }
        /// <summary>
        /// Enables the menu buttons based on conditions
        /// </summary>
        private void enableButtons()
        {
            // Must have selected a user type and a client
            if (cboxUserType.SelectedIndex != -1 && lboxClients.SelectedIndex != -1)
            {
                btnShowPanelOpen.Enabled = true;
            }

            // Must have selected an account
            if (lboxAccounts.SelectedIndex != -1)
            {
                switch (cboxUserType.SelectedIndex)
                {
                    case 0: 
                        // Staff
                        btnShowPanelTransactions.Enabled = true;
                        break;
                    case 1:
                        // Client
                        btnShowPanelDeposit.Enabled = true;
                        btnShowPanelBalance.Enabled = true;
                        btnShowPanelWithdraw.Enabled = true;
                        break;
                    default:
                        break;
                }
            }

        }
        /// <summary>
        /// Disables all menu buttons
        /// </summary>
        private void disableMenuButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
        }
        /// <summary>
        /// Show the panel and hide the others
        /// </summary>
        /// <param name="panel">The panel you wish to show</param>
        private void showPanel(Panel panel)
        {
            hideAllPanels();
            panel.Visible = true;
        }

        // Show panel button clicked
        private void btnShowPanelOpen_Click(object sender, EventArgs e)
        {
            showPanel(pnlOpen);
        }
        private void btnShowPanelDeposit_Click(object sender, EventArgs e)
        {
            showPanel(pnlDeposit);
        }
        private void btnShowPanelWithdraw_Click(object sender, EventArgs e)
        {
            showPanel(pnlWithdraw);
        }
        private void btnShowPanelBalance_Click(object sender, EventArgs e)
        {
            showPanel(pnlBalance);

            // Set balance number to account balance
            lblBalanceNum.Text = ((Account)lboxAccounts.SelectedItem).getBalance().ToString();
        }
        private void btnShowPanelTransactions_Click(object sender, EventArgs e)
        {
            showPanel(pnlTransactions);
            showAccountTransactions();
        }

        // User type selected
        private void cboxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all panels
            hideAllPanels();

            // Enable the buttons based on conditions
            disableMenuButtons();
            enableButtons();
        }

        // Client selected
        private void lboxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all panels
            hideAllPanels();

            // Show accounts belonging to selected client
            showClientAccounts();

            // Enable the buttons based on conditions
            disableMenuButtons();
            enableButtons();
        }

        // Account selected
        private void lboxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all panels
            hideAllPanels();

            // Enable the buttons based on conditions
            disableMenuButtons();
            enableButtons();
        }

        // Deposit
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int amount;

            // Amount must be a number
            if (!int.TryParse(tboxDepositAmount.Text, out amount))
            {
                return;
            }

            // Deposit amount
            ((Account)lboxAccounts.SelectedItem).deposit(amount);

            // Clear textboxes
            tboxDepositAmount.Text = string.Empty;
        }

        // Open new account
        private void btnOpen_Click(object sender, EventArgs e)
        {
            int balance;

            // Textbox content must be a number
            if (!int.TryParse(tboxOpenBalance.Text, out balance))
            {
                MessageBox.Show("The account balance must be a number.");
                tboxOpenBalance.Focus();
                return;
            }

            // Balance must be 1000 or above
            if (balance < 1000)
            {
                MessageBox.Show("The minimum amount required to open a new account is: 1000");
                tboxOpenBalance.Focus();
                return;
            }

            // Add to account list
            ((Client)lboxClients.SelectedItem).addAccount(new Account(int.Parse(tboxOpenBalance.Text)) { accountNr = lboxAccounts.Items.Count + 1 });

            // Refresh client listbox
            showClientAccounts();

            // Clear textbox
            tboxOpenBalance.Text = string.Empty;
        }

        // Withdraw
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int amount;

            // Amount must be a number
            if (!int.TryParse(tboxWithdrawAmount.Text, out amount))
            {
                return;
            }

            // Withdraw amount
            ((Account)lboxAccounts.SelectedItem).withdraw(amount);

            // Clear textboxes
            tboxWithdrawAmount.Text = string.Empty;
        }
    }
}
