using System;
using System.Data.Entity;
using System.Reflection;
using AngularJs.Core.Modals;

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

        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }
        public IDbSet<Person> Persons { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Territory> Territories { get; set; }
        public DbSet<Alphabetical_list_of_product> Alphabetical_list_of_products { get; set; }
        public DbSet<AlphabeticalListOfProduct> AlphabeticalListOfProducts { get; set; }
        public DbSet<Current_Product_List> Current_Product_Lists { get; set; }
        public DbSet<CurrentProductList> CurrentProductLists { get; set; }
        public DbSet<Customer_and_Suppliers_by_City> Customer_and_Suppliers_by_Cities { get; set; }
        public DbSet<CustomerAndSuppliersByCity> CustomerAndSuppliersByCities { get; set; }
        public DbSet<OrderDetailsExtended> OrderDetailsExtendeds { get; set; }
        public DbSet<Orders_Qry> Orders_Qries { get; set; }
        public DbSet<OrdersQry> OrdersQries { get; set; }
        public DbSet<OrderSubtotal> OrderSubtotals { get; set; }
        public DbSet<Products_Above_Average_Price> Products_Above_Average_Prices { get; set; }
        public DbSet<Products_by_Category> Products_by_Categories { get; set; }
        public DbSet<ProductsAboveAveragePrice> ProductsAboveAveragePrices { get; set; }
        public DbSet<ProductSalesFor1997> ProductSalesFor1997 { get; set; }
        public DbSet<ProductsByCategory> ProductsByCategories { get; set; }
        public DbSet<SalesTotalsByAmount> SalesTotalsByAmounts { get; set; }
        public DbSet<SummaryOfSalesByQuarter> SummaryOfSalesByQuarters { get; set; }
        public DbSet<SummaryOfSalesByYear> SummaryOfSalesByYears { get; set; }
        

        public AngularContext()

            : base("data source=.;initial catalog=Angular;integrated security=True")

        {
            _disposed = false;

            // Debug -- count instances

            //         instances++;
            //         Debug.WriteLine(instances);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(AngularContext)));
            
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //modelBuilder.Configurations.Add(new UserMap());

            //modelBuilder.Configurations.Add(new RoleMap());

            //modelBuilder.Configurations.Add(new UserRoleMap());
            //modelBuilder.Configurations.Add(new UserLoginMap());
            //modelBuilder.Configurations.Add(new CategoryMap());
            //modelBuilder.Configurations.Add(new CustomerDemographicMap());
            //modelBuilder.Configurations.Add(new CustomerMap());
            //modelBuilder.Configurations.Add(new EmployeeMap());
            //modelBuilder.Configurations.Add(new OrderDetailMap());
            //modelBuilder.Configurations.Add(new OrderMap());
            //modelBuilder.Configurations.Add(new ProductMap());
            //modelBuilder.Configurations.Add(new RegionMap());
            //modelBuilder.Configurations.Add(new ShipperMap());
            //modelBuilder.Configurations.Add(new SupplierMap());
            //modelBuilder.Configurations.Add(new sysdiagramMap());
            //modelBuilder.Configurations.Add(new TerritoryMap());
            //modelBuilder.Configurations.Add(new Alphabetical_list_of_productMap());
            //modelBuilder.Configurations.Add(new AlphabeticalListOfProductMap());
            //modelBuilder.Configurations.Add(new Current_Product_ListMap());
            //modelBuilder.Configurations.Add(new CurrentProductListMap());
            //modelBuilder.Configurations.Add(new Customer_and_Suppliers_by_CityMap());
            //modelBuilder.Configurations.Add(new CustomerAndSuppliersByCityMap());
            //modelBuilder.Configurations.Add(new OrderDetailsExtendedMap());
            //modelBuilder.Configurations.Add(new Orders_QryMap());
            //modelBuilder.Configurations.Add(new OrdersQryMap());
            //modelBuilder.Configurations.Add(new OrderSubtotalMap());
            //modelBuilder.Configurations.Add(new Products_Above_Average_PriceMap());
            //modelBuilder.Configurations.Add(new Products_by_CategoryMap());
            //modelBuilder.Configurations.Add(new ProductsAboveAveragePriceMap());
            //modelBuilder.Configurations.Add(new ProductSalesFor1997Map());
            //modelBuilder.Configurations.Add(new ProductsByCategoryMap());
            //modelBuilder.Configurations.Add(new SalesTotalsByAmountMap());
            //modelBuilder.Configurations.Add(new SummaryOfSalesByQuarterMap());
            //modelBuilder.Configurations.Add(new SummaryOfSalesByYearMap());
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }
        protected override void Dispose(bool disposing)
        {
            _disposed = true;
            this.Dispose(true);
           
        }
    }
}
