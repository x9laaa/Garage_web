using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_Data;

namespace Garage_Business
{
    
    public static class EventoController
    {
        public static string AddEvento(Evento e)
        {
            if (e is Concierto concierto)
            {
                EventoCollection.EventoCollectionList.Add(new ConciertoEntity(
                    concierto.Nombre,
                    concierto.Fecha,
                    concierto.Direccion,
                    concierto.Precio,
                    concierto.Artista,
                    concierto.Estilo)
                    );
              
                return "Concierto agregado correctamente.";

            }
            else if (e is Exposicion exposicion)
            {
                EventoCollection.EventoCollectionList.Add(new ExposicionEntity(
                    exposicion.Nombre,
                    exposicion.Fecha,
                    exposicion.Direccion,
                    exposicion.Precio,
                    exposicion.Expositor,
                    exposicion.Categoria
                ));
                return "Exposición agregada correctamente.";

            }
            return "Tipo de evento no reconocido.";
        }

        public static Evento GetEvento(string id)
        {
            EventoEntity encontrado = null;
            foreach (var e in EventoCollection.EventoCollectionList)
            {
                if (e.Id == id)
                {
                    encontrado = e;
                    break;
                }
            }

            if (encontrado == null)
                return null;

            if (encontrado is ConciertoEntity concierto)
            {
                return new Concierto
                (
                    concierto.Id,
                    concierto.Nombre,
                    concierto.Fecha,
                    concierto.Direccion,
                    concierto.Precio,
                    concierto.Artista,
                    concierto.Estilo
                );
            }

            if (encontrado is ExposicionEntity exposicion)
            {
                return new Exposicion
                (
                    exposicion.Id,
                    exposicion.Nombre,
                    exposicion.Fecha,
                    exposicion.Direccion,
                    exposicion.Precio,
                    exposicion.Expositor,
                    exposicion.Categoria
                );
            }
            return null;
        }

        public static List<Evento> GetEvents()
        {
            List<Evento> eventos = new List<Evento>();

            foreach (var item in EventoCollection.EventoCollectionList)
            {
                if (item is ConciertoEntity concierto)
                {
                    eventos.Add(new Concierto(
                        concierto.Id,
                        concierto.Nombre,
                        concierto.Fecha,
                        concierto.Direccion,
                        concierto.Precio,
                        concierto.Artista,
                        concierto.Estilo
                    ));
                }
                else if (item is ExposicionEntity exposicion)
                {
                    eventos.Add(new Exposicion
                    (
                        exposicion.Id,
                        exposicion.Nombre,
                        exposicion.Fecha,
                        exposicion.Direccion,
                        exposicion.Precio,
                        exposicion.Expositor,
                        exposicion.Categoria
                    ));
                }
            }

            return eventos;
        }
    }
}
