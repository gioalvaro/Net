//------------------------------------------------------------------------------

    using System;
    using System.Collections.Generic;
    
    public partial class StockPartes
    {
        public StockPartes()
        {
            this.Partes = new HashSet<Partes>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public short Cantidad { get; set; }
    
        public virtual ICollection<Partes> Partes { get; set; }
    }

