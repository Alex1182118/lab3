using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class Medicamento
    {
        public int ID  { set; get; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public string Existencia { set; get; }

        public Medicamento()
        {

        }
           
    }
}
