using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Almacen
    {
        public int IdAlmacen { get; set; }
        public int IdIngrediente { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Ingredientes IdIngredienteNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
