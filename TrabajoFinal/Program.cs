using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace TrabajoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            Console.ReadLine();
        }

        public static void Header()
        {
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("*****                                   Micritos                                    *****");
            Console.WriteLine("*****************************************************************************************");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void MenuPrincipal()
        {
            int opcion;
            Header();
            Console.WriteLine("1) Armado de recorridos");
            Console.WriteLine("2) Gestion de choferes");
            Console.WriteLine("3) Venta de pasajes");
            Console.WriteLine("4) Estadisticas");
            Console.WriteLine("5) Salir del sistema");

            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    SubMenu1();
                    break;

                case 2:
                    Console.Clear();
                    SubMenu2();
                    break;

                case 3:
                    Console.Clear();
                    SubMenu3();
                    break;

                case 4:
                    Console.Clear();
                    SubMenu4();
                    break;

                case 5:
                    break;

                default:
                    Console.WriteLine("Opcion no valida ");
                    break;
            }

        }

        public static void SubMenu1()
        {
            Omnibus o1 = new Omnibus();
            int opcion;
            Header();
            Console.WriteLine("1) Alta de terminales");
            Console.WriteLine("2) Alta de omnibus");
            Console.WriteLine("3) Alta de recorridos");
            Console.WriteLine("4) Volver");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    o1.AltaOmnibus();
                    MenuPrincipal();
                    break;

                case 3:
                    Console.Clear();
                    o1.ListarOmnibus();
                    Console.ReadKey(true);
                    MenuPrincipal();
                    break;

                case 4:
                    Console.Clear();
                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }


        public static void SubMenu2()
        {
            Header();
            int opcion;

            Console.WriteLine("1) Alta de choferes");
            Console.WriteLine("2) Alta de recorridos");
            Console.WriteLine("3) Volver");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.Clear();
                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }


        }

        public static void SubMenu3()
        {
            int opcion;
            Header();

            Console.WriteLine("1) Alta de usuarios");
            Console.WriteLine("2) Compra de pasajes");
            Console.WriteLine("3) Volver");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.Clear();
                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }


        public static void SubMenu4()
        {
            int opcion;
            Header();

            Console.WriteLine("1) Consultar total de pasajes vendidos");
            Console.WriteLine("2) Consultar usuarios");
            Console.WriteLine("3) Consultar terminal como partida");
            Console.WriteLine("4) Consultar terminal como arribo");
            Console.WriteLine("5) Volver");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {

                case 1:
                    Console.WriteLine("1");
                    break;

                case 2:
                    Console.WriteLine("2");
                    break;

                case 3:
                    Console.WriteLine("3");
                    break;

                case 4:
                    Console.WriteLine("4");
                    break;

                case 5:
                    Console.Clear();
                    MenuPrincipal();
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
    }
}
