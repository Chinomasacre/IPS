using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entyti;

namespace BLL
{
    public class LiquidacionService
    {
        LiquidacionRepository liquidacionRepository;

        public LiquidacionService()
        {
            liquidacionRepository = new LiquidacionRepository();
        }
        public string Guardar(Liquidacion liquidacion)
        {
            return liquidacionRepository.Guardar(liquidacion);
        }
        public List<Liquidacion> Consultar()
        {
            return liquidacionRepository.Consultar();
        }
        public void Eliminar(string numeroLiquidacion)
        {
            liquidacionRepository.Eliminar(numeroLiquidacion);
        }
        public void Modificar(Liquidacion liquidacion)
        {
            liquidacionRepository.Modificar(liquidacion);
        }
        public Liquidacion ConsultaIndividual(string numeroLiquidacion)
        {
            return liquidacionRepository.ConsultaIndividual(numeroLiquidacion);
        }
    }
}
