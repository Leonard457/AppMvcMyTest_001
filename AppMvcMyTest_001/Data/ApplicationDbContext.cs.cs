// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using AppMvcMyTest_001.Models; // Убедись, что пространство имен моделей правильное

namespace AppMvcMyTest_001.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        // Добавь DbSet для каждой твоей модели (сущности)
        // public DbSet<Category> Categories { get; set; }
    }
}
