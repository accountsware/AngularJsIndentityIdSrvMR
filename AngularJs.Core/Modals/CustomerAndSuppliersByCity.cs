using System;
using System.Collections.Generic;
using AngularJs.Core.Modals.Base;


namespace AngularJs.Core.Modals
{
    public partial class CustomerAndSuppliersByCity : Entity
    {
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
