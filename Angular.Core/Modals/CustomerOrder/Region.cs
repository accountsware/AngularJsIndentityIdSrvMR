using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;


namespace Angular.Core.Modals
{
    public partial class Region : Entity
    {
        public Region()
        {
            RegionID = Guid.NewGuid();
            this.Territories = new List<Territory>();
        }

        public Guid RegionID { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
