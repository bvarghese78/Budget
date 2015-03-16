using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using BJ.Common;

namespace Budget
{
    public class BusinessLayer
    {
        DateTimeMethods date = new DateTimeMethods();

        // Gets the income for the month
        public double getIncome(int month, int year)
        {
            DateTime beginningDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, 31);

            double ret = 0.0;

            Data data = new Data();
            var income = data.GetIncome(beginningDate, endDate);

            foreach (var item in income)
            {
                ret = ret + item.netPay;
            }

            return ret;
        }
    }
}
