
    using System;
    using System.Collections.Generic;
    
    public partial class ReparacionEgreso
    {
        public ReparacionEgreso()
        {
            this.ReparacionCosto = new HashSet<DetalleReparacion>();
            this.ReparacionIngreso = new HashSet<ReparacionIngreso>();
        }
    
        public int Id { get; set; }
        public System.DateTime FechaEgreso { get; set; }
        public string Observacion { get; set; }
    
        public virtual ICollection<DetalleReparacion> ReparacionCosto { get; set; }
        public virtual ICollection<ReparacionIngreso> ReparacionIngreso { get; set; }
    }

