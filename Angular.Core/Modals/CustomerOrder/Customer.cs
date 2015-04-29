using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.CustomerOrder

{
    public partial class Customer : Entity
    {
        public Customer()
        {
            CustomerID = Guid.NewGuid();
            this.Orders = new List<Order>();

        }

        public Guid CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
 
    }
}
