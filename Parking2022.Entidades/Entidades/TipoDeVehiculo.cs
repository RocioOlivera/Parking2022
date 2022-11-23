using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class TipoDeVehiculo
    {
        public int TipoVehiculoId { get; set; }
        public string TipoVehiculo { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
