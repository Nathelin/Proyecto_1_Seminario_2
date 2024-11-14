using C2_110924;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C2_110924
{
    internal class Producto
    {
        private string _id;
        private string _nombre;
        private int _cantidad;

        public Producto(string id, string nombre, int cantidad)
        {
            _id = id;
            _nombre = nombre;
            _cantidad = cantidad;
        }

        public string ID
        {
            get { return _id; }
            set
            {
                if (value != String.Empty)
                {
                    _id = value;
                }
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                if (value != String.Empty)
                {
                    _nombre = value;
                }
            }
        }

        public int Cantidad // ESTO SE TIENE QUE IR
        {
            get { return _cantidad; }
            set
            {
                if (value > 0)
                {
                    _cantidad = value;
                }
            }
        }
        public override string ToString()
        {
            // Personaliza la representación de la instancia como cadena
            return $"{_nombre} [{_id}] | Stock actual: {_cantidad}";
        }

        public int StockActual
        {
            get
            {
                int stockActual = 0;
                foreach (var movimiento in this._movimientos)
                {
                    stockActual += movimiento.Cantidad;
                }
                return stockActual;
            }
        }

        // Se define la lista de movimientos de stock
        private List<Movimiento> _movimientos = new List<Movimiento>();

        public void CargarMovimientos(List<Movimiento> listaMovimientos)
        {
            _movimientos = listaMovimientos;
        }

        // Se definen los métodos para agregar y restar stock
        public Movimiento agregarUnidades(int cantidadUnidades,
            DateTime fecha)
        {
            int nuevoID = ProductosService.ObtenerNuevoID();

            // Generamos el objeto para registrar el movimiento
            Movimiento carga = new Movimiento(nuevoID, cantidadUnidades, fecha);
            // Se agrega
            _movimientos.Add(carga);
            return carga;
        }

        public Movimiento restarUnidades(int cantidadUnidades,
            DateTime fecha)
        {
            int nuevoID = ProductosService.ObtenerNuevoID();

            // Generamos el objeto para registrar el movimiento
            Movimiento descarga = new Movimiento(nuevoID, -cantidadUnidades, fecha);

            // Se agrega
            _movimientos.Add(descarga);
            return descarga;
        }
    }
}
