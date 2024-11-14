using C2_110924;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Seminario2Grupo13
{
    internal static class ProductosController
    {
        public static void GuardarProducto(Producto unProducto)
        {
            ProductosService.GuardarProducto(unProducto);
        }

        public static Producto CrearProducto(string nombre)
        {
            int nuevoID = ProductosService.ObtenerNuevoIDProducto();
            Producto nuevoProducto = new Producto(nuevoID.ToString(), nombre);
            GuardarProducto(nuevoProducto);
            return nuevoProducto;
        }

        public static List<Producto> LeerProductos()
        {
            List<Producto> productos = ProductosService.LeerProductos();
            if (productos != null)
            {
                productos = CargarMovimientos(productos);
                return productos;
            }
            else
            {
                throw new Exception("No hay productos para mostrar");
            }
        }

        public static List<Producto> CargarMovimientos(List<Producto> productos)
        {
            MovimientosController movimientosController = new MovimientosController();

            foreach (Producto producto in productos)
            {
                List<Movimiento> listaMovimientos = MovimientosService.ObtenerMovimientosProducto(producto);

                if (listaMovimientos.Count > 0)
                {
                    movimientosController.CargarMovimientos(listaMovimientos);
                }
            }
            return productos;
        }
    }

}
