//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeWaaiBeheer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID { get; set; }
        public Nullable<int> CoursesID { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Insertion { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        public string Fullname
        {
            get { return string.Format("{0} {1} {2}", this.Firstname, this.Insertion, this.Surname); }           
        }
    }
}
