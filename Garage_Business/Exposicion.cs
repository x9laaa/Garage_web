using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Business
{
   public class Exposicion: Evento
    {
        public string Expositor { get; set; }
        public string Categoria { get; set; }
        public Exposicion(string id, string nombre, DateTime fecha, string direccion, int precio, string expositor, string categoria)
            : base( id, nombre, fecha, direccion, precio)
        {
            Expositor = expositor;
            Categoria = categoria;
        }



    }
}
