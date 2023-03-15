using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class FinalizarAlquilerDiario
    {
        public int FinAlquilerDiaId { get; set; }
        public int TipoVehiculoId { get; set; }
        public int AlquilerEnElDiaId { get; set; }
        public DateTime HoraSalida { get; set; }
        public TimeSpan TotalHoras { get; set; }
        public int TarifaId { get; set; }
        public double Costo { get; set; }
        public double ImporteAPagar { get; set; }
        public bool Abonado { get; set; }
        public bool Retirado { get; set; }
        public byte[] RowVersion { get; set; }
        public TipoDeVehiculo TipoDeVehiculo { get; set; }
        public AlquilerDiario AlquilerDiario { get; set; }
        public Tarifa Tarifa { get; set; }
        public TiempoTarifa TiempoTarifa { get; set; }
    }
}
