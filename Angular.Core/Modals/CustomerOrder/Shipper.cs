using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.CustomerOrder
{
    public partial class Shipper : Entity
    {
        public Shipper()
        {
            ShipperID = Guid.NewGuid();
            this.Orders = new List<Order>();
        }

        public Guid ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
