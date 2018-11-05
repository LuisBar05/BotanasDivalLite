using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string CodProducto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Productos CodProductoNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
