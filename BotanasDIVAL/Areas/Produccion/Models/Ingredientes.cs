using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Ingredientes
    {
        public Ingredientes()
        {
            Almacen = new HashSet<Almacen>();
            DetalleCompra = new HashSet<DetalleCompra>();
            ListasIngredientes = new HashSet<ListasIngredientes>();
        }

        public int IdIngrediente { get; set; }
        public string NombreIngrediente { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float Cantidad { get; set; }
        public int IdUniMed { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public UnidadesMedida IdUniMedNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<Almacen> Almacen { get; set; }
        public ICollection<DetalleCompra> DetalleCompra { get; set; }
        public ICollection<ListasIngredientes> ListasIngredientes { get; set; }
    }
}
