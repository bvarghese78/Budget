﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class frmGrocery : Form
    {
        private enum Display { storeInfo, newEntry, subTotal};
        List<GroceryStoreInfo> groceryStoreList = new List<GroceryStoreInfo>();
        List<InsertGroceries> newGroceryList = new List<InsertGroceries>();

        public frmGrocery()
        {
            InitializeComponent();
            BusinessLayer business = new BusinessLayer();
            groceryStoreList = business.getGroceryStores();

            foreach (var item in groceryStoreList)
            {
                cmbStore.Items.Add(item.StoreName);
            }
        }

        private void cmbStore_SelectedValueChanged(object sender, EventArgs e)
        {
            var selectedStoreName = cmbStore.SelectedItem;
            foreach(var item in groceryStoreList)
            {
                if (item.StoreName == Convert.ToString(selectedStoreName))
                {
                    txtCity.Text = item.City;
                    txtState.Text = item.State;

                    enableFields(Display.storeInfo); // Make fields visible
                }
            }
        }

        // Enable fields necessary for new Entries
        private void enableFields(Display value)
        {
            if (value == Display.storeInfo)
            {
                lblDate.Visible = true;
                lblCity.Visible = true;
                lblState.Visible = true;

                dtpDate.Visible = true;
                txtCity.Visible = true;
                txtState.Visible = true;

                btnStoreLock.Visible = true;

                disableFields(value);
            }
            else if (value == Display.newEntry)
            {
                groupBox1.Visible = true;
                panel1.Visible = true;
                dgvGrocery.Visible = true;
                btnInsert.Visible = true;

                lblCategory.Visible = true;
                lblDesc.Visible = true;
                lblPerLB.Visible = true;
                lblTotalLB.Visible = true;
                lblSale.Visible = true;
                lblOriginal.Visible = true;
                lblTotalAmount.Visible = true;

                txtCategory.Visible = true;
                txtDesc.Visible = true;
                txtPerLB.Visible = true;
                txtTotalLB.Visible = true;
                txtSale.Visible = true;
                txtOriginal.Visible = true;
                txtTotalAmount.Visible = true;

                disableFields(value);
            }
            else if (value == Display.subTotal)
            {
                groupBox2.Visible = true;
                btnUpdate.Visible = true;

                lblSubtotal.Visible = true;
                lblTax.Visible = true;
                lblSale.Visible = true;
                lblSavings.Visible = true;
                lblTotal.Visible = true;

                txtSubtotal.Visible = true;
                txtTax.Visible = true;
                txtSale.Visible = true;
                txtSavings.Visible = true;
                txtTotal.Visible = true;
            }
        }

        // make fields disappear if the se
        private void disableFields(Display value)
        {
            if (value == Display.storeInfo)
            {
                // Disable Contents in GroupBox # 1
                groupBox1.Visible = false;
                panel1.Visible = false;
                dgvGrocery.Visible = false;
                btnInsert.Visible = false;

                // Disable contents in GroupBox # 2
                groupBox2.Visible = false;
                btnUpdate.Visible = false;

                lblSavings.Visible = false;
                lblSubtotal.Visible = false;
                lblTax.Visible = false;
                lblTotal.Visible = false;

                txtSavings.Visible = false;
                txtSubtotal.Visible = false;
                txtTax.Visible = false;
                txtTotal.Visible = false;
            }
            else if (value == Display.newEntry)
            {

            }
            else if (value == Display.subTotal)
            {
                groupBox2.Visible = false;
                btnUpdate.Visible = false;

                lblSubtotal.Visible = false;
                lblTax.Visible = false;
                lblSale.Visible = false;
                lblSavings.Visible = false;
                lblTotal.Visible = false;

                txtSubtotal.Visible = false;
                txtTax.Visible = false;
                txtSale.Visible = false;
                txtSavings.Visible = false;
                txtTotal.Visible = false;
            }
        }

        private void btnStoreLock_Click(object sender, EventArgs e)
        {
            if (btnStoreLock.Text == "LOCK")
            {
                if (dtpDate.Value.ToShortDateString() == "1/1/2015")
                    MessageBox.Show("Please select a date to continue.", "Invalid Date");
                else
                {
                    // Prevent from changing values
                    dtpDate.Enabled = false;
                    txtCity.Enabled = false;
                    txtState.Enabled = false;
                    cmbStore.Enabled = false;

                    enableFields(Display.newEntry);
                    btnStoreLock.Text = "UNLOCK";
                }
            }
            else if (btnStoreLock.Text == "UNLOCK")
            {
                dtpDate.Enabled = true;
                txtCity.Enabled = true;
                txtState.Enabled = true;
                cmbStore.Enabled = true;

                //disableFields(Display.storeInfo);
                btnStoreLock.Text = "LOCK";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string category = txtCategory.Text;
                string description = txtDesc.Text;
                var perLb = txtPerLB.Text;
                var totalLb = txtTotalLB.Text;
                var sale = txtSale.Text;
                var original = txtOriginal.Text;
                var total = txtTotalAmount.Text;
                double perPoundAmount;
                double totalPounds;
                double salePrice;
                double originalPrice = 0.0;
                double totalAmount = 0.0;

                double.TryParse(perLb, out perPoundAmount);
                double.TryParse(totalLb, out totalPounds);
                double.TryParse(sale, out salePrice);
                double.TryParse(original, out originalPrice);
                double.TryParse(total, out totalAmount);

                if (description.Length == 0 || originalPrice == 0.0 || totalAmount == 0.0)
                {
                    MessageBox.Show("Please fix the invalid data", "Invalid Data");
                }
                else
                {
                    InsertGroceries groceries = new InsertGroceries();
                    
                    groceries.Category = category;
                    groceries.Description = description;
                    groceries.PerLB = perPoundAmount;
                    groceries.TotalLB = totalPounds;
                    groceries.SalePrice = salePrice;
                    groceries.OriginalPrice = originalPrice;
                    groceries.TotalAmount = totalAmount;

                    newGroceryList.Add(new InsertGroceries(groceries));

                    DataTable dt = new DataTable();
                    BuildGridView(newGroceryList, dt);
                    dgvGrocery.DataSource = dt;
                    btnData.Visible = true;

                    // Clear text boxes
                    txtCategory.Text = "";
                    txtDesc.Text = "";
                    txtPerLB.Text = "";
                    txtTotalLB.Text = "";
                    txtSale.Text = "";
                    txtOriginal.Text = "";
                    txtTotalAmount.Text = "";
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while reading new entry fields. " + ex.Message);
            }
        }

        private void BuildGridView(List<InsertGroceries> groceries, DataTable table)
        {
            table.Columns.Add("Category");
            table.Columns.Add("Item Description");
            table.Columns.Add("Per Pound Amount");
            table.Columns.Add("Total Pounds");
            table.Columns.Add("Sale Price");
            table.Columns.Add("Original Price");
            table.Columns.Add("Total Amount");

            foreach(var item in groceries)
                table.Rows.Add(item.Category, item.Description, item.PerLB, item.TotalLB, item.SalePrice, item.OriginalPrice, item.TotalAmount); 
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            double subtotal = 0.0;

            if (btnData.Text == "INSERT")
            {
                enableFields(Display.subTotal);
                txtCategory.Enabled = false;
                txtDesc.Enabled = false;
                txtPerLB.Enabled = false;
                txtTotalLB.Enabled = false;
                txtSale.Enabled = false;
                txtOriginal.Enabled = false;
                txtTotalAmount.Enabled = false;

                btnInsert.Enabled = false;
                btnData.Text = "Add New Item";

                // Calculate Subtotal
                double calcSubTotal = 0;
                foreach (var item in newGroceryList)
                {
                    calcSubTotal += item.TotalAmount;
                }
                txtSubtotal.Text = Convert.ToString(calcSubTotal);
            }
            else if (btnData.Text == "Add New Item")
            {
                disableFields(Display.subTotal);
                txtCategory.Enabled = true;
                txtDesc.Enabled = true;
                txtPerLB.Enabled = true;
                txtTotalLB.Enabled = true;
                txtSale.Enabled = true;
                txtOriginal.Enabled = true;
                txtTotalAmount.Enabled = true;

                btnInsert.Enabled = true;
                btnData.Text = "INSERT";

                foreach(var item in newGroceryList)
                    subtotal =  subtotal + item.TotalAmount;

                txtSubtotal.Text = Convert.ToString(subtotal);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (newGroceryList.Count == 0)
                MessageBox.Show("No Data Available to Save.", "Invalid Data");
            else
            {
                UpdateGrocery();
            }
        }

        private void UpdateGrocery()
        {
            BusinessLayer business = new BusinessLayer();
            string store = Convert.ToString(cmbStore.SelectedItem);
            DateTime date = Convert.ToDateTime(dtpDate.Text);
            double subtotal;
            double savings;
            double tax;
            double total;

            double.TryParse(txtSubtotal.Text, out subtotal);
            double.TryParse(txtSavings.Text, out savings);
            double.TryParse(txtTax.Text, out tax);
            double.TryParse(txtTotal.Text, out total);
            business.InsertGroceries(newGroceryList, date, store, subtotal, savings, tax, total);
            clear();
            MessageBox.Show("Grocery lists added to Database.", "Grocery Saved");

        }

        private void clear()
        {
            txtCategory.Clear();
            txtCity.Clear();
            txtDesc.Clear();
            txtOriginal.Clear();
            txtPerLB.Clear();
            txtSale.Clear();
            txtSavings.Clear();
            txtState.Clear();
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
            txtTotalAmount.Clear();
            txtTotalLB.Clear();

            dgvGrocery.ClearSelection();
        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            double sub;
            double sav;
            double tax;

            double.TryParse(txtSubtotal.Text, out sub);
            double.TryParse(txtSavings.Text, out sav);
            double.TryParse(txtTax.Text, out tax);

            txtTotal.Text = Convert.ToString((sub - sav) + tax);
        }
    }
}
