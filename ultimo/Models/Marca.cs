
    using System;
    using System.Collections.Generic;
    
    public partial class Marca
    {
        public Marca()
        {
            this.Modelo = new HashSet<Modelo>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Modelo> Modelo { get; set; }
    }

