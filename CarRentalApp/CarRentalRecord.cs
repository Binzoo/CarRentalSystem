//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class CarRentalRecord
    {
        public int id { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> DateRented { get; set; }
        public Nullable<System.DateTime> DateReturn { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<int> TypeOfCardId { get; set; }
    
        public virtual TypesOfCar TypesOfCar { get; set; }
    }
}
