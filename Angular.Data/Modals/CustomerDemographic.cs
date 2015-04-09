using System;
using System.Collections.Generic;
using Angular.Data.Modals.Base;


namespace Angular.Data.Modals
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
