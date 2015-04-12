using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BJ.Common;
using System.Data;

namespace Budget
{
    public class BusinessLayer
    {
        DateTimeMethods date = new DateTimeMethods();

        // Gets the income for the month
        public double getIncome(string startDate, string endDate, DataTable table)
        {
            DataRow row = table.NewRow();
            double ret = 0.0;

            table.Columns.Add("Gross Pay");
            table.Columns.Add("Net Pay");
            table.Columns.Add("Description");
            table.Columns.Add("Pay Date");
            table.Columns.Add("Federal Tax");
            table.Columns.Add("Social Security Tax");
            table.Columns.Add("Medicare Tax");
            table.Columns.Add("State Tax");

            Data data = new Data();
            var income = data.GetIncome(startDate, endDate);

            foreach (var item in income)
            {
                ret = ret + item.netPay;
                table.Rows.Add(item.grossPay, item.netPay, item.description, date.ConvertToShortDateString(item.payDate), item.fedTax, item.ssTax, item.medTax, item.stateTax);   
            }

            return ret;
        }

        // Gets the Eating out value
        public double getEatingOut(string startDate, string endDate, DataTable table)
        {
            DataRow row = table.NewRow();
            double ret = 0.0;

            table.Columns.Add("ID");
            table.Columns.Add("Restaurant");
            table.Columns.Add("Item 1");
            table.Columns.Add("Item 2");
            table.Columns.Add("Item 3");
            table.Columns.Add("Item 4");
            table.Columns.Add("Date");
            table.Columns.Add("Total Amount");

            Data data = new Data();
            var eatingOut = data.GetEatingOut(startDate, endDate);

            foreach (var item in eatingOut)
            {
                ret += item.price;
                table.Rows.Add(item.id, item.restaurant, item.item1, item.item2, item.item3, item.item4, date.ConvertToShortDateString(item.date), item.price);
            }

            return ret;
        }

        public List<GroceryStoreInfo> getGroceryStores()
        {
            List<GroceryStoreInfo> ret = new List<GroceryStoreInfo>();

            Data data = new Data();
            ret = data.GetGroceryStores();

            return ret;
        }

        public void InsertGroceries(List<InsertGroceries> list, DateTime shopDate, string storeName, double subtotal, double savings, double tax, double total)
        {
            Data data = new Data();

            int previousTrip = data.GetLastGroceryTripID();
            int storeID = data.GetStoreID(storeName);

            foreach (var item in list)
               data.InsertGroceries(item.Category, item.Description, item.PerLB, item.TotalLB, item.SalePrice, item.OriginalPrice, item.TotalAmount, shopDate, storeID, previousTrip + 1);

            // Insert Total Amount
            data.InsertGroceryTotal(previousTrip + 1, subtotal, savings, tax, total);
        }
    }
}
