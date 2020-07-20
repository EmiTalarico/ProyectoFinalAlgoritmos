using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TrabajoFinal
{
    public class Omnibus
    {
        public ArrayList omnibus = new ArrayList();
        

        public int cont_omnibus;

        private string marca;
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }


        private int modelo;
        public int Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }


        private int capacidad;
        public int Capacidad
        {
            set { capacidad = value; }
            get { return capacidad; }
        }

        private string tipo;
        public string Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }

        public Omnibus(int cont_omnibus, string Marca, int Modelo, int Capacidad, string Tipo)
        {
            this.cont_omnibus = cont_omnibus;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Capacidad = capacidad;
            this.Tipo = tipo;
        }

        public Omnibus()
        {
            Omnibus o = new Omnibus(cont_omnibus, Marca, Modelo, Capacidad, Tipo);
        }




        public void AltaOmnibus()
        {
            Console.WriteLine("Ingrese la marca: ");
            Marca = Console.ReadLine();
            

            Console.WriteLine("Ingrese el modelo: ");
            Modelo = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Ingrese la capacidad: ");
            Capacidad = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Ingrese el tipo de servicio: ");
            Tipo = Console.ReadLine();
            

            Omnibus o1 = new Omnibus(cont_omnibus, Marca, Modelo, Capacidad, Tipo);
            omnibus.Add(o1);

            cont_omnibus = cont_omnibus + 1;
            
            Console.WriteLine("Su producto fue dado de alta correctamente.");

            
        }

        public void ListarOmnibus()
        {

            for (int i = 0; i <omnibus.Count; i++)
            {
                Console.WriteLine(omnibus[i]);
            }

            foreach (Omnibus o in omnibus)
            {
                Console.WriteLine(o);
                
            }
            Console.ReadKey();

            
            
        }

    }
}
