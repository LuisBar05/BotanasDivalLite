using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class DetalleCompra
    {
        public int IdDetCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdIngrediente { get; set; }
        public float Cantidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Compras IdCompraNavigation { get; set; }
        public Ingredientes IdIngredienteNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
