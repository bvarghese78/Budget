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
    }
}
