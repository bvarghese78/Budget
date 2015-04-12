using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    public class InsertGroceries
    {
        //public string StoreName;
        //public DateTime ShoppingDate;
        public string Category;
        public string Description;
        public double? PerLB;
        public double? TotalLB;
        public double? SalePrice;
        public double OriginalPrice;
        public double TotalAmount;

        public InsertGroceries() { }
        public InsertGroceries(InsertGroceries value)
        {
            this.Category = value.Category;
            this.Description = value.Description;
            this.PerLB = value.PerLB;
            this.TotalLB = value.TotalLB;
            this.SalePrice = value.SalePrice;
            this.OriginalPrice = value.OriginalPrice;
            this.TotalAmount = value.TotalAmount;
        }
    }
}
