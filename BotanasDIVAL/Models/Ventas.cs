using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Ventas
    {
        public Ventas()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdVenta { get; set; }
        public float Subtotal { get; set; }
        public float Impuesto { get; set; }
        public float TotalVta { get; set; }
        public DateTime FechaVta { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
