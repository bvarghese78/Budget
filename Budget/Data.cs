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

        public async Task InsertGroceries(string cat, string desc, double? perPound, double? totalPounds, double? salePrice, double originalPrice, double totalPrice, DateTime shopDate, string store)
        {
            await mysql.OpenAsync();

            var command = mysql.CreateCommand();
            //command.CommandText = "";
        }
    }
}
