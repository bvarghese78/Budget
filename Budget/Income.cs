using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Budget
{
    class Income
    {
        public int id;
        public double grossPay;
        public double netPay;
        public string description;
        public DateTime payDate;
        public double fedTax;
        public double ssTax;
        public double medTax;
        public double stateTax;

        public Income(IDataReader reader)
        {
            this.id = Convert.ToInt32(reader["ID"]);
            this.grossPay = Convert.ToDouble(reader["GrossPay"]);
            this.netPay = Convert.ToDouble(reader["Netpay"]);
            this.description = Convert.ToString(reader["Description"]);
            this.payDate = Convert.ToDateTime(reader["PayDate"]);
            this.fedTax = reader["FederalTax"] is DBNull ? 0 : Convert.ToDouble(reader["FederalTax"]);
            this.ssTax = reader["SocialSecurityTax"] is DBNull ? 0 : Convert.ToDouble(reader["SocialSecurityTax"]);
            this.medTax = reader["MedicareTax"] is DBNull ? 0 :Convert.ToDouble(reader["MedicareTax"]);
            this.stateTax = reader["StateTax"] is DBNull ? 0 : Convert.ToDouble(reader["StateTax"]);
        }
    }
}
