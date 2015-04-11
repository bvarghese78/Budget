using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Budget
{
    public class GroceryStoreInfo
    {
        public int ID;
        public string StoreName;
        public string City;
        public string State;

        public GroceryStoreInfo(IDataReader reader)
        {
            this.ID = Convert.ToInt32(reader["ID"]);
            this.StoreName = Convert.ToString(reader["StoreName"]);
            this.City = Convert.ToString(reader["city"]);
            this.State = Convert.ToString(reader["state"]);
        }
    }
}
