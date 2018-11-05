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
            ClientesFactura = new HashSet<ClientesFactura>();
            Compras = new HashSet<Compras>();
            DetalleCompra = new HashSet<DetalleCompra>();
            DetalleVenta = new HashSet<DetalleVenta>();
            Factura = new HashSet<Factura>();
            FormaPago = new HashSet<FormaPago>();
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
        public string status { get; set; }
        public string DescripcionStatus { get; set; }
        public string Observaciones { get; set; }

        public ICollection<Almacen> Almacen { get; set; }
        public ICollection<Categorias> Categorias { get; set; }
        public ICollection<ClientesFactura> ClientesFactura { get; set; }
        public ICollection<Compras> Compras { get; set; }
        public ICollection<DetalleCompra> DetalleCompra { get; set; }
        public ICollection<DetalleVenta> DetalleVenta { get; set; }
        public ICollection<Factura> Factura { get; set; }
        public ICollection<FormaPago> FormaPago { get; set; }
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
