using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ultimo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public virtual DbSet<Vehiculo> VehiculoSet { get; set; }
        public virtual DbSet<Modelo> ModeloSet { get; set; }
        public virtual DbSet<Marca> MarcaSet { get; set; }
        public virtual DbSet<Responsable> ResponsableSet { get; set; }
        public virtual DbSet<ReparacionIngreso> ReparacionIngresoSet { get; set; }
        public virtual DbSet<CostoReparacion> CostoReparacionSet { get; set; }
        public virtual DbSet<DetalleVehiculo> DetalleVehiculoSet { get; set; }
        public virtual DbSet<Defectos> DefectosSet { get; set; }
        public virtual DbSet<Partes> PartesSet { get; set; }
        public virtual DbSet<StockPartes> StockPartesSet { get; set; }
        public virtual DbSet<ReparacionEgreso> ReparacionEgresoSet { get; set; }
        public virtual DbSet<DetalleReparacion> DetalleReparacionSet { get; set; }
    }
}