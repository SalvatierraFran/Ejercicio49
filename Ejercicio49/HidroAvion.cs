using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49
{
    class HidroAvion:Barco, IVolador
    {
        public HidroAvion(string Empresa, int Cantidad):base(Empresa, Cantidad)
        { }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void Ascender()
        {
            Console.WriteLine("Ascendiendo!");
        }

        public void Volar()
        {
            Console.WriteLine("Volando...");
        }

        public void Descender()
        {
            Console.WriteLine("Descendiendo...");
        }

        public void Frenar()
        {
            Console.WriteLine("Frenando.");
        }
    }
}
