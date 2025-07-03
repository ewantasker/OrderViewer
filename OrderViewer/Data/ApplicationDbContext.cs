using Microsoft.EntityFrameworkCore;
using OrderViewer.Models;

namespace OrderViewer.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .Property(o => o.Total)
                .HasPrecision(18, 2);

            var statuses = new[] { "Pending", "Processing", "Shipped", "Cancelled" };
            var orders = new List<Order>();

            for (int i = 1; i <= 50; i++)
            {
                var createdDate = new DateTime(2024, 1, 1).AddDays(i); // Fixed range of dates
                var status = statuses[i % statuses.Length];
                var total = 100 + (i * 2); // Simple, repeatable logic
                var paid = i % 2 == 0; // Even = paid

                orders.Add(new Order
                {
                    Id = i,
                    Customer = $"Customer {i}",
                    Status = status,
                    CreatedDate = createdDate,
                    Total = total,
                    Paid = paid
                });
            }

            modelBuilder.Entity<Order>().HasData(orders);
        }
    }
}
