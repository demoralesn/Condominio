using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Period
    {
        private int period_id;
        private string period_desc;
        private DateTime start_date;
        private DateTime end_date;
        private Boolean state;

        public int Period_Id
        {
            get { return this.period_id; }
            set { this.period_id = value; }
        }

        public string Period_Desc
        {
            get { return this.period_desc; }
            set { this.period_desc = value; }
        }

        public DateTime Start_Date
        {
            get { return this.start_date; }
            set { this.start_date = value; }
        }

        public DateTime End_Date
        {
            get { return this.end_date; }
            set { this.end_date = value; }
        }

        public Boolean State
        {
            get { return this.state; }
            set { this.state = value; }
        }
    }
}