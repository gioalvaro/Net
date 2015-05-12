//------------------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    
    public partial class Responsable
    {
        public Responsable()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string FechaAsignacion { get; set; }
    
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
    }

