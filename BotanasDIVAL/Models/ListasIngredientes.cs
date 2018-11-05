using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class ListasIngredientes
    {
        public int IdListasIngred { get; set; }
        public int IdReceta { get; set; }
        public int IdIngrediente { get; set; }
        public float Cantidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Ingredientes IdIngredienteNavigation { get; set; }
        public Recetas IdRecetaNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
