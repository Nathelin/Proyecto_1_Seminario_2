﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto1Seminario2Grupo13
{
    internal class MovimientosService
    {
        private static string GetAppPath()
        {
            return AppContext.BaseDirectory;
        }

        public static void GuardarMovimiento(Movimiento unMovimiento, string idProducto)
        {
            string archivo = Path.Combine(GetAppPath(), "movimientos.txt");
            string datos = $"{unMovimiento.Id};{unMovimiento.Cantidad};{unMovimiento.Fecha};{idProducto}";

            using (StreamWriter archivoSalida = new StreamWriter(archivo, true))
            {
                archivoSalida.WriteLine(datos);
            }
        }

        public static List<Movimiento> ObtenerMovimientosProducto(Producto unProducto)
        {
            string archivo = Path.Combine(GetAppPath(), "movimientos.txt");
            List<Movimiento> movimientos = new List<Movimiento>();

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);
                foreach (string movimientoComoTexto in lineas)
                {
                    var datos = movimientoComoTexto.Split(";");
                    if (unProducto.ID == datos[datos.Length - 1])
                    {
                        Movimiento unMovimiento = new Movimiento(int.Parse(datos[0]), int.Parse(datos[1]), DateTime.Parse(datos[2]));
                        movimientos.Add(unMovimiento);
                    }
                }
            }

            return movimientos;
        }

        public static int ObtenerNuevoID_Movimiento()
        {
            string archivo = Path.Combine(GetAppPath(), "movimientos.txt");
            int ultimoID = 0;

            if (File.Exists(archivo))
            {
                string[] lineas = File.ReadAllLines(archivo);
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
