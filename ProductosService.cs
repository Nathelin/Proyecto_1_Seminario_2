using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto1Seminario2Grupo13
{
    internal class ProductosService
    {
        private static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarProducto(Producto unProducto)
        {
            string fileName = Path.Combine(GetAppPath(), "productos.txt");
            string datos = $"{unProducto.ID};{unProducto.Nombre};0"; // Inicialmente el stock es 0

            using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
            {
                archivoSalida.WriteLine(datos);
            }
        }

        public static List<Producto> LeerProductos()
        {
            string fileName = Path.Combine(GetAppPath(), "productos.txt");
            List<Producto> productos = new List<Producto>();

            if (File.Exists(fileName))
            {
                string[] lineas = File.ReadAllLines(fileName);
                foreach (string productoComoTexto in lineas)
                {
                    var datos = productoComoTexto.Split(";");
                    Producto unProducto = new Producto(datos[0], datos[1]);
                    productos.Add(unProducto);
                }
            }

            return productos;
        }

        public static int ObtenerNuevoIDProducto()
        {
            string fileName = Path.Combine(GetAppPath(), "productos.txt");
            int ultimoID = 0;

            if (File.Exists(fileName))
            {
                string[] lineas = File.ReadAllLines(fileName);
                if (lineas.Length > 0)
                {
                    string ultimaLinea = lineas[lineas.Length - 1];
                    var datos = ultimaLinea.Split(";");
                    ultimoID = int.Parse(datos[0]);
                }
            }

            return ultimoID + 1;
        }
    }
}
