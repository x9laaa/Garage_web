using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Data
{
     public static class EventoCollection
    {
        private static List<EventoEntity> _eventoCollection = new List<EventoEntity>();
        public static List<EventoEntity> EventoCollectionList 
        { 
            get { return _eventoCollection; }
            set { _eventoCollection = value; }
        }
    }

}
