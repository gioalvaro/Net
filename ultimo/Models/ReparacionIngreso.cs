//------------------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    
    public partial class ReparacionIngreso
    {
        public ReparacionIngreso()
        {
            this.Defectos = new List<Defectos>();
            
        }
    
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public string Observacion { get; set; }
        //public int DefectosId { get; set; }
        public int ReparacionEgresoId { get; set; }
        public List<short> NumSerie { get; set; }
        //public int ResponsableId { get; set; }
    
        public virtual List<Defectos> Defectos { get; set; }
        public virtual ReparacionEgreso ReparacionEgreso { get; set; }
    }

