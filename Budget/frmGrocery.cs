using System;
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

        private void enableFields(Display value)
        {
            // Enable fields necessary for new Entries
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
                btnInsert.Visible = false;

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

                lblCategory.Visible = false;
                lblDesc.Visible = false;
                lblPerLB.Visible = false;
                lblTotalLB.Visible = false;
                lblSale.Visible = false;
                lblOriginal.Visible = false;
                lblTotalAmount.Visible = false;

                txtCategory.Visible = false;
                txtDesc.Visible = false;
                txtPerLB.Visible = false;
                txtTotalLB.Visible = false;
                txtSale.Visible = false;
                txtOriginal.Visible = false;
                txtTotalAmount.Visible = false;

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

                disableFields(Display.storeInfo);
                btnStoreLock.Text = "LOCK";
            }
        }
    }
}
