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
            List<Movimiento> movimientosObtenidos = MovimientosService.ObtenerMovimientosProducto(unProducto);
            if (movimientosObtenidos != null)
            {
                _movimientos = movimientosObtenidos;
            }
            else
            {
                _movimientos = new List<Movimiento>();
            }

        }

        public Movimiento AgregarUnidades(int cantidadUnidades, DateTime fecha)
        {
            int nuevoID = MovimientosService.ObtenerNuevoID_Movimiento();
            Movimiento carga = new Movimiento(nuevoID, cantidadUnidades, fecha);
            _movimientos.Add(carga);
            return carga;
        }

        public Movimiento RestarUnidades(int cantidadUnidades, DateTime fecha, Producto unProducto)
        {
            // Calcular el stock actual del producto antes de restar
            int stockActual = CalcularStockActual(unProducto);

            if (cantidadUnidades > stockActual)
            {
                throw new Exception("No se puede restar más unidades de las disponibles en el stock.");
            }
            else
            {
                int nuevoID = MovimientosService.ObtenerNuevoID_Movimiento();
                Movimiento descarga = new Movimiento(nuevoID, -cantidadUnidades, fecha);
                _movimientos.Add(descarga);
                return descarga;
            }
        }

        public int CalcularStockActual(Producto unProducto)
        {
            List<Movimiento> movimientos = MovimientosService.ObtenerMovimientosProducto(unProducto);
            int stockActual = 0;
            foreach (var movimiento in movimientos)
            {
                stockActual += movimiento.Cantidad;
            }
            return stockActual;
        }
    }
}
