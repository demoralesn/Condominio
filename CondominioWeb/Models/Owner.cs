using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CondominioWeb.Models
{
    public class Owner
    {
        private int owner_id;
        private int dni;
        private string dni_vr;
        private string first_name;
        private string last_name;
        private int phone;
        private int cell_phone;
        private int gender;
        private int country_origin;
        private DateTime birth_date;
        private string email;
        private int state;

        public int Owner_Id
        {
            get { return this.owner_id; }
            set { this.owner_id = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public string Dni_Vr
        {
            get { return this.dni_vr; }
            set { this.dni_vr = value; }
        }

        public string First_Name
        {
            get { return this.first_name; }
            set { this.first_name = value; }
        }

        public string Last_Name
        {
            get { return this.last_name; }
            set { this.last_name = value; }
        }

        public int Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        public int Cell_Phone
        {
            get { return this.cell_phone; }
            set { this.cell_phone = value; }
        }

        public int Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public int Country_Origin
        {
            get { return this.country_origin; }
            set { this.country_origin = value; }
        }

        public DateTime Birth_Date
        {
            get { return this.birth_date; }
            set { this.birth_date = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int State
        {
            get { return this.state; }
            set { this.state = value; }
        }

    }
}