using System;
using System.Collections.Generic;
using Angular.Data.Modals.Base;


namespace Angular.Data.Modals
{
    public partial class Products_by_Category : Entity
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
