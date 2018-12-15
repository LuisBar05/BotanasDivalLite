using BotanasDIVAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanasDIVAL.Areas.Compras.Models
{
    public class BundleCompra
    {
        public Compra Compra { get; set; }
        public DetalleCompra DetalleCompra { get; set; }
    }
}
