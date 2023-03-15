using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking2022.Entidades.Entidades;
using Parking2022.Servicios.Servicios;

namespace Parking2022.Windows.Helpers
{
    public static class HelperCombos
    {
        public static void CargarDatosComboTipoVehiculo(ref ComboBox combo)
        {
            ServicioTiposDeVehiculos servicio = new ServicioTiposDeVehiculos();
            var lista = servicio.GetLista();
            var defaultTipoDeVehiculo = new TipoDeVehiculo()
            {
                TipoVehiculoId = 0,
                TipoVehiculo = "Seleccione un tipo de vehiculo"
            };
            lista.Insert(0, defaultTipoDeVehiculo);
            combo.DataSource = lista;
            combo.DisplayMember = "TipoVehiculo";
            combo.ValueMember = "TipoVehiculoId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboTipoSector(ref ComboBox combo)
        {
            ServicioTiposDeSectores servicio = new ServicioTiposDeSectores();
            var lista = servicio.GetLista();
            var defaultTipoDeSector = new TipoDeSector()
            {
                TipoSectorId = 0,
                TipoSector = "Seleccione un tipo de sector"
            };
            lista.Insert(0, defaultTipoDeSector);
            combo.DataSource = lista;
            combo.DisplayMember = "TipoSector";
            combo.ValueMember = "TipoSectorId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboNrosSectores(ref ComboBox combo, TipoDeSector tipoDeSector)
        {
            ServicioNrosSectores servicio = new ServicioNrosSectores();
            var lista = servicio.GetLista(tipoDeSector);
            var defaultNroSector = new NrosSectores()
            {
                NroId = 0,
                Nro = "Seleccione ubicación"
            };
            lista.Insert(0, defaultNroSector);
            combo.DataSource = lista;
            combo.DisplayMember = "Nro";
            combo.ValueMember = "NroId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboTipoTarifa(ref ComboBox combo)
        {
            ServicioTiempoTarifa servicio = new ServicioTiempoTarifa();
            var lista = servicio.GetLista();
            var defaultTiempoTarifa = new TiempoTarifa()
            {
                TiempoTarifaId = 0,
                Descripcion = "Seleccione el tipo de Tarifa"
            };
            lista.Insert(0, defaultTiempoTarifa);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TiempoTarifaId";
            combo.SelectedIndex = 0;
        }

        public static void CargarDatosComboCostoTarifa(ref ComboBox combo, TipoDeVehiculo tipoDeVehiculo, TiempoTarifa tiempoTarifa)
        {
            ServicioTarifas servicio = new ServicioTarifas();
            var lista = servicio.GetLista(tipoDeVehiculo, tiempoTarifa);
            var defaultTarifa = new Tarifa()
            {
                TarifaId = 0,
                Importe = 0
            };
           // lista.Insert(0, defaultTarifa);
            combo.DataSource = lista;
            combo.DisplayMember = "Importe";
            combo.ValueMember = "TarifaId";
            combo.SelectedIndex = 0;
        }
    }
}
