using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class FormaPago
    {
        public int IdFormaPago { get; set; }
        public string TipoPago { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
    }
}
