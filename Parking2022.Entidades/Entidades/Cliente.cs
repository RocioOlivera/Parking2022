using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking2022.Entidades.Entidades
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string ApellidoYNombre { get; set; }
        public string NumDocumento { get; set; }
        public string TelDeContacto { get; set; }
        public byte[] RowVersion { get; set; }

    }
}
