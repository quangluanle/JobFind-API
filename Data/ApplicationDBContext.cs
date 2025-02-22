using JobFind_BE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace JobFind_BE.Data
{
	public class ApplicationDBContext : IdentityDbContext<AppUser>
	{
		public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{

		}
		public DbSet<Models.Post> Posts { get; set; }
		public DbSet<Models.Company> Companies { get; set; }
		public DbSet<Models.Area> Areas { get; set; }
		public DbSet<Models.FormOfWork> FormOfWorks { get; set; }
		public DbSet<Models.Category> Categories { get; set; }
		public DbSet<Models.Level> Levels { get; set; }
		public DbSet<Models.Position> Positions { get; set; }
		public DbSet<Models.Tag> Tags { get; set; }
		public DbSet<Models.Post_Tag> Post_Tag { get; set; }
		public DbSet<Models.Post_User> Post_User { get; set; }
		public DbSet<Models.Post_Level> Post_Level { get; set; }
		public DbSet<Models.Post_Position> Post_Position { get; set; }
		public DbSet<Models.User_Company> User_Company { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{

			base.OnModelCreating(builder);


			List<IdentityRole> roles = new List<IdentityRole>
			{
				new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
				new IdentityRole { Name = "User", NormalizedName = "USER" }
			};
			builder.Entity<IdentityRole>().HasData(roles);
		}
	}
}
