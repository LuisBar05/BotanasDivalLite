using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Categorias
    {
        public Categorias()
        {
            Recetas = new HashSet<Recetas>();
        }

        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres")]
        public string NombreCategoria { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<Recetas> Recetas { get; set; }
    }
}
