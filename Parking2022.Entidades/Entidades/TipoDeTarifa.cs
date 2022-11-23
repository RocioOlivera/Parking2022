using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class TipoDeTarifa
    {
        public int TipoTarifaId { get; set; }
        public int TipoVehiculoId { get; set; }
        public decimal Hora { get; set; }
        public int MediaEstadia { get; set; }
        public int Estadia { get; set; }
        public decimal Noche { get; set; }
        //public int Semana { get; set; }
        //public int Quincena { get; set; }
        //public int Mes { get; set; }
        public byte[] RowVersion { get; set; }
        public TipoDeVehiculo TipoDeVehiculo { get; set; }
    }
}
