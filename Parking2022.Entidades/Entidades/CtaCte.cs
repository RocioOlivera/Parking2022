using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class CtaCte
    {
        public int CtaCteId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public decimal Saldo { get; set; }
        public byte[] RowVersion { get; set; }
        public Cliente Cliente { get; set; }
    }
}
