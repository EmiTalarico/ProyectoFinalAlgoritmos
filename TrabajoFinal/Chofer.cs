using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Chofer
    {
        private string nombre;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }


        private string apellido;
        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }


        private int dni;
        public int Dni
        {
            set { dni = value; }
            get { return dni; }
        }



    }
}
