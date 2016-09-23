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

        public OnlineBankingForm()
        {
            InitializeComponent();
            hidePanels();
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
