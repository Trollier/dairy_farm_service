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
    
    public partial class DiseaseHistory
    {
        public string IdCattle { get; set; }
        public int IdDisease { get; set; }
        public System.DateTime StartSick { get; set; }
        public Nullable<System.DateTime> EndSick { get; set; }
        public Nullable<bool> VeterinaryVisit { get; set; }
    
        public virtual Cattle Cattle { get; set; }
        public virtual Disease Disease { get; set; }
    }
}
