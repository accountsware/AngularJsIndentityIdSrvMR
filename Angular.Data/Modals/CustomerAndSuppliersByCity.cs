using System;
using System.Collections.Generic;
using Angular.Data.Modals.Base;


namespace Angular.Data.Modals
{
    public partial class CustomerAndSuppliersByCity : Entity
    {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
