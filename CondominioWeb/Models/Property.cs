using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CondominioWeb.Models
{
    public class Property
    {
        private int property_id;
        private string property_desc;
        private string property_type;
        private string property_state_desc;

        public int Property_Id
        {
            get { return this.property_id; }
            set { this.property_id = value; }
        }

        public string Property_Desc
        {
            get { return this.property_desc; }
            set { this.property_desc = value; }
        }

        public string Property_Type
        {
            get { return this.property_type; }
            set { this.property_type = value; }
        }

        public string Property_State_Desc
        {
            get { return this.property_state_desc; }
            set { this.property_state_desc = value; }
        }
    }
}