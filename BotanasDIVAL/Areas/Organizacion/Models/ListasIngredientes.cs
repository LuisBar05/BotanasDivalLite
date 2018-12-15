using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class ListasIngredientes
    {
        public int IdListasIngred { get; set; }
        public int IdReceta { get; set; }
        public int IdIngrediente { get; set; }
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "¡Sólo números enteros!")]
        public float Cantidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Ingredientes IdIngredienteNavigation { get; set; }
        public Recetas IdRecetaNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
