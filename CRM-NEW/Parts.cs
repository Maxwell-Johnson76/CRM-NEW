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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.database1DataSet.Parts);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.partsTableAdapter.PartSearch(
                this.database1DataSet.Parts, searchTextBox.Text);
        }
    }
}
