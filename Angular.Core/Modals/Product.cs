using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;


namespace Angular.Core.Modals
{
    public partial class Product : Entity
    {
        public Product()
        {
            ProductID = Guid.NewGuid();
            this.OrderDetails = new List<OrderDetail>();
        }

        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<Guid> SupplierID { get; set; }
        public Nullable<Guid> CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
