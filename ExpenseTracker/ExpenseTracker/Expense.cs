using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Expense
    {
        public int ID;
        public string category;
        public Decimal Amount;
        public DateTime Date;

        public bool Update(string category,Decimal Amount,DateTime Date)
        {
            this.category = category;
            this.Amount = Amount;
            this.Date = Date;

            return true;
        }
    }
}
