﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Seminario2Grupo13
{
    internal static class ProductosController
    {
        // Este es nuestro controlador del negocio
        public static void GuardarProducto(Producto unProducto) 
        {
            // Acá debería haber algún tipo de lógica implementada

            // Mandamos los datos al almacenamiento
            ProductosService.GuardarProducto(unProducto);
        }
        
        public static List<Producto> CargarMovimientos(List<Producto> productos)
        {
            foreach (Producto producto in productos)
            {
                List<Movimiento> listaMovimientos = MovimientosService.ObtenerMovimientosProducto(producto);

                if (listaMovimientos.Count > 0)
                {
                    producto.CargarMovimientos(listaMovimientos);
                }
            }
            return productos;
        }

        public static List<Producto> LeerProductos()
        {
            List<Producto> productos = new List<Producto>();
            productos = ProductosService.LeerProductos();
            if (productos != null)
            {
                // Existen productos y está caargada la colección
                // Se cargan todos los movimientos para cada producto
                productos = CargarMovimientos(productos);
                return productos;
            }
            else
            {
                throw new Exception("No hay productos para mostrar");
            }
        }

        public static void AgregarMovimiento(Producto unProducto, Movimiento unMovimiento)
        {
            // Se podrían hacer acá estos pasos:
            // - Crear el movimiento (objeto)
            // - Agregarlo al producto (con un método de la clase Producto)

            // Se hace la llamada a la capa de persistencia para guardar el movimiento
            MovimientosService.GuardarMovimiento(unMovimiento, unProducto.ID);
        }

    }
}
