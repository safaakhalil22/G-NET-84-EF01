using G_NET_84_EF01.DbContexts;

namespace G_NET_84_EF01
{
    internal class Program
    {
        #region Program
        static void Main(string[] args)
        {
            using AppDbContext dbContext = new AppDbContext();

            if (dbContext.Database.CanConnect())
            {
                Console.WriteLine("Database ReadMoreBooksDb created successfully");
                Console.WriteLine($"Books table: {dbContext.Books.Count()} rows");
                Console.WriteLine($"Authors table: {dbContext.Authors.Count()} rows");
                Console.WriteLine($"Categories table: {dbContext.Categories.Count()} rows");
            }
            else
            {
                Console.WriteLine("Database was not created");
            }
        }
        #endregion
    }
}
