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
    
    public partial class Cattle
    {
        public Cattle()
        {
            this.Gestations = new HashSet<Gestation>();
            this.DiseaseHistories = new HashSet<DiseaseHistory>();
            this.CattleProductions = new HashSet<CattleProduction>();
        }
    
        public string IdCattle { get; set; }
        public int IdCattleType { get; set; }
        public int IdHerd { get; set; }
        public int IdStatut { get; set; }
        public int Active { get; set; }
        public int Age { get; set; }
        public Nullable<int> MalParent { get; set; }
        public Nullable<int> FemaleParent { get; set; }
        public string CalveSex { get; set; }
    
        public virtual Herd Herd { get; set; }
        public virtual HealthStatu HealthStatu { get; set; }
        public virtual CattleType CattleType { get; set; }
        public virtual ICollection<Gestation> Gestations { get; set; }
        public virtual ICollection<DiseaseHistory> DiseaseHistories { get; set; }
        public virtual ICollection<CattleProduction> CattleProductions { get; set; }
    }
}
