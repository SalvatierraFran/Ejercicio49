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
            Avion unAvion = new Avion("Aerolineas Argentinas", 5);
            Barco unBarco = new Barco("Titanic", 7);

            unAvion.NombreEmpresa();
            unAvion.CantidadDeTransportes();

            unBarco.NombreEmpresa();
            unBarco.CantidadDeTransportes();

            Console.ReadKey();
        }
    }
}
