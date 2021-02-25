using Microsoft.EntityFrameworkCore;
namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
       public TodoContext(DbContextOption<TodoContext> options)
        :base(options)
        {

        }
        public DbSet<TodoItem> TodoItems {get;set;}
    }
}