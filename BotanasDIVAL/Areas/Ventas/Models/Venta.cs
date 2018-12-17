using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdVenta { get; set; }
        [DataType(DataType.Currency)]
        public float TotalVenta { get; set; }
        [Required(ErrorMessage = "El campo Fecha de Venta es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaVenta { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<DetalleVenta> DetalleVenta { get; set; }
    }
}
