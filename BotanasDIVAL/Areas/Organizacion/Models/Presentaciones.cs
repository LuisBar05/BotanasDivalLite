using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Presentaciones
    {
        public Presentaciones()
        {
            Productos = new HashSet<Productos>();
        }

        public int IdPresentacion { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float Cantidad { get; set; }
        public int IdUniMed { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public UnidadesMedida IdUniMedNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<Productos> Productos { get; set; }
    }
}
