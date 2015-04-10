using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;


namespace Angular.Core.Modals
{
    public partial class Region : Entity
    {
        public Region()
        {
            this.Territories = new List<Territory>();
        }

        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
