using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Category
    {
        public string CategoryName { get; set; }
        public Decimal Limit { get; set; }

        public void Update(string Category, Decimal Limit)
        {
            this.CategoryName = Category;
            this.Limit = Limit;
        }
    }
}
