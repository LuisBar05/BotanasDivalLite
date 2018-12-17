using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Compra
    {
        public Compra()
        {
            DetalleCompra = new HashSet<DetalleCompra>();
        }

        public int IdCompra { get; set; }
        [DataType(DataType.Currency)]
        public float TotalCompra { get; set; }
        [Required(ErrorMessage = "El campo Fecha de Compra es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaCompra { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 50 caracteres")]
        public string LugarCompra { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<DetalleCompra> DetalleCompra { get; set; }
    }
}
