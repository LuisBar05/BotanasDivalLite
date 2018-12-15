using BotanasDIVAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotanasDIVAL.Areas.Produccion.Models
{
    public class BundleReceta
    {
        public Recetas Receta { get; set; }
        public ListasIngredientes ListaIngredientes { get; set; }
    }
}
