using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;


namespace Angular.Core.Modals
{
    public partial class Territory : Entity
    {
        public Territory()
        {
            TerritoryID = Guid.NewGuid();
            this.Employees = new List<Employee>();
        }

        public Guid TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public Guid RegionID { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
