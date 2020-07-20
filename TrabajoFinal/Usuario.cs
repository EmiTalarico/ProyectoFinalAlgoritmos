using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinal
{
    class Usuario
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


        private string fechaNacimiento;
        public string FechaNacimiento
        {
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }


    }
}
