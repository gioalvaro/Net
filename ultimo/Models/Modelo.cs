
    using System;
    using System.Collections.Generic;
    
    public partial class Modelo
    {
        public Modelo()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }
    
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public int VehiculoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoriía { get; set; }
    
        public virtual ICollection<Vehiculo> Vehiculo { get; set; }
        public virtual Marca Marca { get; set; }
    }

