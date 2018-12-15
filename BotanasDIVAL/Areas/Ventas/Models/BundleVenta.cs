using BotanasDIVAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanasDIVAL.Areas.Ventas.Models
{
    public class BundleVenta
    {
        public Venta Venta { get; set; }
        public DetalleVenta DetalleVenta { get; set; }
    }
}
