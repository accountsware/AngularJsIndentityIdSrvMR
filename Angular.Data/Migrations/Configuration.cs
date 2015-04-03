
using System.Threading;
using Angular.Data.IRepository;
using Angular.Data.IServices;
using Angular.Data.Modals;
using Angular.Data.Repository;
using Microsoft.AspNet.Identity;

namespace Angular.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Angular.Data.DataContext>
    {


        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DataContext context)
        {

            



        }
    }
}
