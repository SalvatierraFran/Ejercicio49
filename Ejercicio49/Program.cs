using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49
{
    class Program
    {
        static void Main(string[] args)
        {
            string seguir = "s";

            Avion unAvion = new Avion("Aerolineas Argentinas", 5);
            Barco unBarco = new Barco("Titanic", 7);

            unAvion.NombreEmpresa();
            unAvion.CantidadDeTransportes();

            unBarco.NombreEmpresa();
            unBarco.CantidadDeTransportes();

            HidroAvion Hidro = new HidroAvion("Hidroline", 3);

            Console.WriteLine("\n1.Acelerar\n2.Ascender\n3.Volar\n4.Descender\n5.Frenar\n6.Salir");

            do
            {
                Console.Write("Ingrese opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Hidro.Acelerar();
                        break;

                    case "2":
                        Hidro.Ascender();
                        break;

                    case "3":
                        Hidro.Volar();
                        break;

                    case "4":
                        Hidro.Descender();
                        break;

                    case "5":
                        Hidro.Frenar();
                        break;

                    case "6":
                        seguir = "n";
                        break;
                }
            } while (seguir == "s");

            Console.ReadKey();
        }
    }
}
