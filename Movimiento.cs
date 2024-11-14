using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Seminario2Grupo13
{
    internal class Movimiento
    {
        public int Id { get; }
        public int Cantidad { get; }
        public DateTime Fecha { get; }

        public Movimiento(int id, int cantidad,
            DateTime fecha)
        {
            Id = id;
            Cantidad = cantidad;
            Fecha = fecha;
        }
    }
}
