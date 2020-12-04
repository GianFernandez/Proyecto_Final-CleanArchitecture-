using App.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace App.Infrastructure.Datos
{
    public partial class DataContext : IdentityDbContext<Entrega>
    {
        public virtual DbSet<Entrega> asignatura { get; set; }
        public virtual DbSet<Proveedor> docente { get; set; }
        public virtual DbSet<Producto> estudiante { get; set; }

        private const string conection = "server=localhost;port=3306;database=app_db;user=root;password=";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                 * To protect potentially sensitive information in your connection string, you should move it out of source code. 
                 * See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                 */

                optionsBuilder.UseMySql(conection);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}