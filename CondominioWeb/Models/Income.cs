using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Income
    {
        //private int income_id;
        private decimal amount;
        private int income_concept_id;
        private int property_id;
        private int period_id;
        private DateTime entry_date = DateTime.Now;

        //public int Income_Id
        //{
        //    get { return this.income_id; }
        //    set { this.income_id = value; }
        //}

        public decimal Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }

        public int Income_Concept_Id
        {
            get { return this.income_concept_id; }
            set { this.income_concept_id = value; }
        }

        public int Property_Id
        {
            get { return this.property_id; }
            set { this.property_id = value; }
        }

        public int Period_Id
        {
            get { return this.period_id; }
            set { this.period_id = value; }
        }

        public DateTime Entry_Date
        {
            get { return this.entry_date; }
            set { this.entry_date = value; }
        }
    }
}