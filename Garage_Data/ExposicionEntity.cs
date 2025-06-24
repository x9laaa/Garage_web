using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Data
{
    public class ExposicionEntity : EventoEntity
    {
        public string Expositor { get; set; }
        public string Categoria { get; set; }

        public ExposicionEntity(string nombre, DateTime fecha, string direccion, int precio, string expositor, string categoria)
      : base(nombre, fecha, direccion, precio)
        {
            Expositor = expositor;
            Categoria = categoria;
        }
    }
}
