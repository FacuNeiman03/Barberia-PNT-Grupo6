using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BarberiaGrupo6
{
    class Turno
    {
        public DateTime Fecha { get;  set ;}
        public MetodoPago MetodoPago { get; set; }
        private List<Servicio> tiposServicio; 
        public Sucursal Sucursal { get; set; }
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public string Comentario { get; set; }

        public Turno(DateTime fecha, MetodoPago metodoPago, Sucursal sucursal, Cliente cliente, string comentario, Empleado empleado)
        {
            this.tiposServicio = new List<Servicio>();
            Fecha = fecha;
            MetodoPago = metodoPago;
            Sucursal = sucursal;
            Empleado = empleado;
            Cliente = cliente;
            Comentario = comentario;
        }

        public Turno(DateTime fecha, MetodoPago metodoPago, Sucursal sucursal, Empleado empleado, Cliente cliente)
        {
            this.tiposServicio = new List<Servicio>();
            Fecha = fecha;
            MetodoPago = metodoPago;
            Sucursal = sucursal;
            Empleado = empleado;
            Cliente = cliente;
        }

        public Turno(DateTime fecha, MetodoPago metodoPago, Sucursal sucursal, string comentario, Cliente cliente)
        {
            this.tiposServicio = new List<Servicio>();
            Fecha = fecha;
            MetodoPago = metodoPago;
            Sucursal = sucursal;
            Comentario = comentario;
            Cliente = cliente;
        }

        public Turno(DateTime fecha, MetodoPago metodoPago, Sucursal sucursal, Cliente cliente)
        {
            this.tiposServicio = new List<Servicio>();
            Fecha = fecha;
            MetodoPago = metodoPago;
            Sucursal = sucursal;
            Cliente = cliente;
        }

        public void mostrar()
        {
            String aux = "";
            if(Empleado != null)
            {
                aux += "\nEmpleado: " + Empleado.Nombre + " " + Empleado.Apellido;
            }
            if(Comentario != "" && Comentario != null)
            {
                aux += "\nComentario: " + Comentario;
            }
            Console.WriteLine("Nombre: " + Cliente.Nombre  + " " + Cliente.Apellido + "\nFecha: " + Fecha.ToShortDateString() + "\nMetodo de pago: " + MetodoPago.ToString() + 
                "\nSucursal: " + Sucursal.getDireccion() + aux);
        }

       /* public void agregarTipoServicio(Servicio tipoServicio)
        {
            //TODO
        }*/

    }
}
