using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Vivero.Migrations;

namespace Vivero.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("name=DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>("DefaultConnection"));
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<CategoriaViewModels> categoriaViewModels { get; set; }
        public DbSet<ClienteViewModels> clienteViewModels { get; set; }
        public DbSet<DetalleViewModels> detalleViewModels { get; set; }
        public DbSet<DomicilioViewModels> domicilioViewModels { get; set; }
        public DbSet<FacturaViewModels> facturaViewModels { get; set; }
        public DbSet<LocalidadViewModels> localidadViewModels { get; set; }
        public DbSet<LocalViewModels> localViewModels { get; set; }
        public DbSet<ProductoViewModels> productoViewModels { get; set; }
        public DbSet<ProvinciaViewModels> provinciaViewModels { get; set; }
        public DbSet<TipoDeDocumentoViewModels> tipoDeDocumentoViewModels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}