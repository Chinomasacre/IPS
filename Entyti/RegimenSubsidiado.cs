using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entyti
{
    public class RegimenSubsidiado:Liquidacion
    {
        public RegimenSubsidiado()
        {
            SalarioDevengado = 0;
        }
        public override decimal ObtenerTarifa()
        {
            return 5;
        }

        public override decimal ObtenerTope()
        {
            return 200000;
        }
        
    }
}
