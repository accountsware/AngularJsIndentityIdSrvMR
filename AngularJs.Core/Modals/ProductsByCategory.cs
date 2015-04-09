using System;
using AngularJs.Core.Modals.Base;

namespace AngularJs.Core.Modals
{
    public partial class ProductsByCategory : Entity
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
