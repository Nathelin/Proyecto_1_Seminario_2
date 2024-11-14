using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Seminario2Grupo13
{
    internal class ProductosService
    {
        // Esta clase implementa el controlador de persistencia
        private static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarProducto(Producto unProducto)
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(), "productos.txt");
            if (!File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    string datos = $"{unProducto.ID};{unProducto.Nombre}";
                    archivoSalida.WriteLine(datos);
                }
            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
                {
                    string datos = $"{unProducto.ID};{unProducto.Nombre}";
                    archivoSalida.WriteLine(datos);
                }
            }
        }

        public static List<Producto> LeerProductos()
        {
            // Se establece el nombre del archivo a leer
            string fileName = Path.Combine(GetAppPath(), "productos.txt");
            if (File.Exists(fileName))
            {
                // Se lee el archivo ya que existe
                // Se genera un StreamReader para controlar la lectura de datos
                //using (StreamReader archivoEntrada = new StreamReader(fileName))
                //{
                    // Se lee el archivo completo
                //    string contenido = archivoEntrada.ReadLine();
                //    Console.WriteLine(contenido);
                //}
                List<Producto> productos = new List<Producto>();
                string[] lineas = File.ReadAllLines(fileName);
                foreach (string productoComoTexto in lineas) 
                {
                    var datos = productoComoTexto.Split(";");
                    Producto unProducto = new Producto(datos[0], datos[1]); //int.Parse(datos[2])
                    productos.Add(unProducto);  
                }
                return productos;
            }
            else
            {
                // Console.WriteLine("El archivo no existe");
                return null;
            }
        }



        public static int ObtenerNuevoIDProducto()
            {
                try
                {
                    // Se establece el nombre del archivo a leer
                    string fileName = Path.Combine(GetAppPath(), "productos.txt");



                    if (File.Exists(fileName))
                    {
                        // Se leen todas las líneas del archivo
                        string[] lineas = File.ReadAllLines(fileName);

                        // Si hay líneas, obtenemos el último ID
                        if (lineas.Length > 0)
                        {
                            // Se toma la última línea para obtener el último movimiento
                            string ultimaLinea = lineas[lineas.Length - 1];
                            var datos = ultimaLinea.Split(";");

                            // Se extrae el primer dato (en este caso el ID) de la última línea y se convierte a entero
                            int ultimoID = int.Parse(datos[0]);

                            // Retornamos el nuevo ID sumando 1 al último ID
                            return ultimoID + 1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // Si el archivo no existe o está vacío, comenzamos con ID 1
                return 1;
            }


    }
}
