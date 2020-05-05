using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entyti;


namespace DAL
{
    public class LiquidacionRepository
    {
        string ruta = @"Liquidacion.txt";
        IList<Liquidacion> Listaliquidaciones;
        public LiquidacionRepository()
        {
            Listaliquidaciones = new List<Liquidacion>();
        }
        public void Guardar(Liquidacion liquidacion)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{liquidacion.Numero};{liquidacion.Identificacion};{liquidacion.Nombre};" +
                $"{liquidacion.Tipo};{liquidacion.SalarioDevengado};{liquidacion.Fecha.ToString("dd/MM/yyyy")}" +
                $";{liquidacion.ValorServicio};{liquidacion.Tope};{liquidacion.Tarifa};{liquidacion.CuotaModerada}");
            escritor.Close();
            file.Close();
        }
        public IList<Liquidacion> Consultar()
        {
            Listaliquidaciones.Clear();

            string Linea = string.Empty;
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader escritor = new StreamReader(file);
            while ((Linea = escritor.ReadLine()) != null)
            {
                Liquidacion liquidacionCuotaModerada = Mapear(Linea);
                Listaliquidaciones.Add(liquidacionCuotaModerada);
            }
            escritor.Close();
            file.Close();

            return Listaliquidaciones;
        }
        public Liquidacion Mapear(string linea)
        {
            Liquidacion liquidacion;
            char delimiter = ';';
            string[] Datos = linea.Split(delimiter);

            if (Datos[3] == "SUBSIDIADO")
            {
                liquidacion = new RegimenSubsidiado();
            }
            else
            {
                liquidacion = new RegimenContributivo();
            }
            liquidacion.Numero = Datos[0];
            liquidacion.Identificacion = Datos[1];
            liquidacion.Nombre = Datos[2];
            liquidacion.Tipo = Datos[3];
            liquidacion.SalarioDevengado = Convert.ToDecimal(Datos[4]);
            liquidacion.Fecha = Convert.ToDateTime(Datos[5]);
            liquidacion.ValorServicio = Convert.ToDecimal(Datos[6]);
            liquidacion.Tope = Convert.ToDecimal(Datos[7]);
            liquidacion.Tarifa = Convert.ToDecimal(Datos[8]);
            liquidacion.CuotaModerada = Convert.ToDecimal(Datos[9]);
            
            return liquidacion;
        }
        public void Eliminar(string numeroLiquidacion)
        {
            Listaliquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in Listaliquidaciones)
            {
                if (item.Numero != numeroLiquidacion)
                {
                    Guardar(item);
                }
            }
        }
        public void Editar(Liquidacion liquidacion)
        {
            
            Listaliquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in Listaliquidaciones)
            {
                if (item.Numero != liquidacion.Numero)
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(liquidacion);
                }
            }
        }
        public Liquidacion Buscar(string numeroLiquidacion)
        {
            Listaliquidaciones = Consultar();
            return Listaliquidaciones.Where(L=> L.Numero.Equals(numeroLiquidacion)).FirstOrDefault();
        }

        public IList<Liquidacion> ConsultarxTipo(string tipo)
        {
            Listaliquidaciones = Consultar();
            Listaliquidaciones = Listaliquidaciones.Where(L => L.Tipo == (tipo)).ToList();
            return Listaliquidaciones;
        }
        public int TotalCantidad()
        {
            return Listaliquidaciones.Count();
        }
        public int TotalCantidadTipo(string tipo)
        {
            return Listaliquidaciones.Where(L => L.Tipo == (tipo)).Count();
        }
        public decimal ValorTotal()
        {
            return Listaliquidaciones.Sum(L => L.CuotaModerada);
        }
        public decimal ValorTotalTipo(string tipo)
        {
            return Listaliquidaciones.Where(L => L.Tipo == (tipo)).Sum(L => L.CuotaModerada);
        }
        public IList<Liquidacion> ConsultarxFecha(DateTime fechaInicial,DateTime fechaFinal)
        {
            Listaliquidaciones = Consultar();
            if (fechaInicial.Date > fechaFinal.Date)
            {
                Listaliquidaciones = Listaliquidaciones.Where(L => L.Fecha.Month == fechaInicial.Month).ToList();
            }
            else
            {
                Listaliquidaciones = Listaliquidaciones.Where(L => L.Fecha.Date >= fechaInicial.Date && L.Fecha.Date <= fechaFinal.Date).ToList();
            }
            return Listaliquidaciones;
        }
        public IList<Liquidacion> ConsultarNombre(string letra)
        {
            Listaliquidaciones = Consultar();
            Listaliquidaciones = Listaliquidaciones.Where(L => L.Nombre.Contains(letra)).ToList();
            return Listaliquidaciones;
        }
    }
}
