using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class AlquilerConAbono
    {
        public int AlquilerConAbonoId { get; set; }
        public int TipoTarifaId { get; set; }
        public int SectorId { get; set; }
        public int TipoVehiculoId { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int ClienteId { get; set; }
        public DateTime DiaYHoraIngreso { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal ImporteAPagar { get; set; }
        public bool Abonado { get; set; }
        public bool Activo { get; set; }
        public byte[] RowVersion { get; set; }
        public TipoDeTarifa TipoDeTarifa { get; set; }
        public TipoDeSector TipoDeSector { get; set; }
        public TipoDeVehiculo TipoDeVehiculo { get; set; }
        public Cliente Cliente { get; set; }
    }
}
