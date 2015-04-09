using System;
using System.Collections.Generic;
using AngularJs.Core.Modals.Base;


namespace AngularJs.Core.Modals
{
    public partial class OrderSubtotal : Entity
    {
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
