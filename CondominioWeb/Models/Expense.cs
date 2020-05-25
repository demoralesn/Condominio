using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Expense
    {
        //private int expense_id;
        private decimal amount;
        private int expense_entity_id;
        private int expense_concept_id;
        private DateTime entry_date = DateTime.Now;

        //public int Expense_Id
        //{
        //    get { return this.expense_id; }
        //    set { this.expense_id = value; }
        //}

        public decimal Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public int Expense_Entity_Id
        {
            get { return this.expense_entity_id; }
            set { this.expense_entity_id = value; }
        }

        public int Expense_Concept_Id
        {
            get { return this.expense_concept_id; }
            set { this.expense_concept_id = value; }
        }

        public DateTime Entry_Date
        {
            get { return this.entry_date; }
            set { this.entry_date = value; }
        }
    }
}