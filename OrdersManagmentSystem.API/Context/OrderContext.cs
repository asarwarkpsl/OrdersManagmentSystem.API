using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrdersManagmentSystem.API.Model;

namespace OrdersManagmentSystem.API.Context
{
    public class OrderContext: DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) 
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrdersItem { get; set; }


        public class OrderContextFactory : IDesignTimeDbContextFactory<OrderContext>
        {
            public OrderContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<OrderContext>();
                optionsBuilder.UseSqlServer();

                return new OrderContext(optionsBuilder.Options);
            }
        }
    }
}
