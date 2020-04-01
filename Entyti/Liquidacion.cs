using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entyti
{
    public abstract class Liquidacion
    {
        public string Numero { get; set; }
        public string Identificacion { get; set; }
        public string Tipo { get; set; }
        public decimal SalarioDevengado { get; set; }
        public decimal ValorServicio { get; set; }
        public decimal Tarifa { get; set; }
        public decimal Tope { get; set; }
        public decimal CuotaModerada { get; set; }


        public decimal calcularCuotaModerada()
        {
            Tarifa = ObtenerTarifa();
            Tope = ObtenerTope();
            CuotaModerada = ValorServicio * (Tarifa/100) + ValorServicio;
            ValidarCuota();
            return CuotaModerada;
        }
        public abstract decimal ObtenerTarifa();
        public abstract decimal ObtenerTope();
        public void ValidarCuota()
        {
            if (CuotaModerada > Tope)
            {
                CuotaModerada = Tope;
            }
        }

    }
}
