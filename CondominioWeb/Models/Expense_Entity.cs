using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Expense_Entity
    {
        private int expense_entity_id;
        private string expense_entity_name;

        public int Expense_Entity_Id
        {
            get { return this.expense_entity_id; }
            set { this.expense_entity_id = value; }
        }

        public string Expense_Entity_Name
        {
            get { return this.expense_entity_name; }
            set { this.expense_entity_name = value; }
        }
    }
}