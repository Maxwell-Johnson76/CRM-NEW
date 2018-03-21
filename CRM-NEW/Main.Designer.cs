namespace CRM_NEW
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.vehicleLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.invoicesLabel = new System.Windows.Forms.Label();
            this.mainExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(139, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joe\'s Automotive CRM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customerLabel
            // 
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerLabel.Location = new System.Drawing.Point(81, 130);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(100, 23);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer";
            this.customerLabel.Click += new System.EventHandler(this.customerLabel_Click);
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.vehicleLabel.Location = new System.Drawing.Point(307, 130);
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(74, 24);
            this.vehicleLabel.TabIndex = 2;
            this.vehicleLabel.Text = "Vehicle";
            this.vehicleLabel.Click += new System.EventHandler(this.vehicleLabel_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.partsLabel.Location = new System.Drawing.Point(81, 202);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(100, 23);
            this.partsLabel.TabIndex = 3;
            this.partsLabel.Text = "Parts";
            this.partsLabel.Click += new System.EventHandler(this.partsLabel_Click);
            // 
            // invoicesLabel
            // 
            this.invoicesLabel.AutoSize = true;
            this.invoicesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicesLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invoicesLabel.Location = new System.Drawing.Point(307, 201);
            this.invoicesLabel.Name = "invoicesLabel";
            this.invoicesLabel.Size = new System.Drawing.Size(79, 24);
            this.invoicesLabel.TabIndex = 4;
            this.invoicesLabel.Text = "Invoices";
            this.invoicesLabel.Click += new System.EventHandler(this.invoicesLabel_Click);
            // 
            // mainExitButton
            // 
            this.mainExitButton.Location = new System.Drawing.Point(178, 214);
            this.mainExitButton.Name = "mainExitButton";
            this.mainExitButton.Size = new System.Drawing.Size(103, 35);
            this.mainExitButton.TabIndex = 5;
            this.mainExitButton.Text = "Exit";
            this.mainExitButton.UseVisualStyleBackColor = true;
            this.mainExitButton.Click += new System.EventHandler(this.mainExitButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.mainExitButton);
            this.Controls.Add(this.invoicesLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.vehicleLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label invoicesLabel;
        private System.Windows.Forms.Button mainExitButton;
    }
}

