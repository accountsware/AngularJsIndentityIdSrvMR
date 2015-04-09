using System;
using System.Collections.Generic;
using AngularJs.Core.Modals.Base;


namespace AngularJs.Core.Modals
{
    public partial class SalesTotalsByAmount : Entity
    {
        public Nullable<decimal> SaleAmount { get; set; }
        public int OrderID { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}
