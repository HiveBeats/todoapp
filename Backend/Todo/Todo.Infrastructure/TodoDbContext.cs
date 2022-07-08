using Microsoft.EntityFrameworkCore;
using Todo.Domain.Models;
using Todo.Infrastructure.ModelBuilders;

namespace Todo.Infrastructure
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext()
        {

        }

        public TodoDbContext(DbContextOptions options) : base(options)
        {
            
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity => new UserModelBuilder(entity).Build());
            modelBuilder.Entity<TodoItem>(entity => new TodoItemModelBuilder(entity).Build());
        }
        
        public DbSet<User> Users { get; set; }
    }
}