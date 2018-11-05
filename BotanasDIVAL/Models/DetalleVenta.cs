using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class DetalleVenta
    {
        public int IdDetVenta { get; set; }
        public int IdVenta { get; set; }
        public string CodProducto { get; set; }
        public int Cantidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Productos CodProductoNavigation { get; set; }
        public Ventas IdVentaNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
