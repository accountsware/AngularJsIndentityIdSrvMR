using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.CustomerOrder
{
    public partial class Supplier : Entity
    {
        public Supplier()
        {
            SupplierID = Guid.NewGuid();
            this.Products = new List<Product>();
        }

        public Guid SupplierID { get; set; }
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
        public string HomePage { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
