


using System.Collections.Generic;
using Angular.Core.Modals;
using Angular.Core.Modals.Base;
using Angular.Data.Context;

namespace Angular.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularContext>
    {


        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(AngularContext context)
        {

            var customers = new List<Customer>();



            var cust1 = new Customer()
            {
                CompanyName = "Company1",
                ContactTitle = "ContactTitle1",
                Country = "Country1",
                Fax = "Fax1"
            };
            cust1.ObjectState= ObjectState.Added;
            customers.Add(cust1);

            var cust2 = new Customer()
            {
                CompanyName = "Company2",
                ContactTitle = "ContactTitle2",
                Country = "Country2",
                Fax = "Fax2"
            };

            cust2.ObjectState = ObjectState.Added;

            customers.Add (cust2)
            ;
            var cust3 = new Customer()
            {
                CompanyName = "Company3",
                ContactTitle = "ContactTitle3",
                Country = "Country3",
                Fax = "Fax3"
            };
            cust3.ObjectState = ObjectState.Added;
            customers.Add(cust3);

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }


            


        }
    }

