using System;
using System.Collections.Generic;

namespace Proyecto1Seminario2Grupo13
{
    internal class MovimientosController
    {
        private List<Movimiento> _movimientos = new List<Movimiento>();

        public void AgregarMovimiento(Producto unProducto, Movimiento unMovimiento)
        {
            MovimientosService.GuardarMovimiento(unMovimiento, unProducto.ID);
            _movimientos.Add(unMovimiento);
        }

        public void CargarMovimientos(Producto unProducto)
        {
            _movimientos = MovimientosService.ObtenerMovimientosProducto(unProducto) ?? new List<Movimiento>();
        }

        public Movimiento AgregarUnidades(int cantidadUnidades, DateTime fecha)
        {
            int nuevoID = MovimientosService.ObtenerNuevoID_Movimiento();
            Movimiento carga = new Movimiento(nuevoID, cantidadUnidades, fecha);
            _movimientos.Add(carga);
            return carga;
        }

        public Movimiento RestarUnidades(int cantidadUnidades, DateTime fecha)
        {
            try
            {
                int stockActual = CalcularStockActual();

                if (cantidadUnidades > stockActual)
                {
                    MessageBox.Show("No se puede restar más unidades de las disponibles en el stock.");
                    return null;
                }

                int nuevoID = MovimientosService.ObtenerNuevoID_Movimiento();
                Movimiento descarga = new Movimiento(nuevoID, -cantidadUnidades, fecha);
                _movimientos.Add(descarga);
                return descarga;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al intentar restar unidades: {ex.Message}");
                return null;
            }
        }


        public int CalcularStockActual()
        {
            int stockActual = 0;
            foreach (var movimiento in _movimientos)
            {
                stockActual += movimiento.Cantidad;
            }
            return stockActual;
        }
    }
}
