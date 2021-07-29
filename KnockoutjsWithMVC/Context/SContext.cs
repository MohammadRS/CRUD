using KnockoutjsWithMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace KnockoutjsWithMVC.Context
{
    public class SContext : DbContext
    {
        public SContext(DbContextOptions<SContext> options) : base(options)
        {

        }

        public DbSet<Student> students { get; set; }
    }
}
