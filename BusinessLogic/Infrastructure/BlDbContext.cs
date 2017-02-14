using System.Data.Entity;
using BusinessLogic.Entities;

namespace BusinessLogic.Infrastructure
{
    public class BlDbContext : DbContext
    {
        public BlDbContext()
        {
            //Database.SetInitializer<BlDbContext>(null);
            Database.SetInitializer(new CreateDatabaseIfNotExists<BlDbContext>());
        }

        public BlDbContext(string connectionString)
            : base(connectionString)
        {
            //Database.SetInitializer<BlDbContext>(null);
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlDbContext>());
            Database.SetInitializer(new CreateDatabaseIfNotExists<BlDbContext>());
        }

        public DbSet<Bot> Bots { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<EventLog> Eventlogs { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Password> Passwords { get; set; }

        public DbSet<Message> Messages { get; set; }
    }
}
