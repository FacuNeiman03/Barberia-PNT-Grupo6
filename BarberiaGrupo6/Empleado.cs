using System;
using System.Collections.Generic;
using System.Text;

namespace BarberiaGrupo6
{
    class Empleado:Persona
    {
        public int IdEmpleado { get; }
        public double PuntuacionPromedio { get; }

        public Empleado(int id, string nombre, string apellido): base(nombre, apellido)
        {
            PuntuacionPromedio = 0;
            IdEmpleado = id;
        }



        public override void verInfo()
        {
            //TODO
        }
    }
}
