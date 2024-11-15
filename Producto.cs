using System;
using System.Collections.Generic;

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
            return $"{_nombre} [{_id}]";
        }
    }
}
