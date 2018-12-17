using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            DetallePedido = new HashSet<DetallePedido>();
        }

        public int IdPedido { get; set; }
        [Required(ErrorMessage = "El campo Cliente es requerido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mínimo 3 caracteres, Máximo 50 caracteres")]
        public string Cliente { get; set; }
        [DataType(DataType.Currency)]
        public float TotalPedido { get; set; }
        [Required(ErrorMessage = "El campo Fecha de Pedido es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaPedido { get; set; }
        [Required(ErrorMessage = "El campo Fecha de Entrega es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaEntrega { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
