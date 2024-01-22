
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccess.Model
{
    public class ShoppingDBContext : IdentityDbContext<IdentityUser>
    {
        public ShoppingDBContext(DbContextOptions<ShoppingDBContext> options) : base(options)  
        {              
        }       

        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<Order> Orders { get; set;}
        public DbSet<OrderDetail> OrderDetails { get; set;} 

    }
}
