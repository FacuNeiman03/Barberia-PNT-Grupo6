using System;
using System.Collections.Generic;
using System.Text;

namespace BarberiaGrupo6
{
    class Sucursal
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int IdSucursal { get; }

        public Sucursal(int id, string calle, int numero)
        {
            IdSucursal = id;
            Calle = calle;
            Numero = numero;
        }

        public string getDireccion() {
           return Calle + " " + Numero; 
        }
    }
}
