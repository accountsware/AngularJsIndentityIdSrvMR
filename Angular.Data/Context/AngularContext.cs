﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using Angular.Data.Mappings;
using Angular.Core.Modals;

namespace Angular.Data.Context
{
    public class AngularContext : DataContext
    {
        //  private static int instances = 0;

        //public static int GetActiveInstances()
        //{
        //    return instances;
        //}
        private bool _disposed;

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Person> Persons { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Region> Regions { get; set; }
        //public DbSet<Shipper> Shippers { get; set; }
        //public DbSet<Supplier> Suppliers { get; set; }
        //public DbSet<sysdiagram> sysdiagrams { get; set; }
        //public DbSet<Territory> Territories { get; set; }
        //public DbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
        //public DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        //public DbSet<Current_Product_List> Current_Product_Lists { get; set; }
        //public DbSet<CurrentProductList> CurrentProductLists { get; set; }
        //public DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; }
        //public DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        //public DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        //public DbSet<Orders_Qry> Orders_Qries { get; set; }
        //public DbSet<OrdersQry> OrdersQries { get; set; }
        //public DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        //public DbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; }
        //public DbSet<Products_by_Category> Products_by_Categories { get; set; }
        //public DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        //public DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; }
        //public DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        //public DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        //public DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        //public DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }


        public AngularContext()

            : base("data source=.;initial catalog=Angular;integrated security=True")

        {


            // Debug -- count instances

            //         instances++;
            //         Debug.WriteLine(instances);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new UserRoleMap());
            modelBuilder.Configurations.Add(new UserLoginMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new RegionMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new TerritoryMap());

        }


    }
}
