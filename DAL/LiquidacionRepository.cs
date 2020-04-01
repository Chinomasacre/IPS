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
        List<Liquidacion> Listaliquidaciones;

        public string Guardar(Liquidacion liquidacion)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{liquidacion.Numero};{liquidacion.Identificacion};{liquidacion.Tipo};{liquidacion.SalarioDevengado}" +
                $";{liquidacion.ValorServicio};{liquidacion.Tope};{liquidacion.Tarifa};{liquidacion.CuotaModerada}");
            escritor.Close();
            file.Close();
            return "Guardado Correctamente ";
        }
        public List<Liquidacion> Consultar()
        {
            Listaliquidaciones = new List<Liquidacion>();

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
            Liquidacion liquidacion = new RegimenContributivo();
            char delimiter = ';';
            string[] Datos = linea.Split(delimiter);
            liquidacion.Numero = Datos[0];
            liquidacion.Identificacion = Datos[1];
            liquidacion.Tipo = Datos[2];
            liquidacion.SalarioDevengado = Convert.ToDecimal(Datos[3]);
            liquidacion.ValorServicio = Convert.ToDecimal(Datos[4]);
            liquidacion.Tope = Convert.ToDecimal(Datos[5]);
            liquidacion.Tarifa = Convert.ToDecimal(Datos[6]);
            liquidacion.CuotaModerada = Convert.ToDecimal(Datos[7]);
            
            return liquidacion;
        }
        public void Eliminar(string numeroLiquidacion)
        {
            Listaliquidaciones.Clear();
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
        public void Modificar(Liquidacion liquidacion)
        {
            Listaliquidaciones.Clear();
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
                    liquidacion.calcularCuotaModerada();

                    Guardar(liquidacion);
                }
            }
        }
        public Liquidacion ConsultaIndividual(string numeroLiquidacion)
        {
            Listaliquidaciones.Clear();
            Listaliquidaciones = Consultar();
            foreach (var item in Listaliquidaciones)
            {
                if (item.Numero == numeroLiquidacion)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
