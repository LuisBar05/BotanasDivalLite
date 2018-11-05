using System;
using System.Collections.Generic;

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
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public float? Merma { get; set; }
        public int IdUniMed { get; set; }
        public float CostoKilo { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Categorias IdCategoriaNavigation { get; set; }
        public UnidadesMedida IdUniMedNavigation { get; set; }
        public Status StatusNavigation { get; set; }
        public ICollection<ListasIngredientes> ListasIngredientes { get; set; }
        public ICollection<Productos> Productos { get; set; }
    }
}
