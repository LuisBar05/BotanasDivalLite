using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Status
    {
        public Status()
        {
            Almacen = new HashSet<Almacen>();
            Categorias = new HashSet<Categorias>();
            Compras = new HashSet<Compra>();
            DetalleCompra = new HashSet<DetalleCompra>();
            DetallePedido = new HashSet<DetallePedido>();
            DetalleVenta = new HashSet<DetalleVenta>();
            Ingredientes = new HashSet<Ingredientes>();
            Inventario = new HashSet<Inventario>();
            ListasIngredientes = new HashSet<ListasIngredientes>();
            Pedidos = new HashSet<Pedidos>();
            Presentaciones = new HashSet<Presentaciones>();
            Productos = new HashSet<Productos>();
            Recetas = new HashSet<Recetas>();
            UnidadesMedida = new HashSet<UnidadesMedida>();
            Ventas = new HashSet<Venta>();
        }

        public int IdStatus { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "Sólo es necesario 1 caracter")]
        public string Status1 { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(25, ErrorMessage = "Máximo 25 caracteres")]
        public string DescripcionStatus { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public ICollection<Almacen> Almacen { get; set; }
        public ICollection<Categorias> Categorias { get; set; }
        public ICollection<Compra> Compras { get; set; }
        public ICollection<DetalleCompra> DetalleCompra { get; set; }
        public ICollection<DetallePedido> DetallePedido { get; set; }
        public ICollection<DetalleVenta> DetalleVenta { get; set; }
        public ICollection<Ingredientes> Ingredientes { get; set; }
        public ICollection<Inventario> Inventario { get; set; }
        public ICollection<ListasIngredientes> ListasIngredientes { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
        public ICollection<Presentaciones> Presentaciones { get; set; }
        public ICollection<Productos> Productos { get; set; }
        public ICollection<Recetas> Recetas { get; set; }
        public ICollection<UnidadesMedida> UnidadesMedida { get; set; }
        public ICollection<Venta> Ventas { get; set; }
    }
}
