//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.

    using System;
    using System.Collections.Generic;
    
    public partial class Partes
    {
        public Partes()
        {
            this.Defectos = new HashSet<Defectos>();
        }
    
        public int Id { get; set; }
        public int? VehiculoId { get; set; }
        public System.DateTime FechaCompra { get; set; }
        public System.DateTime FechaCambioEstimado { get; set; }
        public string NumSerie { get; set; }
        public int StockPartesId { get; set; }
    
        public virtual ICollection<Defectos> Defectos { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual StockPartes StockPartes { get; set; }
    }

