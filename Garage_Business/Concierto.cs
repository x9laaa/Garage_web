using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Business
{
    public class Concierto: Evento
    {
        
        public string Artista {  get; set; }
        public string Estilo { get; set; }

        public Concierto( string id, string nombre, DateTime fecha, string direccion, int precio, string artista, string estilo)
        : base( id, nombre, fecha, direccion, precio)
        {
            Artista = artista;
            Estilo = estilo;
        }
    }
}
