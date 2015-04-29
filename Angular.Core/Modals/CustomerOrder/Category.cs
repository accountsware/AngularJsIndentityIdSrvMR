using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.CustomerOrder
{
    public partial class Category : Entity
    {
        public Category()
        {
            CategoryID = Guid.NewGuid();
            this.Products = new List<Product>();
        }

        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
