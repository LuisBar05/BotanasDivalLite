using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Almacen
    {
        public int IdAlmacen { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int IdIngrediente { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaCaducidad { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Ingredientes IdIngredienteNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
