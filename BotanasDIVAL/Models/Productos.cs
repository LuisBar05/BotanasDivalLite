using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Productos
    {
        public Productos()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
            Inventario = new HashSet<Inventario>();
        }

        public int IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string Descripcion { get; set; }
        public int IdReceta { get; set; }
        public int IdPresentacion { get; set; }
        public float Precio { get; set; }
        public float CostoUnit { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Presentaciones IdPresentacionNavigation { get; set; }
        public Recetas IdRecetaNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<DetalleVenta> DetalleVenta { get; set; }
        public ICollection<Inventario> Inventario { get; set; }
    }
}
