using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Categorias
    {
        public Categorias()
        {
            Recetas = new HashSet<Recetas>();
        }

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<Recetas> Recetas { get; set; }
    }
}
