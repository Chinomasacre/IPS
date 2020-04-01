using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Entyti;

namespace Ejercicio
{
    class Program
    {
        public static LiquidacionService liquidacionService = new LiquidacionService();
        public static List<Liquidacion> Listaliquidaciones = new List<Liquidacion>();
        static void Main(string[] args)
        {
            int Opcion = 0;
            do
            {
                Console.Clear();

                Menu();
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Liquidacion liquidacion ;
                        string Numero, Identificacion, Tipo;

                        Console.WriteLine("Digite numero deLiquidacion");
                        Numero = Console.ReadLine();
                        Console.WriteLine("Digite numero de Identificacion");
                        Identificacion = Console.ReadLine();
                        Console.WriteLine("Digite tipo de afiliacion CONTRIBUTIVO/SUBSIDIADO");
                        Tipo = Console.ReadLine().ToUpper();
                        if(Tipo == "CONTRIBUTIVO")
                        {
                            liquidacion = new RegimenContributivo();
                            Console.WriteLine("Digite Salario Devengado");
                            liquidacion.SalarioDevengado = Convert.ToDecimal(Console.ReadLine());
                        }
                        else
                        {
                            liquidacion = new RegimenSubsidiado();
                        }
                        liquidacion.Numero = Numero;
                        liquidacion.Identificacion = Identificacion;
                        liquidacion.Tipo = Tipo;

                        Console.WriteLine("Digite Valor del Servicio");
                        liquidacion.ValorServicio = Convert.ToDecimal(Console.ReadLine());

                        liquidacion.calcularCuotaModerada();

                        Console.WriteLine(liquidacionService.Guardar(liquidacion));

                        break;
                    case 2:

                        Listaliquidaciones = liquidacionService.Consultar();
                        foreach (Liquidacion item in Listaliquidaciones)
                        {
                            Console.WriteLine($"Numero : {item.Numero}");
                            Console.WriteLine($"Identificacion: {item.Identificacion}");
                            Console.WriteLine($"Tipo De Afiliacion: {item.Tipo}");
                            Console.WriteLine($"Salario Devengado: {item.SalarioDevengado}");
                            Console.WriteLine($"Valor Del Servicio: {item.ValorServicio}");
                            Console.WriteLine($"Tope: {item.Tope}");
                            Console.WriteLine($"Cuota Moderada: {item.CuotaModerada}");
                            Console.WriteLine($"Tarifa: {item.Tarifa}");
                            Console.WriteLine($"_________________________________________________________________");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Digite Numero de Liquidacion a Eliminar: ");
                        liquidacionService.Eliminar(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Digite Numero de Liquidacion a Modificar: ");
                        liquidacion = liquidacionService.ConsultaIndividual(Console.ReadLine());
                        if (liquidacion != null)
                        {
                            Console.WriteLine("Digite el nuevo Valor de Servicio: ");
                            liquidacion.ValorServicio = Convert.ToDecimal(Console.ReadLine());
                            liquidacion.calcularCuotaModerada();
                            liquidacionService.Modificar(liquidacion);
                            Console.WriteLine("Modificado Correctamente...");
                        }
                        else
                        {
                            Console.WriteLine("No se encontro el numero d eliquidacion a modificar");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saliendo....");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta....");
                        break;
                }
                Console.ReadKey();
            } while (Opcion != 5);
            
        }

        public static void Menu()
        {
            Console.WriteLine("***MENU**");
            Console.WriteLine("1. REgistrar y Realizar Liqidacion");
            Console.WriteLine("2. Consultar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Modificar");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Digite Opcion: ");
        }
    }
}
