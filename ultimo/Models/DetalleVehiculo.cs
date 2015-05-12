
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVehiculo
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public System.DateTime FechaEntrada { get; set; }
        public System.DateTime FechaSalida { get; set; }
        public int HorasTrabajadas { get; set; }
        public int KilometrosRecorridos { get; set; }
    
        public virtual Vehiculo Vehiculo { get; set; }
    }

