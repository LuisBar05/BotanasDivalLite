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
        [Required(ErrorMessage = "El campo es requerido")]
        [StringLength(45, ErrorMessage = "Máximo 45 caracteres")]
        public string NombreIngrediente { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float Cantidad { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int IdUniMed { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public UnidadesMedida IdUniMedNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<Almacen> Almacen { get; set; }
        public ICollection<DetalleCompra> DetalleCompra { get; set; }
        public ICollection<ListasIngredientes> ListasIngredientes { get; set; }
    }
}
