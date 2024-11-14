using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Seminario2Grupo13
{
    internal class MovimientosService
    {

        // Esta clase implementa el controlador de persistencia
        private static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarMovimiento(Movimiento unMovimiento, string idProducto)
        {
            // Se establece el nombre del archivo a escribir
            string fileName = Path.Combine(GetAppPath(), "movimientos.txt");
            if (!File.Exists(fileName))
            {
                // Se crea y escribe el archivo ya que no existe
                // Se genera un StreamWriter para controlar la escritura de datos
                using (StreamWriter archivoSalida = new StreamWriter(fileName))
                {
                    string datos = $"{unMovimiento.Id};{unMovimiento.Cantidad};{unMovimiento.Fecha};{idProducto}";
                    archivoSalida.WriteLine(datos);
                }
            }
            else
            {
                // Se añaden datos al archivo ya que existe, para eso se establece el segundo parámetro
                using (StreamWriter archivoSalida = new StreamWriter(fileName, true))
                {
                    string datos = $"{unMovimiento.Id};{unMovimiento.Cantidad};{unMovimiento.Fecha};{idProducto}";
                    archivoSalida.WriteLine(datos);
                }
            }
        }
        
        public static List<Movimiento> ObtenerMovimientosProducto(Producto unProducto)
        {
                     
            try
            {
                // Se establece el nombre del archivo a leer
                string fileName = Path.Combine(GetAppPath(), "movimientos.txt");
                if (File.Exists(fileName))
                {
                    // Se lee el archivo ya que existe
                    List<Movimiento> movimientos = new List<Movimiento>();
                    string[] lineas = File.ReadAllLines(fileName);
                    foreach (string movimientoComoTexto in lineas)
                    {
                        var datos = movimientoComoTexto.Split(";");
                        if (unProducto.ID == datos[datos.Length - 1])
                        {
                            Movimiento unMovimiento = new Movimiento(int.Parse(datos[0]), int.Parse(datos[1]), DateTime.Parse(datos[2]));
                            movimientos.Add(unMovimiento);
                        }
                    }
                    return movimientos;
                }

            } catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }

            return new List<Movimiento>();
           
        }

        public static int ObtenerNuevoID_Movimiento()
        {
            try
            {
                // Se establece el nombre del archivo a leer
                string fileName = Path.Combine(GetAppPath(), "movimientos.txt");
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
