using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class ListasIngredientes
    {
        public int IdListasIngred { get; set; }
        public int IdReceta { get; set; }
        [Required(ErrorMessage = "El campo Ingrediente es requerido")]
        public int IdIngrediente { get; set; }
        [Required(ErrorMessage = "El campo Cantidad es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "¡Sólo números enteros!")]
        public float Cantidad { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Ingredientes IdIngredienteNavigation { get; set; }
        public Recetas IdRecetaNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
