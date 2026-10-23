using Microsoft.EntityFrameworkCore;
using G_NET_84_EF01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_84_EF01.DbContexts
{
    internal class AppDbContext : DbContext
    {
        #region AppDbContext
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;DataBase=ReadMoreBooksDb;Trusted_Connection=true;TrustServerCertificate=true");
        //}
        //#region DbSets
        //public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //#endregion
        #endregion
    }
}