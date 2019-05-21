using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carrera;
namespace ConsoleVista
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia1 = new Competencia(8, 4, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto1 = new MotoCross(1, "Corven", 4);
            MotoCross moto2 = new MotoCross(2, "Ducatti", 4);
            MotoCross moto3 = new MotoCross(1, "Corven", 3);
            AutoF1 auto1 = new AutoF1(3, "Ferrari");

            if(moto1==moto2)
                Console.WriteLine("Anda ==");
            if(moto1!=moto2)
                Console.WriteLine("No anda !=");
            if(moto1==moto3)
                Console.WriteLine("No anda ==");
            if(moto1!=moto3)
                Console.WriteLine("Anda !=");
            Console.ReadKey();

            if (competencia1 + moto1)
                Console.WriteLine("Se Agrego 1!");
            if (competencia1 + moto2)
                Console.WriteLine("Se Agrego 2!");
            if (moto1 == moto3)
            {
                Console.WriteLine("Son iguales 1 -3!");
                Console.WriteLine(competencia1.MostrarDatos());
            }
            try
            {
                if(competencia1 + auto1) { }
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
