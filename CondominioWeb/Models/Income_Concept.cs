using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Income_Concept
    {
        private int income_concept_id;
        private string income_concept_desc;

        public int Income_Concept_Id
        {
            get { return this.income_concept_id; }
            set { this.income_concept_id = value; }
        }

        public string Income_Concept_Desc
        {
            get { return this.income_concept_desc; }
            set { this.income_concept_desc = value; }
        }
    }
}