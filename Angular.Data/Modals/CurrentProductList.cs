using System;
using System.Collections.Generic;
using Angular.Data.Modals.Base;


namespace Angular.Data.Modals
{
    public partial class CurrentProductList : Entity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
    }
}
