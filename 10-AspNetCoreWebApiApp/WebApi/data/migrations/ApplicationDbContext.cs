using Microsoft.EntityFrameworkCore;
using WebApi.Models;

//put the class insise a name space
namespace WebApi.Data
{
    //Extend from DbContext
    public class ApplicationDbContext: DbContext
    {
        //put the DBSet for the Books
        public DbSet<Book> Books {get; set;}

        //create constructor to load options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //create OnModelCreating and pass in the builder 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Books");
        }
    }
}