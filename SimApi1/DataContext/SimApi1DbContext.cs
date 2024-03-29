using Microsoft.EntityFrameworkCore;
using SimApi1.Models;

namespace SimApi1.DataContext
{
    public class SimApi1DbContext: DbContext
    {
        public SimApi1DbContext(DbContextOptions options): base(options)
        { }

       public DbSet<Component_Master> Comp_Mast {  get; set; }
       public DbSet<Component_Details> Comp_Details { get; set; }
        public DbSet<Product_Master> Prod_Mast { get; set; }
        public DbSet<Product_Details> Prod_Details { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Spares_Out_For_Production> Spares_Out_For_Production { get; set; }
        public DbSet<Staff_Production_In_Entry> Staff_Prod_In_Entry { get; set; }

    }
}
