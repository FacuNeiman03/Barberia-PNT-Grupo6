using System;
using System.Collections.Generic;
using System.Text;

namespace BarberiaGrupo6
{
   abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public abstract void verInfo();
    }
}
