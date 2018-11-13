using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class UnidadesMedida
    {
        public UnidadesMedida()
        {
            Ingredientes = new HashSet<Ingredientes>();
            Presentaciones = new HashSet<Presentaciones>();
            Recetas = new HashSet<Recetas>();
        }

        public int IdUniMed { get; set; }
        public string DescripcionUniMed { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<Ingredientes> Ingredientes { get; set; }
        public ICollection<Presentaciones> Presentaciones { get; set; }
        public ICollection<Recetas> Recetas { get; set; }
    }
}
