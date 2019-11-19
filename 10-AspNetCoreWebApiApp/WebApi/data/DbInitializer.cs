using System.Collections.Generic;
using System.Linq;
using WebApi.Models;

namespace WebApi.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
           context.Database.EnsureCreated();
           //add books
           AddBooks(context);
        }

        private static void AddBooks(ApplicationDbContext context)
        {
             //look for any books
            if(context.Books.Any())
                return;

            var books = new Book[]
            {
                new Book{Title = "Unlocking Android", Author="W. Frank Ableson", Description= "Unlocking Android: A Developer's Guide provides concise, hands-on instruction for the Android operating system and development tools. This book teaches important architectural concepts in a straightforward writing style and builds on this with practical and useful examples throughout."},
                new Book{Title = "Flex 3 in Action", Author="Gojko Adzic", Description= "New web applications require engaging user-friendly interfaces   and the cooler, the better. With Flex 3, web developers at any skill level can create high-quality, effective, and interactive Rich Internet Applications (RIAs) quickly and easily."},
                new Book{Title = "Collective Intelligence in Action", Author="Satnam Alag", Description= "There's a great deal of wisdom in a crowd, but how do you listen to a thousand people talking at once  Identifying the wants, needs, and knowledge of internet users can be like listening to a mob."}
            };

            foreach(var b in books)
            {
                context.Books.Add(b);
            }
            
            context.SaveChanges();
        }
    }
}