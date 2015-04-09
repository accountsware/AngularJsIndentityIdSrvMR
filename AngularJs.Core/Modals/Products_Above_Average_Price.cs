using System;
using System.Collections.Generic;
using AngularJs.Core.Modals.Base;


namespace AngularJs.Core.Modals
{
    public partial class Products_Above_Average_Price : Entity
    {
        public string ProductName { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
