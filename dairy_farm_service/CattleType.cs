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
    
    public partial class CattleType
    {
        public CattleType()
        {
            this.Cattle = new HashSet<Cattle>();
            this.Herds = new HashSet<Herd>();
        }
    
        public int IdCattleType { get; set; }
        public string TypeName { get; set; }
    
        public virtual ICollection<Cattle> Cattle { get; set; }
        public virtual ICollection<Herd> Herds { get; set; }
    }
}
