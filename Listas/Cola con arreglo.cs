using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Cola
    {
        private List<string> _lista;
        public Cola()
        {
            _lista = new List<string>();
        }
        // Agrega un nuevo elemento al final de la cola
        public void Agregar(string dato)
        {
            _lista.Add(dato);
        }
        // Elimina el elemento del frente de la cola
        public void Eliminar()
        {
            if (_lista.Count == 0) 
            {
                throw new Exception("Cola vacia");
            }
            _lista.RemoveAt(0);
    }
        // Imprimir todos los elementos desde el frente hasta el final
        public string Imprimir()
        {
            string datos = string.Empty;
            foreach (var item in _lista)
            {
                datos += item + Environment.NewLine;
            }
            return datos;
        }   
    }
}
