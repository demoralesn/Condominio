using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CondominioWeb.Models
{
    public class MonthStateDetail
    {
        private string property_desc;
        private string period_desc;
        private decimal income;
        private decimal charge;
        private decimal net;

        public string Property_Desc
        {
            get { return this.property_desc; }
            set { this.property_desc = value; }
        }

        public string Period_Desc
        {
            get { return this.period_desc; }
            set { this.period_desc = value; }
        }

        public decimal Income
        {
            get { return this.income; }
            set { this.income = value; }
        }

        public decimal Charge
        {
            get { return this.charge; }
            set { this.charge = value; }
        }

        public decimal Net
        {
            get { return this.net; }
            set { this.net = value; }
        }

    }
}