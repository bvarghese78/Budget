using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Budget
{
    class EatingOut
    {
        public int id;
        public string restaurant;
        public string item1;
        public string item2;
        public string item3;
        public string item4;
        public string item5;
        public string item6;
        public string item7;
        public DateTime date;
        public double price;

        public EatingOut(IDataReader reader)
        {
            this.id = Convert.ToInt32(reader["ID"]);
            this.restaurant = Convert.ToString(reader["restaurant"]);
            this.item1 = reader["Item#1"] is DBNull ? "" : Convert.ToString(reader["Item#1"]);
            this.item2 = reader["Item#2"] is DBNull ? "" : Convert.ToString(reader["Item#2"]);
            this.item3 = reader["Item#3"] is DBNull ? "" : Convert.ToString(reader["Item#3"]);
            this.item4 = reader["Item#4"] is DBNull ? "" : Convert.ToString(reader["Item#4"]);
            this.item5 = reader["Item#5"] is DBNull ? "" : Convert.ToString(reader["Item#5"]);
            this.item6 = reader["Item#6"] is DBNull ? "" : Convert.ToString(reader["Item#6"]);
            this.item7 = reader["Item#7"] is DBNull ? "" : Convert.ToString(reader["Item#7"]);
            this.date = Convert.ToDateTime(reader["date"]);
            this.price = Convert.ToDouble(reader["Price"]);
        }
    }
}
