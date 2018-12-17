using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BotanasDIVAL.Models
{
    public partial class Recetas
    {
        public Recetas()
        {
            ListasIngredientes = new HashSet<ListasIngredientes>();
            Productos = new HashSet<Productos>();
        }

        public int IdReceta { get; set; }
        [Required(ErrorMessage = "El campo Categoría es requerido")]
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "El campo Descripción es requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Descripcion { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float? Merma { get; set; }
        [Required(ErrorMessage = "El campo Unidad de Medida es requerido")]
        public int IdUniMed { get; set; }
        [Required(ErrorMessage = "El campo Costo por Kilo es requerido")]
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue, ErrorMessage = "Solo números positivos son permitidos")]
        public float CostoKilo { get; set; }
        public string Status { get; set; }
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Observaciones { get; set; }

        public Categorias IdCategoriaNavigation { get; set; }
        public UnidadesMedida IdUniMedNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<ListasIngredientes> ListasIngredientes { get; set; }
        public ICollection<Productos> Productos { get; set; }
    }
}
