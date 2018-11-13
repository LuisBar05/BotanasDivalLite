using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            DetallePedido = new HashSet<DetallePedido>();
        }

        public int IdPedido { get; set; }
        public string Cliente { get; set; }
        public float TotalPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
