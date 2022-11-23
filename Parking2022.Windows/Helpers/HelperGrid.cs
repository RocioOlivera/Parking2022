using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking2022.Entidades.Entidades;

namespace Parking2022.Windows.Helpers
{
    public static class HelperGrid
    {
        public static void LimpiarGrilla(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGrid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGrid);
            return r;
        }

        public static void AgregarFila(DataGridView dataGrid, DataGridViewRow r)
        {
            dataGrid.Rows.Add(r);
        }

        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            switch (obj)
            {
                case Cliente c:
                    r.Cells[0].Value = ((Cliente) obj).ApellidoYNombre;
                    r.Cells[1].Value = ((Cliente) obj).NumDocumento;
                    r.Cells[2].Value = ((Cliente) obj).TelDeContacto;

                    break;

                case TipoDeVehiculo tipoDeVehiculo:
                    r.Cells[0].Value = tipoDeVehiculo.TipoVehiculo;

                    break;

                case TipoDeTarifa tipoDeTarifa:
                    r.Cells[0].Value = tipoDeTarifa.TipoDeVehiculo.TipoVehiculo;
                    r.Cells[1].Value = tipoDeTarifa.Hora;
                    r.Cells[2].Value = tipoDeTarifa.MediaEstadia;
                    r.Cells[3].Value = tipoDeTarifa.Estadia;
                    r.Cells[4].Value = tipoDeTarifa.Noche;
                    //r.Cells[5].Value = tipoDeTarifa.Semana;
                    //r.Cells[6].Value = tipoDeTarifa.Quincena;
                    //r.Cells[7].Value = tipoDeTarifa.Mes;

                    break;

                case CtaCte cc:
                    r.Cells[0].Value = cc.Cliente.ApellidoYNombre;
                    r.Cells[1].Value = cc.FechaMovimiento;
                    r.Cells[2].Value = cc.Debe;
                    r.Cells[3].Value = cc.Haber;
                    r.Cells[4].Value = cc.Saldo;

                    break;

                case AlquilerDiario alquilerDiario:
                    r.Cells[0].Value = alquilerDiario.TipoDeVehiculo.TipoVehiculo;
                    r.Cells[1].Value = alquilerDiario.Patente;
                    r.Cells[2].Value = alquilerDiario.TipoDeSector.TipoSectorId;
                    r.Cells[3].Value = alquilerDiario.NrosSectores.Nro;
                    r.Cells[4].Value = alquilerDiario.FechaIngreso;
                    r.Cells[5].Value = alquilerDiario.Activo;

                    break;

                case TipoDeSector tipoDeSector:
                    r.Cells[0].Value = tipoDeSector.TipoSector;

                    break;

                case NrosSectores nrosSectores:
                    r.Cells[0].Value = nrosSectores.TipoDeSector.TipoSector;
                    r.Cells[1].Value = nrosSectores.Nro;
                    r.Cells[2].Value = nrosSectores.Ocupado;
                    break;

                    //case ItemCarrito item:
                    //    r.Cells[0].Value = item.Descripcion;
                    //    r.Cells[1].Value = item.Precio;
                    //    r.Cells[2].Value = item.Cantidad;
                    //    r.Cells[3].Value = item.Cantidad * item.Precio;
                    //    break;

                    //}
            }

            r.Tag = obj;

        }

        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
    }
}

