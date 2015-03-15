using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    class Pepe
    {
        decimal food;
        decimal snacks;
        decimal litter;
        decimal misc;
        decimal total;

        public Pepe()
        {

        }

        public Pepe(decimal food, decimal snacks, decimal litter, decimal misc, decimal total)
        {
            this.food = food;
            this.snacks = snacks;
            this.litter = litter;
            this.misc = misc;
            this.total = total;
        }
    }
}
