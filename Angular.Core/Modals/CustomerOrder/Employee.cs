using System;
using System.Collections.Generic;
using Angular.Core.Modals.Base;

namespace Angular.Core.Modals.CustomerOrder
{
    public partial class Employee : Entity
    {
        public Employee()
        {
            EmployeeID = Guid.NewGuid();
            this.Orders = new List<Order>();
            this.Territories = new List<Territory>();
        }

        public Guid EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public Nullable<int> ReportsTo { get; set; }
        public string PhotoPath { get; set; }
        public virtual ICollection<Employee> Employees1 { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
