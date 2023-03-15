using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class Tarifa
    {
        public int TarifaId { get; set; }
        public string  Descripcion { get; set; }
        public int TipoVehiculoId { get; set; }
        public int TiempoTarifaId { get; set; }
        public decimal Importe { get; set; }
        public byte[] RowVersion { get; set; }
        public TipoDeVehiculo TipoDeVehiculo { get; set; }
        public TiempoTarifa TiempoTarifa { get; set; }
    }
}
