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

            // Set client listbox display member to the clients full name
            lboxClients.DisplayMember = "fullName";

            // Add accounts to each client and add the clients to the client listbox
            for (int clientIndex = 0; clientIndex < clients.Count; clientIndex++)
            {
                Client client = clients[clientIndex];

                // Create accounts
                for (int i = 0; i < (clientIndex + 1); i++)
                {
                    client.accounts.Add(new Account());
                }

                // Add client to listbox
                lboxClients.Items.Add(client);
            }

            // Add user type combo box alternatives
            cboxUserType.Items.Add("Staff");    // usertypeID = 0
            cboxUserType.Items.Add("Client");   // usertypeID = 1

            // Hide panels
            hidePanels();

            // Disable buttons
            disableButtons();

        }

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

        private void showClientsAccounts(object sender, EventArgs e)
        {
            lboxAccounts.Items.Clear();
            foreach (Account account in ((Client)lboxClients.SelectedItem).accounts)
            {
                lboxAccounts.Items.Add(account);
            }
        }

        private void disableButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false;
                }
            }
        }

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
        }

        private void btnShowPanelTransactions_Click(object sender, EventArgs e)
        {
            hidePanels();
            pnlTransactions.Visible = true;
        }
    }
}
