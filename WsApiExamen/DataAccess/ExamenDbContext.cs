using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WsApiExamen.Entities;

namespace WsApiExamen.DataAccess
{
    public class ExamenDbContext:DbContext
    {
        public ExamenDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Examen> Examenes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    

    }
}
