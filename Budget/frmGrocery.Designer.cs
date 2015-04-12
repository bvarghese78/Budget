namespace Budget
{
    partial class frmGrocery
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnStoreLock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnData = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGrocery = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.txtSale = new System.Windows.Forms.TextBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.txtTotalLB = new System.Windows.Forms.TextBox();
            this.lblTotalLB = new System.Windows.Forms.Label();
            this.txtPerLB = new System.Windows.Forms.TextBox();
            this.lblPerLB = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.lblSavings = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrocery)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Groceries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Store:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Enabled = false;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(527, 55);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 15);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            this.lblCity.Visible = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Enabled = false;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(744, 56);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 15);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State:";
            this.lblState.Visible = false;
            // 
            // cmbStore
            // 
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(338, 54);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(164, 21);
            this.cmbStore.TabIndex = 4;
            this.cmbStore.SelectedValueChanged += new System.EventHandler(this.cmbStore_SelectedValueChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(563, 55);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(164, 20);
            this.txtCity.TabIndex = 5;
            this.txtCity.Visible = false;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(789, 56);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(145, 20);
            this.txtState.TabIndex = 6;
            this.txtState.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Enabled = false;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(10, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 15);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date:";
            this.lblDate.Visible = false;
            // 
            // btnStoreLock
            // 
            this.btnStoreLock.Location = new System.Drawing.Point(431, 91);
            this.btnStoreLock.Name = "btnStoreLock";
            this.btnStoreLock.Size = new System.Drawing.Size(108, 27);
            this.btnStoreLock.TabIndex = 9;
            this.btnStoreLock.Text = "LOCK";
            this.btnStoreLock.UseVisualStyleBackColor = true;
            this.btnStoreLock.Visible = false;
            this.btnStoreLock.Click += new System.EventHandler(this.btnStoreLock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnData);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(13, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 341);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Entry";
            this.groupBox1.Visible = false;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(418, 308);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(108, 27);
            this.btnData.TabIndex = 25;
            this.btnData.Text = "INSERT";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Visible = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.dgvGrocery);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtTotalAmount);
            this.panel1.Controls.Add(this.lblTotalAmount);
            this.panel1.Controls.Add(this.txtOriginal);
            this.panel1.Controls.Add(this.lblOriginal);
            this.panel1.Controls.Add(this.txtSale);
            this.panel1.Controls.Add(this.lblSale);
            this.panel1.Controls.Add(this.txtTotalLB);
            this.panel1.Controls.Add(this.lblTotalLB);
            this.panel1.Controls.Add(this.txtPerLB);
            this.panel1.Controls.Add(this.lblPerLB);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Controls.Add(this.txtCategory);
            this.panel1.Controls.Add(this.lblCategory);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 288);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // dgvGrocery
            // 
            this.dgvGrocery.BackgroundColor = System.Drawing.Color.Khaki;
            this.dgvGrocery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrocery.Location = new System.Drawing.Point(6, 99);
            this.dgvGrocery.Name = "dgvGrocery";
            this.dgvGrocery.Size = new System.Drawing.Size(900, 184);
            this.dgvGrocery.TabIndex = 25;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(491, 71);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 27);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Visible = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(305, 72);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(145, 20);
            this.txtTotalAmount.TabIndex = 23;
            this.txtTotalAmount.Visible = false;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Enabled = false;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(262, 72);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(37, 15);
            this.lblTotalAmount.TabIndex = 22;
            this.lblTotalAmount.Text = "Total:";
            this.lblTotalAmount.Visible = false;
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(696, 42);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.Size = new System.Drawing.Size(145, 20);
            this.txtOriginal.TabIndex = 21;
            this.txtOriginal.Visible = false;
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Enabled = false;
            this.lblOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginal.Location = new System.Drawing.Point(603, 42);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(84, 15);
            this.lblOriginal.TabIndex = 20;
            this.lblOriginal.Text = "Original Price:";
            this.lblOriginal.Visible = false;
            // 
            // txtSale
            // 
            this.txtSale.Location = new System.Drawing.Point(696, 13);
            this.txtSale.Name = "txtSale";
            this.txtSale.Size = new System.Drawing.Size(145, 20);
            this.txtSale.TabIndex = 19;
            this.txtSale.Visible = false;
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Enabled = false;
            this.lblSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSale.Location = new System.Drawing.Point(618, 14);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(69, 15);
            this.lblSale.TabIndex = 18;
            this.lblSale.Text = "Sale Price: ";
            this.lblSale.Visible = false;
            // 
            // txtTotalLB
            // 
            this.txtTotalLB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtTotalLB.Location = new System.Drawing.Point(410, 43);
            this.txtTotalLB.Name = "txtTotalLB";
            this.txtTotalLB.Size = new System.Drawing.Size(145, 20);
            this.txtTotalLB.TabIndex = 17;
            this.txtTotalLB.Visible = false;
            // 
            // lblTotalLB
            // 
            this.lblTotalLB.AutoSize = true;
            this.lblTotalLB.Enabled = false;
            this.lblTotalLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLB.Location = new System.Drawing.Point(322, 42);
            this.lblTotalLB.Name = "lblTotalLB";
            this.lblTotalLB.Size = new System.Drawing.Size(82, 15);
            this.lblTotalLB.TabIndex = 16;
            this.lblTotalLB.Text = "Total Pounds:";
            this.lblTotalLB.Visible = false;
            // 
            // txtPerLB
            // 
            this.txtPerLB.Location = new System.Drawing.Point(410, 13);
            this.txtPerLB.Name = "txtPerLB";
            this.txtPerLB.Size = new System.Drawing.Size(145, 20);
            this.txtPerLB.TabIndex = 15;
            this.txtPerLB.Visible = false;
            // 
            // lblPerLB
            // 
            this.lblPerLB.AutoSize = true;
            this.lblPerLB.Enabled = false;
            this.lblPerLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerLB.Location = new System.Drawing.Point(291, 13);
            this.lblPerLB.Name = "lblPerLB";
            this.lblPerLB.Size = new System.Drawing.Size(113, 15);
            this.lblPerLB.TabIndex = 14;
            this.lblPerLB.Text = "Amount Per Pound:";
            this.lblPerLB.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(81, 47);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(145, 20);
            this.txtDesc.TabIndex = 13;
            this.txtDesc.Visible = false;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Enabled = false;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(3, 48);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(72, 15);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "Description:";
            this.lblDesc.Visible = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(81, 13);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(145, 20);
            this.txtCategory.TabIndex = 11;
            this.txtCategory.Visible = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Enabled = false;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(16, 13);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.txtTax);
            this.groupBox2.Controls.Add(this.lblTax);
            this.groupBox2.Controls.Add(this.txtSavings);
            this.groupBox2.Controls.Add(this.lblSavings);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.lblSubtotal);
            this.groupBox2.Location = new System.Drawing.Point(13, 491);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(921, 46);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total";
            this.groupBox2.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(727, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 27);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(556, 16);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(98, 20);
            this.txtTotal.TabIndex = 16;
            this.txtTotal.Visible = false;
            this.txtTotal.Enter += new System.EventHandler(this.txtTotal_Enter);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(497, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 15);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(376, 15);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(98, 20);
            this.txtTax.TabIndex = 14;
            this.txtTax.Visible = false;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Enabled = false;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(340, 17);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(30, 15);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Tax:";
            this.lblTax.Visible = false;
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(232, 14);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.Size = new System.Drawing.Size(98, 20);
            this.txtSavings.TabIndex = 12;
            this.txtSavings.Visible = false;
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Enabled = false;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.Location = new System.Drawing.Point(173, 15);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(53, 15);
            this.lblSavings.TabIndex = 11;
            this.lblSavings.Text = "Savings:";
            this.lblSavings.Visible = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(67, 15);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(98, 20);
            this.txtSubtotal.TabIndex = 10;
            this.txtSubtotal.Visible = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Enabled = false;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(6, 16);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(55, 15);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "Subtotal:";
            this.lblSubtotal.Visible = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(52, 55);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 12;
            this.dtpDate.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Visible = false;
            // 
            // frmGrocery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(960, 549);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStoreLock);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.cmbStore);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGrocery";
            this.Text = "frmGrocery";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrocery)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnStoreLock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.TextBox txtSale;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.TextBox txtTotalLB;
        private System.Windows.Forms.Label lblTotalLB;
        private System.Windows.Forms.TextBox txtPerLB;
        private System.Windows.Forms.Label lblPerLB;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataGridView dgvGrocery;
    }
}