using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Productos
    {
        public Productos()
        {
            DetallePedido = new HashSet<DetallePedido>();
            DetalleVenta = new HashSet<DetalleVenta>();
            Inventario = new HashSet<Inventario>();
        }

        public int IdProducto { get; set; }
        public string CodProducto { get; set; }
        [Required]
        public string Descripcion { get; set; }
        public int IdReceta { get; set; }
        public int IdPresentacion { get; set; }
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float Precio { get; set; }
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float CostoUnit { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Presentaciones IdPresentacionNavigation { get; set; }
        public Recetas IdRecetaNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<DetallePedido> DetallePedido { get; set; }
        public ICollection<DetalleVenta> DetalleVenta { get; set; }
        public ICollection<Inventario> Inventario { get; set; }
    }
}
