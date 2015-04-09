using System;
using System.Collections.Generic;
using AngularJs.Core.Modals.Base;


namespace AngularJs.Core.Modals
{
    public partial class SummaryOfSalesByYear : Entity
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
