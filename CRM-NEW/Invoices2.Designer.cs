namespace CRM_NEW
{
    partial class Invoices2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label vehicle_Info_Label;
            System.Windows.Forms.Label labor_costsLabel;
            System.Windows.Forms.Label parts_usedLabel;
            System.Windows.Forms.Label joe_s_Automotive_infoLabel;
            System.Windows.Forms.Label customer_InfoLabel;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoices2));
            this.invoicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new CRM_NEW.Database1DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.invoicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fluidCheckBox = new System.Windows.Forms.CheckBox();
            this.fluidLabel = new System.Windows.Forms.Label();
            this.tableAdapterManager = new CRM_NEW.Database1DataSetTableAdapters.TableAdapterManager();
            this.estimateCheckBox = new System.Windows.Forms.CheckBox();
            this.invoiceCheckBox = new System.Windows.Forms.CheckBox();
            this.invoicesTableAdapter = new CRM_NEW.Database1DataSetTableAdapters.InvoicesTableAdapter();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.vehicle_Info_TextBox = new System.Windows.Forms.TextBox();
            this.labor_costsTextBox = new System.Windows.Forms.TextBox();
            this.parts_usedTextBox = new System.Windows.Forms.TextBox();
            this.joe_s_Automotive_infoTextBox = new System.Windows.Forms.TextBox();
            this.customer_InfoTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            vehicle_Info_Label = new System.Windows.Forms.Label();
            labor_costsLabel = new System.Windows.Forms.Label();
            parts_usedLabel = new System.Windows.Forms.Label();
            joe_s_Automotive_infoLabel = new System.Windows.Forms.Label();
            customer_InfoLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).BeginInit();
            this.invoicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(152, 84);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 25;
            iDLabel.Text = "ID:";
            // 
            // vehicle_Info_Label
            // 
            vehicle_Info_Label.AutoSize = true;
            vehicle_Info_Label.Location = new System.Drawing.Point(152, 110);
            vehicle_Info_Label.Name = "vehicle_Info_Label";
            vehicle_Info_Label.Size = new System.Drawing.Size(69, 13);
            vehicle_Info_Label.TabIndex = 27;
            vehicle_Info_Label.Text = "Vehicle Info :";
            // 
            // labor_costsLabel
            // 
            labor_costsLabel.AutoSize = true;
            labor_costsLabel.Location = new System.Drawing.Point(152, 136);
            labor_costsLabel.Name = "labor_costsLabel";
            labor_costsLabel.Size = new System.Drawing.Size(65, 13);
            labor_costsLabel.TabIndex = 29;
            labor_costsLabel.Text = "Labor costs:";
            // 
            // parts_usedLabel
            // 
            parts_usedLabel.AutoSize = true;
            parts_usedLabel.Location = new System.Drawing.Point(152, 162);
            parts_usedLabel.Name = "parts_usedLabel";
            parts_usedLabel.Size = new System.Drawing.Size(60, 13);
            parts_usedLabel.TabIndex = 31;
            parts_usedLabel.Text = "Parts used:";
            // 
            // joe_s_Automotive_infoLabel
            // 
            joe_s_Automotive_infoLabel.AutoSize = true;
            joe_s_Automotive_infoLabel.Location = new System.Drawing.Point(152, 188);
            joe_s_Automotive_infoLabel.Name = "joe_s_Automotive_infoLabel";
            joe_s_Automotive_infoLabel.Size = new System.Drawing.Size(110, 13);
            joe_s_Automotive_infoLabel.TabIndex = 33;
            joe_s_Automotive_infoLabel.Text = "Joe\'s Automotive info:";
            // 
            // customer_InfoLabel
            // 
            customer_InfoLabel.AutoSize = true;
            customer_InfoLabel.Location = new System.Drawing.Point(152, 214);
            customer_InfoLabel.Name = "customer_InfoLabel";
            customer_InfoLabel.Size = new System.Drawing.Size(75, 13);
            customer_InfoLabel.TabIndex = 35;
            customer_InfoLabel.Text = "Customer Info:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(152, 240);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 37;
            nameLabel.Text = "Name:";
            // 
            // invoicesBindingNavigator
            // 
            this.invoicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.invoicesBindingNavigator.BindingSource = this.invoicesBindingSource;
            this.invoicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.invoicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.invoicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.invoicesBindingNavigatorSaveItem});
            this.invoicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.invoicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.invoicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.invoicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.invoicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.invoicesBindingNavigator.Name = "invoicesBindingNavigator";
            this.invoicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.invoicesBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.invoicesBindingNavigator.TabIndex = 0;
            this.invoicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // invoicesBindingNavigatorSaveItem
            // 
            this.invoicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.invoicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("invoicesBindingNavigatorSaveItem.Image")));
            this.invoicesBindingNavigatorSaveItem.Name = "invoicesBindingNavigatorSaveItem";
            this.invoicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.invoicesBindingNavigatorSaveItem.Text = "Save Data";
            this.invoicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.invoicesBindingNavigatorSaveItem_Click);
            // 
            // fluidCheckBox
            // 
            this.fluidCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fluidCheckBox.Location = new System.Drawing.Point(211, 275);
            this.fluidCheckBox.Name = "fluidCheckBox";
            this.fluidCheckBox.Size = new System.Drawing.Size(128, 32);
            this.fluidCheckBox.TabIndex = 11;
            this.fluidCheckBox.Text = "$24.99";
            this.fluidCheckBox.UseVisualStyleBackColor = true;
            // 
            // fluidLabel
            // 
            this.fluidLabel.AutoSize = true;
            this.fluidLabel.Location = new System.Drawing.Point(130, 286);
            this.fluidLabel.Name = "fluidLabel";
            this.fluidLabel.Size = new System.Drawing.Size(75, 13);
            this.fluidLabel.TabIndex = 12;
            this.fluidLabel.Text = "Fluid Checkup";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.InvoicesTableAdapter = null;
            this.tableAdapterManager.PartsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CRM_NEW.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = null;
            // 
            // estimateCheckBox
            // 
            this.estimateCheckBox.AutoSize = true;
            this.estimateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimateCheckBox.Location = new System.Drawing.Point(140, 329);
            this.estimateCheckBox.Name = "estimateCheckBox";
            this.estimateCheckBox.Size = new System.Drawing.Size(100, 28);
            this.estimateCheckBox.TabIndex = 24;
            this.estimateCheckBox.Text = "Estimate";
            this.estimateCheckBox.UseVisualStyleBackColor = true;
            // 
            // invoiceCheckBox
            // 
            this.invoiceCheckBox.AutoSize = true;
            this.invoiceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceCheckBox.Location = new System.Drawing.Point(284, 329);
            this.invoiceCheckBox.Name = "invoiceCheckBox";
            this.invoiceCheckBox.Size = new System.Drawing.Size(89, 28);
            this.invoiceCheckBox.TabIndex = 25;
            this.invoiceCheckBox.Text = "Invoice";
            this.invoiceCheckBox.UseVisualStyleBackColor = true;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(268, 81);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDTextBox.TabIndex = 26;
            // 
            // vehicle_Info_TextBox
            // 
            this.vehicle_Info_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Vehicle Info ", true));
            this.vehicle_Info_TextBox.Location = new System.Drawing.Point(268, 107);
            this.vehicle_Info_TextBox.Name = "vehicle_Info_TextBox";
            this.vehicle_Info_TextBox.Size = new System.Drawing.Size(100, 20);
            this.vehicle_Info_TextBox.TabIndex = 28;
            // 
            // labor_costsTextBox
            // 
            this.labor_costsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Labor costs", true));
            this.labor_costsTextBox.Location = new System.Drawing.Point(268, 133);
            this.labor_costsTextBox.Name = "labor_costsTextBox";
            this.labor_costsTextBox.Size = new System.Drawing.Size(100, 20);
            this.labor_costsTextBox.TabIndex = 30;
            // 
            // parts_usedTextBox
            // 
            this.parts_usedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Parts used", true));
            this.parts_usedTextBox.Location = new System.Drawing.Point(268, 159);
            this.parts_usedTextBox.Name = "parts_usedTextBox";
            this.parts_usedTextBox.Size = new System.Drawing.Size(100, 20);
            this.parts_usedTextBox.TabIndex = 32;
            // 
            // joe_s_Automotive_infoTextBox
            // 
            this.joe_s_Automotive_infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Joe\'s Automotive info", true));
            this.joe_s_Automotive_infoTextBox.Location = new System.Drawing.Point(268, 185);
            this.joe_s_Automotive_infoTextBox.Name = "joe_s_Automotive_infoTextBox";
            this.joe_s_Automotive_infoTextBox.Size = new System.Drawing.Size(100, 20);
            this.joe_s_Automotive_infoTextBox.TabIndex = 34;
            // 
            // customer_InfoTextBox
            // 
            this.customer_InfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Customer Info", true));
            this.customer_InfoTextBox.Location = new System.Drawing.Point(268, 211);
            this.customer_InfoTextBox.Name = "customer_InfoTextBox";
            this.customer_InfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_InfoTextBox.TabIndex = 36;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.invoicesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(268, 237);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 40;
            // 
            // Invoices2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(575, 470);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(vehicle_Info_Label);
            this.Controls.Add(this.vehicle_Info_TextBox);
            this.Controls.Add(labor_costsLabel);
            this.Controls.Add(this.labor_costsTextBox);
            this.Controls.Add(parts_usedLabel);
            this.Controls.Add(this.parts_usedTextBox);
            this.Controls.Add(joe_s_Automotive_infoLabel);
            this.Controls.Add(this.joe_s_Automotive_infoTextBox);
            this.Controls.Add(customer_InfoLabel);
            this.Controls.Add(this.customer_InfoTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.invoiceCheckBox);
            this.Controls.Add(this.estimateCheckBox);
            this.Controls.Add(this.fluidLabel);
            this.Controls.Add(this.fluidCheckBox);
            this.Controls.Add(this.invoicesBindingNavigator);
            this.Name = "Invoices2";
            this.Text = "Invoices2";
            this.Load += new System.EventHandler(this.Invoices2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingNavigator)).EndInit();
            this.invoicesBindingNavigator.ResumeLayout(false);
            this.invoicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator invoicesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton invoicesBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox fluidCheckBox;
        private System.Windows.Forms.Label fluidLabel;
        private System.Windows.Forms.CheckBox estimateCheckBox;
        private System.Windows.Forms.CheckBox invoiceCheckBox;
        private Database1DataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox vehicle_Info_TextBox;
        private System.Windows.Forms.TextBox labor_costsTextBox;
        private System.Windows.Forms.TextBox parts_usedTextBox;
        private System.Windows.Forms.TextBox joe_s_Automotive_infoTextBox;
        private System.Windows.Forms.TextBox customer_InfoTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}