using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class DetalleVenta
    {
        public int IdDetVenta { get; set; }
        public int IdVenta { get; set; }
        public string CodProducto { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public int Cantidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Productos CodProductoNavigation { get; set; }
        public Venta IdVentaNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
