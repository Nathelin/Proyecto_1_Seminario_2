using Proyecto1Seminario2Grupo13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924
{
    internal class MovimientosController
    {
        // Se define la lista de movimientos de stock
        private List<Movimiento> _movimientos = new List<Movimiento>();

        public void AgregarMovimiento(Producto unProducto, Movimiento unMovimiento)
        {
            // Se podría hacer acá estos pasos:
            // - Crear el movimiento (objeto)
            // - Agregarlo al producto (con un método de la clase Producto)

            // Se hace la llamada a la capa de persistencia para guardar el movimiento
            MovimientosService.GuardarMovimiento(unMovimiento, unProducto.ID);
        }

        public void CargarMovimientos(List<Movimiento> listaMovimientos)
        {
            _movimientos = listaMovimientos ?? new List<Movimiento>();
        }

        // Se definen los métodos para agregar y restar stock
        public Movimiento agregarUnidades(int cantidadUnidades, DateTime fecha)
        {
            int nuevoID = MovimientosService.ObtenerNuevoID_Movimiento();

            // Generamos el objeto para registrar el movimiento
            Movimiento carga = new Movimiento(nuevoID, cantidadUnidades, fecha);
            // Se agrega
            _movimientos.Add(carga);
            return carga;
        }

        public Movimiento restarUnidades(int cantidadUnidades, DateTime fecha)
        {
            int nuevoID = MovimientosService.ObtenerNuevoID_Movimiento();

            // Generamos el objeto para registrar el movimiento
            Movimiento descarga = new Movimiento(nuevoID, -cantidadUnidades, fecha);

            // Se agrega
            _movimientos.Add(descarga);
            return descarga;
        }
    }

}
