using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio49
{
    public abstract class Transporte
    {
        protected string _nombreEmpresa;
        protected int _cantTransportes;

        public Transporte(string Empresa, int Cantidad)
        {
            this._nombreEmpresa = Empresa;
            this._cantTransportes = Cantidad;
        }

        public abstract void NombreEmpresa();

        public abstract void CantidadDeTransportes();
    }
}
