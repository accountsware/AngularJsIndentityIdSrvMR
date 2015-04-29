using System;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.CustomerOrder
{
    public partial class OrderDetail : Entity
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
