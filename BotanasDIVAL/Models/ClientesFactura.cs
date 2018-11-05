using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class ClientesFactura
    {
        public ClientesFactura()
        {
            Factura = new HashSet<Factura>();
        }

        public int IdCliente { get; set; }
        public string ApellidoPat { get; set; }
        public string ApellidoMat { get; set; }
        public string NombreS { get; set; }
        public string Rfc { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<Factura> Factura { get; set; }
    }
}
