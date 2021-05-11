using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Template_NewsSite.PL.Domain.Entities;

namespace Template_NewsSite.PL.Domain.Context
{
    public class NewsSiteDbContext : IdentityDbContext<IdentityUser>
    {
        public NewsSiteDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string roleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = userId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "Fearofwar@mail.ru",
                NormalizedEmail = "FEAROFWAR@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId,
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = Guid.NewGuid(),
                CodeWord = "Main page",
                Title = "The main page"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = Guid.NewGuid(),
                CodeWord = "News page",
                Title = "All news"
            });

            builder.Entity<TextField>().HasData(new TextField
            {
                Id = Guid.NewGuid(),
                CodeWord = "Contacts page",
                Title = "Contacts"
            });
        }
    }
}
