using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class DetalleCompra
    {
        public int IdDetCompra { get; set; }
        public int IdCompra { get; set; }
        [Required(ErrorMessage = "El campo Ingrediente es requerido")]
        public int IdIngrediente { get; set; }
        [Required(ErrorMessage = "El campo Cantidad es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El campo Precio de Compra es requerido")]
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float Precio { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Compra IdCompraNavigation { get; set; }
        public Ingredientes IdIngredienteNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
