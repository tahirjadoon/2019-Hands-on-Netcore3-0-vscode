using Microsoft.EntityFrameworkCore;
using OneDishParty.Models;

//put the class inside a name space
namespace OneDishParty.Data
{
    //Extend from DbContext
    public class ApplicationDbContext : DbContext
    {
        //put the DbSet for the food items
        public DbSet<FoodItem> FoodItems { get; set; }
        //create constructor to load DbContext Options
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //create the onModelCreating and pass in the builder
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}