using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Budget
{
    public class CreditCards
    {
        public int id;
        public string cardIssuer;
        public double creditLimit;
        public double interestRate;

        public CreditCards(IDataReader reader)
        {
            this.id = Convert.ToInt32(reader["ID"]);
            this.cardIssuer = Convert.ToString(reader["CardIssuer"]);
            this.creditLimit = Convert.ToDouble(reader["CreditLimit"]);
            this.interestRate = Convert.ToDouble(reader["InterestRate"]);
        }
    }
}
