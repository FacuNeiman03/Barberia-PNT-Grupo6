using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace BarberiaGrupo6
{
    class Barberia
    {
        public string Nombre { get; set; }
        private List<Turno> turnos;
        private List<Cliente> clientes;
        private List<Empleado> empleados;

        public Barberia(string nombre)
        {
            Nombre = nombre;
            turnos = new List<Turno>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
        }

       /* public void agregarCliente(Cliente cliente)
        {
            //TODO
        }

        public void agregarEmpleado(Empleado empleado)
        {
            //TODO
        }

        public bool anularTurno(Turno turno)
        {
            //TODO
            return false;
        }

        public bool reservarTurno(Cliente cliente, Empleado empleado)
        {
            //TODO 
            return false;
        }

        public bool modificarTurno(Turno turno)
        {
            //TODO
            return false;
        }

        public bool altaCliente(Cliente cliente)
        {
            //TODO 
            return false;
        }

        public bool bajaCliente(Cliente cliente)
        {
            //TODO 
            return false;
        }

        private Cliente buscarCliente(int idCliente)
        {
            //TODO
            return null;
        }

        public void recordarTurno()
        {
            //TODO
        }

        public void puntuar(int puntaje)
        {
            //TODO
        }*/
    }
}
