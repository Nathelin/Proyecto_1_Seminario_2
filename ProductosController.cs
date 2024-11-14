using C2_110924;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Seminario2Grupo13
{
    internal class ProductosController
    {
        // Este es nuestro controlador del negocio
        public static void GuardarProducto(Producto unProducto) 
        {
            // Acá debería haber algún tipo de lógica implementada

            // Mandamos los datos al almacenamiento
            ProductosService.GuardarProducto(unProducto);
        }

        public static Producto CrearProducto(string nombre, int cantidad) 
        { 
            int nuevoID = ProductosService.ObtenerNuevoIDProducto();
            Producto nuevoProducto = new Producto(nuevoID.ToString(), nombre, cantidad);
            GuardarProducto(nuevoProducto); return nuevoProducto; 
        }

        public static List<Producto> CargarMovimientos(List<Producto> productos)
        {
            foreach (Producto producto in productos)
            {
                List<Movimiento> listaMovimientos = MovimientosService.ObtenerMovimientosProducto(producto);

                if (listaMovimientos.Count > 0)
                {
                    MovimientosController.CargarMovimientos(listaMovimientos);
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

       
    }
}
