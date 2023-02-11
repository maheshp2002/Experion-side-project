namespace ESConsoleApp.Data
{
    internal class ApplicationDbContext : DbContext
    {
        private readonly string _connStr = @"Server=MAHESHP\SQLEXPRESS;Database=EfCoreApp;Integrated Security=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connStr);
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
