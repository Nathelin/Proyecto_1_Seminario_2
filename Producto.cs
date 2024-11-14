//using C2_110924;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Seminario2Grupo13
{
    internal class Producto
    {
        private string _id;
        private string _nombre;
  

        public Producto(string id, string nombre)
        {
            _id = id;
            _nombre = nombre;
           
        }

        public string ID
        {
            get { return _id; }
            private set { _id = value; }
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

        
        public override string ToString()
        {
            // Personaliza la representación de la instancia como cadena
            return $"{_nombre} [{_id}] | Stock actual: ";
        }

        /*
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
        } */

       

    }
}
