using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Budget
{
   public static class Helper
    {
       public const string CONNECTION_STRING = "Server=localhost; Database=budget_schema; Uid=root; Pooling=True;";

       public static MySqlConnection NewMySqlConnection()
       {
           return new MySqlConnection(ConnectionString);
       }

       public static string ConnectionString
       {
           get
           {
               var configSetting = ConfigurationManager.ConnectionStrings["budget_schema"];
               if(configSetting != null && !string.IsNullOrEmpty(configSetting.ConnectionString))
                   return configSetting.ConnectionString;
               else return CONNECTION_STRING;
           }
       }
    }
}
