using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Ingredientes = new HashSet<Ingredientes>();
        }

        public int IdProveedor { get; set; }
        public string NombreProv { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Cp { get; set; }
        public string Telefono { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<Ingredientes> Ingredientes { get; set; }
    }
}
