
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using OptiSourceProject.Models;

namespace OptiSourceProject.Database
{
    public class UserDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options):base(options) {
     
        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }

    }
}
