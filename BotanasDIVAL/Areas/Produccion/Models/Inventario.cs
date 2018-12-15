using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaRegistro { get; set; }
        public string CodProducto { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public int Cantidad { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaElaboracion { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaCaducidad { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Productos CodProductoNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
