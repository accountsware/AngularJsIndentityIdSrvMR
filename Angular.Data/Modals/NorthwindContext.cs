using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Angular.Data.Mappings;



namespace Angular.Data.Modals
{
    public partial class NorthwindContext : DataContext
    {
        static NorthwindContext()
        {
            Database.SetInitializer<NorthwindContext>(null);
        }

        public NorthwindContext()
            : base()
        {
        }        

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
