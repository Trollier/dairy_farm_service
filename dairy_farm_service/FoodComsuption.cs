//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dairy_farm_service
{
    using System;
    using System.Collections.Generic;
    
    public partial class FoodComsuption
    {
        public int IdFood { get; set; }
        public int IdHerd { get; set; }
        public System.DateTime DateCons { get; set; }
        public System.DateTime HourCons { get; set; }
        public double QuantityCons { get; set; }
    
        public virtual FoodStock FoodStock { get; set; }
        public virtual Herd Herd { get; set; }
    }
}
