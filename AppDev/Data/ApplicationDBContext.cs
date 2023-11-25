using AppDev.Models;
using Microsoft.EntityFrameworkCore;


namespace AppDev.Data
{
    public class ApplicationDBContext : DbContext
    {
		public DbSet<Category> Categories { get; set; }
		public DbSet<Book> Books { get; set; }
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Horror", Description = "So scary", DisplayOrder = 2 },
                new Category { Id = 2, Name = "Action", Description = "Hello", DisplayOrder = 3 },
                new Category { Id = 3, Name = "Roman", Description = "A lot of roman stories", DisplayOrder = 1 },
                new Category { Id = 4, Name = "Science", Description = "So difficult", DisplayOrder = 4 }
            );
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "C# Programming",
                    Description = "BTEC",
                    Author = "Microsoft",
					Price = 11,
                    CategoryId = 2
                },
				new Book
				{
					Id = 2,
					Title = "Advanced Programming",
					Description = "Enhancing",
					Author = "BTEC",
					Price = 14,
					CategoryId = 2
				},
				new Book
				{
					Id = 3,
					Title = "Data Structures",
					Description = "Not easy",
					Author = "Greenwich",
					Price = 15,
					CategoryId = 3
				},
				new Book
				{
					Id = 4,
					Title = "App Dev",
					Description = "Full Application",
					Author = "Microsoft",
					Price = 20,
					CategoryId = 4
				}
				);
		}
	}
}