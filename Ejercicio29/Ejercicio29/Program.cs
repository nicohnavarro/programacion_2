using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo1=new Equipo(11,"Barcelona");
            Equipo equipo2 = new Equipo(11, "Juventus");

            Jugador jugador1 = new Jugador(35462712,"Messi",20,10);
            Jugador jugador2 = new Jugador(35462712, "Messi", 30, 10);
            Jugador jugador3 = new Jugador(32262712, "Cristiano", 40, 10);

            if(equipo1+jugador1)
            {
                Console.WriteLine("Se Agrego a Leo");
            }
            if(!(equipo1+jugador2))
            {
                Console.WriteLine("no Se Agrego a Leo2");
            }
            if (equipo1 + jugador3)
            {
                Console.WriteLine("Se Agrego a Ronaldo");
            }
            Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());
            Console.WriteLine(equipo1.ShowTeam());
            Console.ReadKey();


        }
    }
}
