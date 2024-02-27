using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2
{
    public  class Expense
    {
        public string Category { get; set; }
        public int Amount { get; set; }
        public string Date { get; set; }

        public bool AddExpense(string cate,int amt,string date)
        {
            Category = cate;
            Amount = amt;
            Date = date;

            return true;
        }

        public bool EditExpense(string cate, int amt, string date)
        {
            Category = cate;
            Amount = amt;
            Date = date;

            return true;
        }
    }
}
