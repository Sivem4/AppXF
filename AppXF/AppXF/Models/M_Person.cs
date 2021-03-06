﻿using SQLite;

namespace AppXF.Models
{
    /// <summary>
    /// Person model class
    /// </summary>
    public class M_Person
    {
        public M_Person()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
