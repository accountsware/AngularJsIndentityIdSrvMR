using System;
using System.Collections.Generic;
using AngularJs.Core.Modals.Base;


namespace AngularJs.Core.Modals
{
    public partial class CustomerDemographic : Entity
    {
        public CustomerDemographic()
        {
            this.Customers = new List<Customer>();
        }

        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
