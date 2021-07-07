using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineKrasotka.Domain.Entities;
using OnlineKrasotka.Domain.Entities.Cart;
using OnlineKrasotka.Domain.Entities.Order;
using System;

namespace OnlineKrasotka.Domain
{
    public class AppDb:IdentityDbContext<IdentityUser>
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options) { }
        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ThingItem> ThingItems { get; set; }
        public DbSet<ShopCartItem> CartItems { get; set; } 
        public DbSet<Order> OrdersThings { get; set; }
        public DbSet<OrderDetail> OrderDetailsThings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "8af10569-b018-4fe7-a380-7d6a14c70b74",
                Name = "admin",
                NormalizedName = "ADMIN"
            });
            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "12Qwaszx"),
                SecurityStamp = string.Empty
            });
            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "8af10569-b018-4fe7-a380-7d6a14c70b74",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });
            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                CodeWord = "PageIndex",
                Name = "Главная"
            });
            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                CodeWord = "PageServices",
                Name = "Наши услуги"
            });
            modelbuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                CodeWord = "PageContacts",
                Name = "Контакты"
            });
        }
    }
}
