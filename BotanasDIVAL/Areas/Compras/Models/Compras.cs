﻿using System;
using System.Collections.Generic;

namespace BotanasDIVAL.Models
{
    public partial class Compras
    {
        public Compras()
        {
            DetalleCompra = new HashSet<DetalleCompra>();
        }

        public int IdCompra { get; set; }
        public float TotalCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public string LugarCompra { get; set; }
        public string Status { get; set; }
        public string Observaciones { get; set; }

        public Status StatusNavigation { get; set; }
        public ICollection<DetalleCompra> DetalleCompra { get; set; }
    }
}