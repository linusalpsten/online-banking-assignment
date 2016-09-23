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
            lboxAccounts.DisplayMember = "displayMember";
            lboxTransactions.DisplayMember = "information";

            // Add user type combo box alternatives
            cboxUserType.Items.Add("Staff");    // usertypeID = 0
            cboxUserType.Items.Add("Client");   // usertypeID = 1

            // Hide panels
            hidePanels();

            // Disable buttons
            disableMenuButtons();
            btnOpen.Click += showClientsAccounts;
        }

        // Controller functions
        private void hidePanels()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    control.Visible = false;
                }
            }
        }
        private void showClientsAccounts()
        {
            lboxAccounts.Items.Clear();
            foreach (Account account in ((Client)lboxClients.SelectedItem).accounts)
            {
                lboxAccounts.Items.Add(account);
            }
        }
        private void showClientsAccounts(object sender, EventArgs e)
        {
            lboxAccounts.Items.Clear();
            foreach (Account account in ((Client)lboxClients.SelectedItem).accounts)
            {
                lboxAccounts.Items.Add(account);
            }
        }
        private void showAccountTransactions()
        {

            // Clear listbox
            lboxTransactions.Items.Clear();

            // Add account transactions to listbox
            foreach (Transaction transaction in ((Account)lboxAccounts.SelectedItem).transactions)
            {
                lboxTransactions.Items.Add(transaction);
            }
        }
        private void enableButtons()
        {
            hidePanels();
            if (cboxUserType.SelectedIndex != -1 && lboxClients.SelectedIndex != -1)
            {
                btnShowPanelOpen.Enabled = true;
            }

            // Must have user type
            if (cboxUserType.SelectedIndex == -1)
            {
                return;
            }

            // Must have client
            if (lboxClients.SelectedIndex == -1)
            {
                return;
            }

            btnShowPanelOpen.Enabled = true;

            if (lboxAccounts.SelectedIndex == -1)
            {
                return;
            }

            switch (cboxUserType.SelectedIndex)
            {
                case 0: //user type is staff
                    btnShowPanelTransactions.Enabled = true;
                    break;
                case 1:
                    btnShowPanelDeposit.Enabled = true;
                    btnShowPanelBalance.Enabled = true;
                    btnShowPanelWithdraw.Enabled = true;
                    break;
                default:
                    break;
            }
        }
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
        private bool getIsNumberInTextbox(TextBox tbox)
        {
            int num;
            return int.TryParse(tbox.Text, out num);
        }

        // Show panel button clicked
        private void btnShowPanelOpen_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlOpen.Visible = true;
        }
        private void btnShowPanelDeposit_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlDeposit.Visible = true;
        }
        private void btnShowPanelWithdraw_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlWithdraw.Visible = true;
        }
        private void btnShowPanelBalance_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlBalance.Visible = true;
            lblBalanceNum.Text = ((Account)lboxAccounts.SelectedItem).getBalance().ToString();
        }
        private void btnShowPanelTransactions_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlTransactions.Visible = true;
            showAccountTransactions();
        }

        // User type selected
        private void cboxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            hidePanels();

            // Enable the buttons based on conditions
            disableMenuButtons();
            enableButtons();
        }

        // Client selected
        private void lboxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            hidePanels();

            // Show accounts belonging to selected client
            showClientsAccounts();

            // Enable the buttons based on conditions
            disableMenuButtons();
            enableButtons();
        }

        // Account selected
        private void lboxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            hidePanels();

            // Enable the buttons based on conditions
            disableMenuButtons();
            enableButtons();

            //
            showAccountTransactions();
        }

        // Deposit
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(tboxDepositAmount.Text, out amount))
            {
                return;
            }
            ((Account)lboxAccounts.SelectedItem).Deposit(amount);
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

            if (balance < 1000)
            {
                MessageBox.Show("The minimum amount required to open a new account is: 1000");
                tboxOpenBalance.Focus();
                return;
            }

            ((Client)lboxClients.SelectedItem).addAccount(new Account(int.Parse(tboxOpenBalance.Text)) { accountNr = lboxAccounts.Items.Count + 1 });
            tboxOpenBalance.Text = string.Empty;
        }

        // Withdraw
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int amount;
            if (!int.TryParse(tboxWithdrawAmount.Text, out amount))
            {
                return;
            }
            ((Account)lboxAccounts.SelectedItem).Withdraw(amount);
            tboxWithdrawAmount.Text = string.Empty;
        }
    }
}
