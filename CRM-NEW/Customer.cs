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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet.Customer);

        }

        private void listViewButton_Click(object sender, EventArgs e)
        {// Takes you to the customer2 form
            Customer2 myCustomer2 = new Customer2();
            myCustomer2.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.customerTableAdapter.PhoneSearch(
                this.database1DataSet.Customer, searchTextBox.Text);
        }
    }
}
