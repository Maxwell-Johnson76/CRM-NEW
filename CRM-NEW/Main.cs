using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_NEW
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void customerLabel_Click(object sender, EventArgs e)
        {
            //Opens the Customer Tab
            Customer myCustomer = new Customer();
            myCustomer.ShowDialog();
        }

        private void vehicleLabel_Click(object sender, EventArgs e)
        {
            //Opens the Vehicles Tab
            Vehicle myVehicle = new Vehicle();
            myVehicle.ShowDialog();
        }

        private void partsLabel_Click(object sender, EventArgs e)
        {
            //Opens the parts Tab
            Parts myParts = new Parts();
            myParts.ShowDialog();
        }

        private void invoicesLabel_Click(object sender, EventArgs e)
        {
            //Opens the invoices Tab
            Invoices myInvoices = new Invoices();
            myInvoices.ShowDialog();
        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            //Close the program
            this.Close();
        }
    }
}
