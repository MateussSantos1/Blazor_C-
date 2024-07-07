using Crud_Blazor_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Blazor_EF.Data
{


    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; } = null!;
    }
}
