using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Status
    {
        public Status()
        {
            Almacen = new HashSet<Almacen>();
            Categorias = new HashSet<Categorias>();
            Compras = new HashSet<Compras>();
            DetalleCompra = new HashSet<DetalleCompra>();
            DetalleVenta = new HashSet<DetalleVenta>();
            Ingredientes = new HashSet<Ingredientes>();
            Inventario = new HashSet<Inventario>();
            ListasIngredientes = new HashSet<ListasIngredientes>();
            Presentaciones = new HashSet<Presentaciones>();
            Productos = new HashSet<Productos>();
            Proveedores = new HashSet<Proveedores>();
            Recetas = new HashSet<Recetas>();
            UnidadesMedida = new HashSet<UnidadesMedida>();
            Usuarios = new HashSet<Usuarios>();
            Ventas = new HashSet<Ventas>();
        }

        public int IdStatus { get; set; }
        public string Status1 { get; set; }
        public string DescripcionStatus { get; set; }
        public string Observaciones { get; set; }

        public ICollection<Almacen> Almacen { get; set; }
        public ICollection<Categorias> Categorias { get; set; }
        public ICollection<Compras> Compras { get; set; }
        public ICollection<DetalleCompra> DetalleCompra { get; set; }
        public ICollection<DetalleVenta> DetalleVenta { get; set; }
        public ICollection<Ingredientes> Ingredientes { get; set; }
        public ICollection<Inventario> Inventario { get; set; }
        public ICollection<ListasIngredientes> ListasIngredientes { get; set; }
        public ICollection<Presentaciones> Presentaciones { get; set; }
        public ICollection<Productos> Productos { get; set; }
        public ICollection<Proveedores> Proveedores { get; set; }
        public ICollection<Recetas> Recetas { get; set; }
        public ICollection<UnidadesMedida> UnidadesMedida { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
        public ICollection<Ventas> Ventas { get; set; }
    }
}
