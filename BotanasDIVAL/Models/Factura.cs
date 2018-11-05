using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public int IdCompra { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public ClientesFactura IdClienteNavigation { get; set; }
        public Compras IdCompraNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
