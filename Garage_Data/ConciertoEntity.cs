using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Data
{
    public class ConciertoEntity : EventoEntity
    {
        public string Artista { get; set; }
        public string Estilo { get; set; }

        public ConciertoEntity(string nombre, DateTime fecha, string direccion, int precio, string artista, string estilo)
       : base( nombre, fecha, direccion, precio)
        {
            Artista = artista;
            Estilo = estilo;
        }


    }

}
