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
        public double getIncome(int month, int year, DataTable table)
        {
            DateTime beginningDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, 31);
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
            var income = data.GetIncome(beginningDate, endDate);

            foreach (var item in income)
            {
                ret = ret + item.netPay;
                table.Rows.Add(item.grossPay, item.netPay, item.description, date.ConvertToShortDateString(item.payDate), item.fedTax, item.ssTax, item.medTax, item.stateTax);   
            }

            return ret;
        }
    }
}
