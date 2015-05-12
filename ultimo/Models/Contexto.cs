using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace ultimo.Models
{
    
    
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
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
