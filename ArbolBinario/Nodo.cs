using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class Nodo<T>
    {
        //<T> Para recibir un Farmaco, Left and Right para ver a que lado se va el nodo, T Valor , para obtener los daros del FarmacoNodo
        public Nodo<T> Izquierda { get; set; }
        public Nodo<T> Derecha { get; set; }
        public T Informacion { get; set; }
        public int principal { get; set; }
        public string nombre { get; set; }
        public Nodo()
        {
        }
    }
}
