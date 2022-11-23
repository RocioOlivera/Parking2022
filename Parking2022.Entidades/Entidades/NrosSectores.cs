using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class NrosSectores
    {
        public int NroId { get; set; }
        public int TipoSectorId { get; set; }
        public string Nro { get; set; }
        public bool Ocupado { get; set; }
        public byte[] RowVersion { get; set; }
        public TipoDeSector TipoDeSector { get; set; }
    }
}
