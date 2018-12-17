using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 25 caracteres")]
        public string DescripcionUniMed { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<Ingredientes> Ingredientes { get; set; }
        public ICollection<Presentaciones> Presentaciones { get; set; }
        public ICollection<Recetas> Recetas { get; set; }
    }
}
