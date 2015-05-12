using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ultimo.Models
{
    //Clase hecha para que la vista pueda recibir bien que datos tiene explicitamente
    //O sea con esto se que datos tiene la variable que me manda el controlador a la vista
    //O sea en Model tendre |Patente|modelo|marca|color|
    public class ReporteViewModel
    {
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
                                    
    }

   
}