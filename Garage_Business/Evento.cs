﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Business
{
    public class Evento
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public int Precio { get; set; }

        public Evento(string id,string nombre, DateTime fecha, string direccion, int precio)
        {
            Id = id;
            Nombre = nombre;
            Fecha = fecha;
            Direccion = direccion;
            Precio = precio;
        }
    }
}
