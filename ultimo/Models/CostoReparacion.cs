//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    
    public partial class CostoReparacion
    {
        public CostoReparacion()
        {
            this.ReparacionCosto = new HashSet<DetalleReparacion>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int ReparacionEgresoId { get; set; }
    
        public virtual ICollection<DetalleReparacion> ReparacionCosto { get; set; }
    }

