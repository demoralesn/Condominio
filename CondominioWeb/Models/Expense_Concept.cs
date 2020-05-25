using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Expense_Concept
    {
        private int expense_concept_id;
        private string expense_concept_desc;

        public int Expense_Concept_Id
        {
            get { return this.expense_concept_id; }
            set { this.expense_concept_id = value; }
        }

        public string Expense_Concept_Desc
        {
            get { return this.expense_concept_desc; }
            set { this.expense_concept_desc = value; }
        }
    }
}