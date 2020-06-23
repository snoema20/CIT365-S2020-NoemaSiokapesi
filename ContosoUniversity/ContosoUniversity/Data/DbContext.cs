namespace ContosoUniversity.Data
{
    public class DbContext
    {
        private DbContextOptions<SchoolContext> options;

        public DbContext(DbContextOptions<SchoolContext> options)
        {
            this.options = options;
        }
    }
}