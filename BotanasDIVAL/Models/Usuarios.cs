using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Usuarios
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string TipoUsuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
    }
}
