//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Boodschapp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aankoop
    {
        public int id { get; set; }
        public int User_id { get; set; }
        public string product_name { get; set; }
        public double price { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    
        public virtual User User { get; set; }
    }
}
