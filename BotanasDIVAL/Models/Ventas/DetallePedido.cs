using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class DetallePedido
    {
        public int IdDetPedido { get; set; }
        public int IdPedido { get; set; }
        public string CodProducto { get; set; }
        public int Cantidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Productos CodProductoNavigation { get; set; }
        public Pedidos IdPedidoNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
