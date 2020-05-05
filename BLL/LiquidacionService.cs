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
            try
            {
                liquidacionRepository.Guardar(liquidacion);
                return $"Se ha guardado Correctamente";
            }
            catch(Exception e)
            {
                return $"Fallo en el Guardado: {e.Message} ";
            }
        }
        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
                respuestaConsulta.ListaLiquidaciones = liquidacionRepository.Consultar();
                
                if(respuestaConsulta.ListaLiquidaciones == null)
                {
                    respuestaConsulta.Mensaje = $"Lista Vacia";
                }
                else
                {
                    respuestaConsulta.Mensaje = $"Se ha consultado la Lista Correctamente";
                }
            }
            catch(Exception e)
            {
                respuestaConsulta.Mensaje = $"Error al Consultar: {e.Message}";
                respuestaConsulta.ListaLiquidaciones = null;
            }
            return respuestaConsulta;
        }
        public string Eliminar(string numeroLiquidacion)
        {
            try
            {
                liquidacionRepository.Eliminar(numeroLiquidacion);
                return $"Se ha Eliminado Correctamente";
            }
            catch (Exception e)
            {
                return $"Fallo al Eliminar: {e.Message} ";
            }
            
        }
        public string Editar(Liquidacion liquidacion)
        {
            try
            {
                liquidacionRepository.Editar(liquidacion);
                return $"Se ha Modificado Correctamente";
            }
            catch (Exception e)
            {
                return $"Fallo al Modificar: {e.Message} ";
            }
        }

        public RespuestaBusqueda Buscar(string numeroLiquidacion)
        {
            RespuestaBusqueda respuestaBusqueda = new RespuestaBusqueda();
            try
            {
                respuestaBusqueda.liquidacion = liquidacionRepository.Buscar(numeroLiquidacion);
                if(respuestaBusqueda.liquidacion == null)
                {
                    respuestaBusqueda.Mensaje = "No existe numero de Liquidacion";
                }
                else
                {
                    respuestaBusqueda.Mensaje = "Numero de Liquidacion Encontrado";
                }
            }
            catch(Exception e)
            {
                respuestaBusqueda.Mensaje = $"Error al buscar: {e.Message}";
                respuestaBusqueda.liquidacion = null;
            }
            
            return respuestaBusqueda;
        }
        public RespuestaConsulta ConsultarxTipo(string tipo)
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
                respuestaConsulta.ListaLiquidaciones = liquidacionRepository.ConsultarxTipo(tipo);

                if (respuestaConsulta.ListaLiquidaciones == null)
                {
                    respuestaConsulta.Mensaje = $"Lista Vacia";
                }
                else
                {
                    respuestaConsulta.Mensaje = $"Se ha consultado la Lista con filtro '{tipo}' Correctamente";
                }
            }
            catch (Exception e)
            {
                respuestaConsulta.Mensaje = $"Error al Consultar: {e.Message}";
                respuestaConsulta.ListaLiquidaciones = null;
            }
            return respuestaConsulta;
        }
        public RespuestaConsulta ConsultarxFecha(DateTime fechaInicio,DateTime fechaFinal)
        {
            RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
            try
            {
                if (fechaInicio.Month > fechaFinal.Month || fechaInicio.Year>fechaFinal.Year)
                {
                    respuestaConsulta.ListaLiquidaciones = null;
                    respuestaConsulta.Mensaje = $"La Fecha de Inicio no puede ser mayor a la fecha final";
                }
                else
                {
                    respuestaConsulta.ListaLiquidaciones = liquidacionRepository.ConsultarxFecha(fechaInicio, fechaFinal);

                    if (respuestaConsulta.ListaLiquidaciones == null)
                    {
                        respuestaConsulta.Mensaje = $"Lista Vacia";
                    }
                    else
                    {
                        respuestaConsulta.Mensaje = $"Se ha consultado la Lista con filtro de fecha Correctamente";
                    }
                }
            }
            catch (Exception e)
            {
                respuestaConsulta.Mensaje = $"Error al Consultar: {e.Message}";
                respuestaConsulta.ListaLiquidaciones = null;
            }
            return respuestaConsulta;
        }
        public int TotalCantidad()
        {
            return liquidacionRepository.TotalCantidad();
        }
        public int TotalCantidadTipo(string tipo)
        {
            return liquidacionRepository.TotalCantidadTipo(tipo);
        }
        public decimal ValorTotal()
        {
            return liquidacionRepository.ValorTotal();
        }
        public decimal ValorTotalTipo(string tipo)
        {
            return liquidacionRepository.ValorTotalTipo(tipo);
        }
        public IList<Liquidacion> ConsultarNombre(string letra)
        {
            return liquidacionRepository.ConsultarNombre(letra);
        }


        public class RespuestaConsulta
        {
            public string Mensaje { get; set; }
            public IList<Liquidacion> ListaLiquidaciones { get; set; }
            //public bool Error { get; set; }
        }
        public class RespuestaBusqueda
        {
            public string Mensaje { get; set; }
            public Liquidacion liquidacion { get; set; }
           
            //public bool Error { get; set; }
        }
    }
}
