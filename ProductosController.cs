using System;
using System.Collections.Generic;

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
            if (productos == null)
            {
                throw new Exception("No hay productos para mostrar");
            }
            return productos;
        }
    }
}
