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
    public partial class Vehicle : Form
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void vehicleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vehicleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.database1DataSet.Vehicle);

        }

        private void listButton_Click(object sender, EventArgs e)
        {
            Vehicle2 myVehicle2 = new Vehicle2();
            myVehicle2.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.vehicleTableAdapter.VehicleCustSearch(
               this.database1DataSet.Vehicle, searchTextBox.Text);
        }
    }
}
