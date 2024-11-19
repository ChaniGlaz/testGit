using lesson2.Models;
using Microsoft.EntityFrameworkCore;

namespace lesson2.Repositories
{

    public class TasksDbContext:DbContext


    {

        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
        {

        }

        public async Task<List<Tasks>> GetTasksByUserAsync(int UserId)
        {
            return await Tasks.FromSqlRaw("EXEC  GetTasksByUser @UserId = {0}", UserId).ToListAsync();
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Tasks>()
        //        .HasOne(b => b.User)
        //        .WithMany(a => a.tasks)
        //        .HasForeignKey(b => b.UserId);

        //    modelBuilder.Entity<Tasks>()
        //        .HasOne(b => b.Product)
        //        .WithMany(p => p.tasks)
        //        .HasForeignKey(b => b.ProductId);

        //}

        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
