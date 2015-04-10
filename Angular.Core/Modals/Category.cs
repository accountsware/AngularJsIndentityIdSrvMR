using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;


namespace Angular.Core.Modals
{
    public partial class Category : Entity
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
