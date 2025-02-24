using Microsoft.EntityFrameworkCore;
using MyWeblog.Models;

namespace MyWeblog.Context
{
    public class MyContext :DbContext
    {     
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Content> contents { get; set; }
    }
}
