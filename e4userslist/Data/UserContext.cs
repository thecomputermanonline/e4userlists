using System;
using Microsoft.EntityFrameworkCore;
using e4userslist.Models;
namespace e4userslist.Data
{
    public class UserContext:DbContext

    {
        public UserContext(DbContextOptions<UserContext>options):base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
