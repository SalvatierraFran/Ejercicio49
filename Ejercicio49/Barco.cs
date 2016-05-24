using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49
{
    class Barco:Transporte
    {
        public Barco(string Empresa, int Cantidad):base(Empresa, Cantidad)
        { }

        public override void NombreEmpresa()
        {
            Console.WriteLine("Nombre de la empresa: " + this._nombreEmpresa);
        }

        public override void CantidadDeTransportes()
        {
            Console.WriteLine("Cantidad de transportes: " + this._cantTransportes);
        }
    }
}
