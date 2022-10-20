using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BarberiaGrupo6
{
    class Cliente:Persona
    {
        public int IdCliente { get; }
        public string Telefono { get; set; }
        private string password;
        private List<Turno> turnos;

        public Cliente(int id, string nombre, string apellido, string telefono, string password) : base(nombre, apellido)
        {
            IdCliente = id;
            Telefono = telefono;
            this.password = password;
            this.turnos = new List<Turno>();
        }

        /*
        public void editarDatos()
        {
            //TODO
        }

        public void listarTurnos()
        {
            //TODO
        }
        */
        public override void verInfo()
        {
            //TODO
        }
    }
}
