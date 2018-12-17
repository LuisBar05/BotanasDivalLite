using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaRegistro { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public string CodProducto { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaElaboracion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaCaducidad { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Productos CodProductoNavigation { get; set; }
        public Status StatusNavigation { get; set; }
    }
}
