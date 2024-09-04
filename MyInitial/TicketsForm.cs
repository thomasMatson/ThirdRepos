using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ticketing
{
    public partial class TicketsForm : Form
    {
        TicketPrice mTicketPrice;
        int mSection = 2;
        int mQuantity = 0;
        bool mDiscount = false;
        decimal discountAmount = 5m; // Default discount amount set to 5

        public TicketsForm()
        {
            InitializeComponent();
        }

        private void TicketsForm_Load(object sender, EventArgs e)
        {
            // Initialize discount amount to $5 when the form loads
            txtDiscount.Text = discountAmount.ToString();
        }

        // Event handler when a section is selected
        private void Section_CheckedChanged(object sender, EventArgs e)
        {
            // When the user selects any section, set discount to $5
            txtDiscount.Text = "5";
        }

        private void cmdCalculate_Click(object sender, EventArgs e)
        {
            mQuantity = int.Parse(txtQuantity.Text);

            // Read discount amount entered by the user
            discountAmount = decimal.Parse(txtDiscount.Text);

            if (chkDiscount.Checked)
                { mDiscount = true; }

            if (radBalcony.Checked)
                { mSection = 1; }
            if (radGeneral.Checked)
                { mSection = 2; }
            if (radBox.Checked)
                { mSection = 3; }
            if (radBack.Checked)
                { mSection = 4; }

            // Pass the discount amount to the TicketPrice class
            mTicketPrice = new TicketPrice(mSection, mQuantity, mDiscount, discountAmount);

            mTicketPrice.calculatePrice();
            lblAmount.Text = System.Convert.ToString(mTicketPrice.AmountDue);
        }

        private void radBalcony_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
