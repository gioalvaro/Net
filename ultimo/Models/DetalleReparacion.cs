//------------------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    
    public partial class DetalleReparacion
    {
        public int Id { get; set; }
        public string Cantidad { get; set; }
        public int ReparacionEgresoId { get; set; }
        public int CostoReparacionId { get; set; }
        public string Subtotal { get; set; }
    
        public virtual ReparacionEgreso ReparacionEgreso { get; set; }
        public virtual CostoReparacion CostoReparacion { get; set; }
    }

