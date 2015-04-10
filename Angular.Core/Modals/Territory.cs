using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;


namespace Angular.Core.Modals
{
    public partial class Territory : Entity
    {
        public Territory()
        {
            this.Employees = new List<Employee>();
        }

        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
