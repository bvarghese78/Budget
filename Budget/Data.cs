using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Budget
{
    class Data
    {
        MySqlConnection mysql = Helper.NewMySqlConnection();

        public List<EatingOut> GetEatingOut(string startDate, string endDate)
        {
            List<EatingOut> ret = new List<EatingOut>();
            MySqlConnection mysql = Helper.NewMySqlConnection();
            mysql.Open();

            var command = mysql.CreateCommand();
            command.CommandText = "select * from eatingout where Date BETWEEN @d AND @e;";
            command.Parameters.AddWithValue("d", startDate);
            command.Parameters.AddWithValue("e", endDate);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                ret.Add(new EatingOut(reader));
            }
            reader.Close();
            return ret;
        }

        public List<Income> GetIncome(string startDate, string endDate)
        {
            List<Income> ret = new List<Income>();

            mysql.Open();
            var command = mysql.CreateCommand();
            command.CommandText = "select * from income where paydate between @b AND @e";
            command.Parameters.AddWithValue("@b", startDate);
            command.Parameters.AddWithValue("@e", endDate);

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ret.Add(new Income(reader));
            }

            return ret;
        }

        public List<GroceryStoreInfo> GetGroceryStores()
        {
            List<GroceryStoreInfo> ret = new List<GroceryStoreInfo>();

            mysql.Open();
            var command = mysql.CreateCommand();
            command.CommandText = "select * from grocery";
            
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                ret.Add(new GroceryStoreInfo(reader));
            }
           
            return ret;
        }

        public void InsertGroceries(string cat, string desc, double? perPound, double? totalPounds, double? salePrice, double originalPrice, double totalPrice, DateTime shopDate, int storeid, int tripID)
        {
            mysql.Open();

            var command = mysql.CreateCommand();
            command.CommandText = "insert into monthly_grocery_info (groceryid, shoppingdate, grocerytripid, category, itemdescription, perpoundamount, totalpounds, saleprice, originalprice, totalamount) values (@g, @sd, @gt, @c, @id, @ppa, @tp, @sp, @op, @ta)";
            command.Parameters.AddWithValue("@g", storeid);
            command.Parameters.AddWithValue("@sd", shopDate);
            command.Parameters.AddWithValue("@gt", tripID);
            command.Parameters.AddWithValue("@c", cat);
            command.Parameters.AddWithValue("@id", desc);
            command.Parameters.AddWithValue("@ppa", perPound);
            command.Parameters.AddWithValue("@tp", totalPounds);
            command.Parameters.AddWithValue("@sp", salePrice);
            command.Parameters.AddWithValue("@op", originalPrice);
            command.Parameters.AddWithValue("@ta", totalPrice);

            command.ExecuteNonQuery();

            mysql.Close();
        }

        public void InsertGroceryTotal(int tripID, double subtotal, double savings, double tax, double total)
        {
            mysql.Open();

            var command = mysql.CreateCommand();
            command.CommandText = "insert into monthly_grocery_total (grocerytripid, subtotal, savings, tax, total) values (@gti, @st, @s, @tx, @ttl)";
            command.Parameters.AddWithValue("@gti", tripID);
            command.Parameters.AddWithValue("@st", subtotal);
            command.Parameters.AddWithValue("@s", savings);
            command.Parameters.AddWithValue("@tx", tax);
            command.Parameters.AddWithValue("@ttl", total);

            command.ExecuteNonQuery();
            
            mysql.Close();
        }

        // Gets the last 'grocerytripid' from monthly_grocery_info table
        public int GetLastGroceryTripID()
        {
            int ret;
            mysql.Open();
            var command = mysql.CreateCommand();
            command.CommandText = "select MAX(grocerytripid) as grocerytripid from monthly_grocery_info";
            
            var reader = command.ExecuteReader();
            reader.Read();

            ret = Convert.ToInt32(reader[0]);
            
            mysql.Close();

            return ret; 
        }

        // Gets the store id for grocery stores
        public int GetStoreID(string store)
        {
            int ret;

            mysql.Open();
            var command = mysql.CreateCommand();
            command.CommandText = "select id from grocery where storename=@s";
            command.Parameters.AddWithValue("@s", store);

            var reader = command.ExecuteReader();
            reader.Read();
            ret = Convert.ToInt32(reader[0]);

            mysql.Close();
            return ret;
        }
    }
}
