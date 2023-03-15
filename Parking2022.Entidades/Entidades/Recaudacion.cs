using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class Recaudacion
    {
        public int RecaudacionId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
