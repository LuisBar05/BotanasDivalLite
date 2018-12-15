using BotanasDIVAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanasDIVAL.Areas.Ventas.Models
{
    public class BundlePedido
    {
        public Pedidos Pedido { get; set; }
        public DetallePedido DetallePedido { get; set; }
    }
}
