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
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Mínimo 3 caracteres, Máximo 50 caracteres")]
        public string Cliente { get; set; }
        [DataType(DataType.Currency)]
        public float TotalPedido { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaPedido { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime FechaEntrega { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<DetallePedido> DetallePedido { get; set; }
    }
}
