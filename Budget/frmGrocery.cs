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
                }
            }
        }
    }
}
