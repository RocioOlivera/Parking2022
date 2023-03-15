using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class AlquilerDiario
    {
        public int AlquilerEnElDiaId { get; set; }
        public int TipoVehiculoId { get; set; }
        public string Patente { get; set; }
        public int TipoSectorId { get; set; }
        public int NroId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public TimeSpan TiempoTotal { get; set; }
        public int TiempotarifaId { get; set; }
        public int TarifaId { get; set; }
        public bool Pago { get; set; }
        public byte[] RowVersion { get; set; }
        public TipoDeVehiculo TipoDeVehiculo { get; set; }
        public TipoDeSector TipoDeSector { get; set; }
        public NrosSectores  NrosSectores { get; set; }
        public Tarifa Tarifa { get; set; }
        public TiempoTarifa TiempoTarifa { get; set; }
    }
}
