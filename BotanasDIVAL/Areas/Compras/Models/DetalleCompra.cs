using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class DetalleCompra
    {
        public int IdDetCompra { get; set; }
        public int IdCompra { get; set; }
        public int IdIngrediente { get; set; }
        public int Cantidad { get; set; }
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float Precio { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Compra IdCompraNavigation { get; set; }
        public Ingredientes IdIngredienteNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
