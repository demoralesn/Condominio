using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CondominioWeb.Models
{
    public class MonthState
    {
        private int month_state_id;
        private string period_desc;
        private DateTime generation_date;
        private int total_records;
        private decimal total_expenses;
        private decimal total_incomes;
        private decimal total_net;

        public int Month_State_Id
        {
            get { return this.month_state_id; }
            set { this.month_state_id = value; }
        }

        public string Period_Desc
        {
            get { return this.period_desc; }
            set { this.period_desc = value; }
        }

        public DateTime Generation_Date
        {
            get { return this.generation_date; }
            set { this.generation_date = value; }
        }

        public int Total_Records
        {
            get { return this.total_records; }
            set { this.total_records = value; }
        }

        public decimal Total_Expenses
        {
            get { return this.total_expenses; }
            set { this.total_expenses = value; }
        }

        public decimal Total_Incomes
        {
            get { return this.total_incomes; }
            set { this.total_incomes = value; }
        }

        public decimal Total_Net
        {
            get { return this.total_net; }
            set { this.total_net = value; }
        }
    }
}