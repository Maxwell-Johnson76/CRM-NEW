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
    public partial class Invoices : Form
    {
        public Invoices()
        {
            InitializeComponent();
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.database1DataSet.Invoices);

        }

        private void createInvoicesButton_Click(object sender, EventArgs e)
        {
            Invoices2 myInvoices2 = new Invoices2();
            myInvoices2.ShowDialog();
        }

        private void searchInvoicesTextBox_TextChanged(object sender, EventArgs e)
        {
            this.invoicesTableAdapter.InvoicesSearch(this.database1DataSet.Invoices, searchInvoicesTextBox.Text);
        }
    }
}
